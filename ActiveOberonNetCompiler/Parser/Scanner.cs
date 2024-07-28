
namespace ActiveOberonNetCompiler.Parser
{
    public  class Scanner
    {

        public static Symbols IsReservedKeyword(string text, uint start, uint end, Trivia[] trivias) =>
            text switch
            {
                "address" or "ADDRESS" => new Address(start, end, trivias),
                "alias" or "ALIAS" => new Alias(start, end, trivias),
                _ => new Empty()
            };

    }
}
