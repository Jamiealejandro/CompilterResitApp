namespace Compiler.Nodes
{
	public class DoCommandNode : ICommandNode
    {   

        public IExpressionNode Expression { get; }
        public ICommandNode Command { get; }
        public IExpressionNode WendWhile { get; }

        public Position Position { get; }

        public DoCommandNode(ICommandNode command, IExpressionNode expression, IExpressionNode wendwhile, Position position)
        {   
            Command = command;
            Expression = expression;
            WendWhile = wendwhile;
            Position = position;
        }
    }
}