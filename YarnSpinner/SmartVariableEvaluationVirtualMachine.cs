using System;
using System.Collections.Generic;
using System.Globalization;

namespace Yarn
{

    /// <summary>
    /// A lightweight, static 'virtual machine' designed for evaluating smart
    /// variables.
    /// </summary>
    /// <remarks>
    /// This class implements a subset of the <see cref="Instruction"/>
    /// operations, and is designed for evaluating smart variable implementation
    /// nodes.
    /// </remarks>
    internal static class SmartVariableEvaluationVirtualMachine
    {
        /// <summary>
        /// Evaluates a smart variable.
        /// </summary>
        /// <typeparam name="T">The type of the variable to return.</typeparam>
        /// <param name="name">The name of the smart variable.</param>
        /// <param name="variableAccess">An <see cref="IVariableAccess"/> object
        /// that can be used for fetching variable values.</param>
        /// <param name="library">A <see cref="Library"/> containing functions
        /// to use while evaluating the variable.</param>
        /// <param name="result">On return, the computed value of the smart
        /// variable.</param>
        /// <returns><see langword="true"/> if the variable could be fetched as
        /// type <typeparamref name="T"/>; <see langword="false"/>
        /// otherwise.</returns>
        /// <exception cref="ArgumentNullException">Thrown if <paramref
        /// name="variableAccess"/> or <paramref name="library"/> is
        /// null.</exception>
        /// <exception cref="ArgumentException">Thrown if <paramref
        /// name="name"/> is null or empty.</exception>
        /// <exception cref="InvalidOperationException">Thrown if an error
        /// occurs during the evaluation of the variable.</exception>
        public static bool TryGetSmartVariable<T>(
            string name,
            IVariableAccess variableAccess,
            Library library,
            out T result)
        {
            if (variableAccess is null)
            {
                throw new ArgumentNullException(nameof(variableAccess));
            }

            if (library is null)
            {
                throw new ArgumentNullException(nameof(library));
            }

            if (variableAccess.Program is null)
            {
                throw new InvalidOperationException($"{nameof(variableAccess.Program)} cannot be null");
            }

            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException($"'{nameof(name)}' cannot be null or empty.", nameof(name));
            }

            var stack = new Stack<Value>();

            if (variableAccess.Program.Nodes.TryGetValue(name, out Node smartVariableNode) == false)
            {
                // No node with this name exists. Return a value indicating that
                // we failed to get the smart variable's value.
                result = default!;
                return false;
            }

            var programCounter = 0;

            try
            {
                while (programCounter < smartVariableNode.Instructions.Count)
                {
                    var instruction = smartVariableNode.Instructions[programCounter];
                    if (EvaluateInstruction(instruction, variableAccess, library, stack, ref programCounter) == false)
                    {
                        break;
                    }
                }
            }
            catch (InvalidOperationException e)
            {
                throw new InvalidOperationException($"Error when evaluating smart variable {name}: {e.Message}");
            }

            if (stack.Count < 1)
            {
                throw new System.InvalidOperationException("Error when evaluating smart variable: stack did not contain a value after evaluation");
            }

            Value calculatedResult = stack.Pop();

            if (stack.Count > 0)
            {
                throw new InvalidOperationException($"Error when evaluating smart variable: stack had {stack.Count} dangling value(s)");
            }

            return TryConvertToType(calculatedResult.InternalValue, out result);
        }

        /// <summary>
        /// Retrieves a collection of content saliency options available for the
        /// specified node group.
        /// </summary>
        /// <remarks>
        /// This method iterates through all nodes in the program to find those
        /// that belong to the specified node group. It calculates the
        /// complexity score and counts the number of conditions that pass or
        /// fail for each node, then creates a saliency option for each
        /// qualifying node.
        /// </remarks>
        /// <param name="nodeGroupName">The name of the node group to search for
        /// available content.</param>
        /// <param name="variableAccess">The object to use when accessing
        /// variables.</param>
        /// <param name="library">The library containing function
        /// definitions.</param>
        /// <returns>An enumerable collection of <see
        /// cref="Saliency.ContentSaliencyOption"/> objects representing
        /// available content saliency options for the specified node
        /// group.</returns>
        /// <exception cref="ArgumentException">Thrown when the provided
        /// <paramref name="nodeGroupName"/> is not a valid node group name in
        /// the program.</exception>
        internal static IEnumerable<Saliency.ContentSaliencyOption> GetSaliencyOptionsForNodeGroup(
            string nodeGroupName,
            IVariableAccess variableAccess,
            Library library
            )
        {
            // Retrieve the program from the variable access.
            var program = variableAccess.Program
                ?? throw new InvalidOperationException($"{nameof(variableAccess.Program)} cannot be null");

            // Check if the specified node group exists in the program.
            if (program.Nodes.ContainsKey(nodeGroupName) == false)
            {
                throw new ArgumentException($"Error getting available content for node group {nodeGroupName}: not a valid node group name");
            }

            // Create a new HashSet to store the saliency options that we'll
            // return.
            var options = new HashSet<Saliency.ContentSaliencyOption>();

            // Iterate through all nodes in the program.
            foreach (var node in program.Nodes)
            {
                // Check if the current node belongs to the specified node
                // group. Skip this node if it doesn't.
                if (node.Value.NodeGroup != nodeGroupName)
                {
                    continue;
                }

                int passingCount = 0, failingCount = 0;

                // Retrieve the saliency condition variables for the current
                // node.
                var conditions = node.Value.ContentSaliencyConditionVariables;

                // Iterate through each condition and evaluate its result.
                foreach (var condition in conditions)
                {
                    if (TryGetSmartVariable<bool>(condition, variableAccess, library, out var conditionResult))
                    {
                        // We've evaluated the condition's smart variable as a
                        // bool; update the running total of passing and failing
                        // conditions based on the result.
                        passingCount += conditionResult ? 1 : 0;
                        failingCount += conditionResult ? 0 : 1;
                    }
                    else
                    {
                        // This smart variable doesn't exist. That's an error.
                        throw new InvalidOperationException($"Failed to evaluate saliency condition smart variable {condition}: variable not found in program");
                    }
                }

                // Create a new saliency option for the node and add it to the
                // set of options.
                options.Add(new Saliency.ContentSaliencyOption(node.Value.Name)
                {
                    ComplexityScore = node.Value.ContentSaliencyConditionComplexityScore,
                    ContentType = Saliency.ContentSaliencyContentType.Node,
                    PassingConditionValueCount = passingCount,
                    FailingConditionValueCount = failingCount,
                });
            }

            // Return the set of saliency options found for the node group.
            return options;
        }

        private static bool TryConvertToType<T>(IConvertible value, out T result)
        {
            if (value.GetType() == typeof(T)
                || typeof(T).IsAssignableFrom(value.GetType()))
            {
                result = (T)value;
                return true;
            }

            try
            {
                result = (T)Convert.ChangeType(value, typeof(T), CultureInfo.InvariantCulture);
                return true;
            }
            catch (ArgumentException)
            {
                result = default!;
                return false;
            }
        }

        private static bool EvaluateInstruction(
            Instruction instruction,
            IVariableAccess variableAccess,
            Library library,
            Stack<Value> stack,
            ref int programCounter)
        {
            switch (instruction.InstructionTypeCase)
            {
                case Instruction.InstructionTypeOneofCase.PushString:
                    stack.Push(instruction.PushString.Value);
                    break;
                case Instruction.InstructionTypeOneofCase.PushFloat:
                    stack.Push(instruction.PushFloat.Value);
                    break;
                case Instruction.InstructionTypeOneofCase.PushBool:
                    stack.Push(instruction.PushBool.Value);
                    break;
                case Instruction.InstructionTypeOneofCase.Pop:
                    stack.Pop();
                    break;
                case Instruction.InstructionTypeOneofCase.CallFunc:
                    VirtualMachine.CallFunction(instruction, library, stack);

                    break;
                case Instruction.InstructionTypeOneofCase.PushVariable:
                    string variableName = instruction.PushVariable.VariableName;

                    if (variableAccess.TryGetValue<IConvertible>(variableName, out var variableContents))
                    {
                        stack.Push(Value.From(variableContents));
                    }
                    else
                    {
                        throw new System.InvalidOperationException($"Failed to fetch any value for {variableName} when evaluating a smart variable");
                    }
                    break;
                case Instruction.InstructionTypeOneofCase.JumpIfFalse:
                    if (stack.Peek().ConvertTo<bool>() == false)
                    {
                        // Set the program counter directly
                        programCounter = instruction.JumpIfFalse.Destination;
                        return true;
                    }
                    else
                    {
                        // Fall through to the next instruction
                        programCounter += 1;
                        return true;
                    }
                case Instruction.InstructionTypeOneofCase.Stop:
                    // Return false to indicate we should stop evaluating
                    // instructions
                    return false;
                default:
                    throw new InvalidOperationException($"Invalid opcode {instruction.InstructionTypeCase} when evaluating a smart variable");
            }

            programCounter += 1;

            // Return true to indicate that we should continue
            return true;
        }


    }
}
