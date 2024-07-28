
namespace ActiveOberonNetCompiler.Parser
{
    public class SyntaxError(uint Position, string ModuleName, string Error) : Exception
    {
        public uint Position { get; private set; } = 0u;

        public string ModuleName { get; private set; } = string.Empty;

        public string Error { get; private set; } = string.Empty;
    }
}
