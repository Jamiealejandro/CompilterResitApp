namespace Compiler.Nodes
{

    public class UntilCommandNode : ICommandNode
    {
        public IExpressionNode Expression { get; }
        public Position Position { get; }

        public UntilCommandNode(IExpressionNode expression, Position position)
        {
            Expression = expression;
            Position = position;
        }
    }

}