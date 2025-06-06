// Copyright Yarn Spinner Pty Ltd
// Licensed under the MIT License. See LICENSE.md in project root for license information.

namespace Yarn.Compiler
{
    using Antlr4.Runtime.Misc;
    using System.Collections.Generic;
    using System.Linq;

    internal class JumpGraphListener : YarnSpinnerParserBaseListener
    {
        private readonly List<string> jumps = new List<string>();
        private string? currentNode;
        private (int x, int y) position;
        private bool hasPositionalInformation; // tuples are value type so I can't null check them

        private readonly List<GraphingNode> connections;

        public JumpGraphListener(List<GraphingNode> connections)
        {
            this.connections = connections;
        }

        public override void EnterNode([NotNull] YarnSpinnerParser.NodeContext context)
        {
            jumps.Clear();
            currentNode = null;
            hasPositionalInformation = false;
        }
        public override void ExitNode([NotNull] YarnSpinnerParser.NodeContext context)
        {
            if (jumps.Count() > 0 && !string.IsNullOrEmpty(currentNode))
            {
                var node = new GraphingNode
                {
                    node = this.currentNode ?? "(unknown)",
                    jumps = this.jumps.ToArray(),
                    hasPositionalInformation = this.hasPositionalInformation,
                    position = this.position,
                };
                this.connections.Add(node);
            }
        }

        public override void ExitTitle_header([NotNull] YarnSpinnerParser.Title_headerContext context)
        {
            currentNode = context.title.Text ?? "<unknown>";
        }

        public override void ExitHeader([NotNull] YarnSpinnerParser.HeaderContext context)
        {
            if (context.header_key.Text.Equals("position"))
            {
                // later make it also extract x and y where possible
                var positionalString = context.header_value.Text;
                var split = positionalString.Split(',');
                var xString = split[0].Trim();
                var yString = split[1].Trim();

                if (int.TryParse(xString, out int x) && int.TryParse(yString, out int y))
                {
                    hasPositionalInformation = true;
                    position = (x, y);
                }
            }
        }

        public override void EnterJumpToNodeName([NotNull] YarnSpinnerParser.JumpToNodeNameContext context)
        {
            var destination = context.destination.Text;
            jumps.Add(destination);
        }
        // if we hit an expression jump we just bundle it all up as if it were a single string
        // inelegant but simple enough
        public override void EnterJumpToExpression([NotNull] YarnSpinnerParser.JumpToExpressionContext context)
        {
            var destination = context.expression().GetText();
            jumps.Add(destination);
        }
    }
}
