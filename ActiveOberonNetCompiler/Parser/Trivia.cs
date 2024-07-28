
namespace ActiveOberonNetCompiler.Parser
{
    public record Trivia(uint StartPos, uint EndPos);

    public record WhiteSpaceTrivia(uint StartPos, uint EndPos) : Trivia(StartPos, EndPos);
    public record TabTrivia(uint StartPos, uint EndPos) : Trivia(StartPos, EndPos);
    public record NewlineTrivia(uint StartPos, uint EndPos, char Ch1, char Ch2) : Trivia(StartPos, EndPos);
    public record CommentTrivia(uint StartPos, uint EndPos, string Text) : Trivia(StartPos, EndPos);
}
