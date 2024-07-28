
namespace ActiveOberonNetCompiler.Parser
{
    public  class Scanner
    {

        public static Symbols IsReservedKeyword(string text, uint start, uint end, Trivia[] trivias) =>
            text switch
            {
                "address" or "ADDRESS" => new Address(start, end, trivias),
                "alias" or "ALIAS" => new Alias(start, end, trivias),
                "array" or "ARRAY" => new Array(start, end, trivias),
                "await" or "AWAIT" => new Await(start, end, trivias),
                "begin" or "BEGIN" => new Begin(start, end, trivias),
                "by" or "BY" => new By(start, end, trivias),
                "const" or "CONST" => new Const(start, end, trivias),
                "case" or "CASE" => new Case(start, end, trivias),
                "cell" or "CELL" => new Cell(start, end, trivias),
                "cellnet" or "CELLNET" => new CellNet(start, end, trivias),
                "code" or "CODE" => new Code(start, end, trivias),
                "do" or "DO" => new Do(start, end, trivias),
                "div" or "DIV" => new Div(start, end, trivias),
                "end" or "END" => new End(start, end, trivias),
                "enum" or "ENUM" => new Enum(start, end, trivias),
                "else" or "ELSE" => new Else(start, end, trivias),
                "elsif" or "ELSIF" => new Elsif(start, end, trivias),
                "exit" or "EXIT" => new Exit(start, end, trivias),
                "extern" or "EXTERN" => new Extern(start, end, trivias),
                "false" or "FALSE" => new False(start, end, trivias),
                "for" or "FOR" => new For(start, end, trivias),
                "finally" or "FINALLY" => new Finally(start, end, trivias),
                "if" or "IF" => new If(start, end, trivias),
                "ignore" or "IGNORE" => new Ignore(start, end, trivias),
                "imag" or "IMAG" => new Imag(start, end, trivias),
                "in" or "IN" => new In(start, end, trivias),
                "is" or "IS" => new Is(start, end, trivias),
                "import" or "IMPORT" => new Import(start, end, trivias),
                "loop" or "LOOP" => new Loop(start, end, trivias),
                "module" or "MODULE" => new Module(start, end, trivias),
                "mod" or "MOD" => new Mod(start, end, trivias),
                "nil" or "NIL" => new Nil(start, end, trivias),
                "object" or "OBJECT" => new Object(start, end, trivias),
                "of" or "OF" => new Of(start, end, trivias),
                "or" or "OR" => new Or(start, end, trivias),
                "out" or "OUT" => new Out(start, end, trivias),
                "operator" or "OPERATOR" => new Operator(start, end, trivias),
                "pointer" or "POINTER" => new Pointer(start, end, trivias),
                "procedure" or "PROCEDURE" => new Procedure(start, end, trivias),
                "port" or "PORT" => new Port(start, end, trivias),
                "repeat" or "REPEAT" => new Repeat(start, end, trivias),
                "return" or "RETURN" => new Return(start, end, trivias),
                "self" or "SELF" => new Self(start, end, trivias),
                "new" or "NEW" => new New(start, end, trivias),
                "record" or "RECORD" => new Record(start, end, trivias),
                "result" or "RESULT" => new Result(start, end, trivias),
                "size" or "SIZE" => new Size(start, end, trivias),
                "then" or "THEN" => new Then(start, end, trivias),
                "to" or "TO" => new To(start, end, trivias),
                "type" or "TYPE" => new Type(start, end, trivias),
                "until" or "UNTIL" => new Until(start, end, trivias),
                "var" or "VAR" => new Var(start, end, trivias),
                "while" or "WHILE" => new While(start, end, trivias),
                "with" or "WITH" => new With(start, end, trivias),
                _ => new Empty()
            };

    }
}
