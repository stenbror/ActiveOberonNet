
using System.Text;

namespace ActiveOberonNetCompiler.Parser
{
    public class Scanner(string source, string moduleName = "")
    {
        private readonly string _moduleName = moduleName;
        private readonly string _source = source;
        private int _index = 0;
        private List<Trivia> _trivias = new List<Trivia>();

        public Symbols Symbol { get; private set; } = new EndOfFile(0, []);

        public uint Position { get; private set; } = 0;

        public static Tuple<Symbols, uint> IsOperatorOrDelimiters(char c1, char c2, char c3, uint start,
            Trivia[] trivias) =>
            (c1, c2, c3) switch
            {
                ( '.', '<', '=' ) => new Tuple<Symbols, uint>(new DotLessEqual(start, start +3, trivias), 3),
                ( '.', '>', '=') => new Tuple<Symbols, uint>(new DotGreaterEqual(start, start + 3, trivias), 3),
                ( '.', '#', _ ) => new Tuple<Symbols, uint>(new DotNotEqual(start, start + 2, trivias), 2),
                ( '.', '=', _ ) => new Tuple<Symbols, uint>(new DotEqual(start, start + 2, trivias), 2),
                ( '.', '<', _ ) => new Tuple<Symbols, uint>(new DotLess(start, start + 2, trivias), 2),
                ( '.', '>', _ ) => new Tuple<Symbols, uint>(new DotGreater(start, start + 2, trivias), 2),
                ( '.', '*', _ ) => new Tuple<Symbols, uint>(new DotMul(start, start + 2, trivias), 2),
                ( '.', '/', _ ) => new Tuple<Symbols, uint>(new DotSlash(start, start + 2, trivias), 2),
                ( '.', '.', _ ) => new Tuple<Symbols, uint>(new UpTo(start, start + 2, trivias), 2),
                ( '.', _ , _ ) => new Tuple<Symbols, uint>(new Period(start, start + 1, trivias), 1),
                ( ':', '=', _ ) => new Tuple<Symbols, uint>(new Assign(start, start + 2, trivias), 2),
                ( ':', _ , _ ) => new Tuple<Symbols, uint>(new Colon(start, start + 1, trivias), 1),
                ( '>', '=', _ ) => new Tuple<Symbols, uint>(new GreaterEqual(start, start + 2, trivias), 2),
                ( '>', _, _ ) => new Tuple<Symbols, uint>(new Greater(start, start + 1, trivias), 1),
                ( '<', '=', _ ) => new Tuple<Symbols, uint>(new LessEqual(start, start + 2, trivias), 2),
                ( '<', _ , _ ) => new Tuple<Symbols, uint>(new Less(start, start + 1, trivias), 1),
                ( '+', '*', _ ) => new Tuple<Symbols, uint>(new PlusMul(start, start + 2, trivias), 2),
                ( '+', _ , _ ) => new Tuple<Symbols, uint>(new Plus(start, start + 1, trivias), 1),
                ( '*', '*', _ ) => new Tuple<Symbols, uint>(new Power(start, start + 2, trivias), 2),
                ( '*', _ , _ ) => new Tuple<Symbols, uint>(new Mul(start, start + 1, trivias), 1),
                ( '(', _ , _ ) => new Tuple<Symbols, uint>(new LeftParen(start, start + 1, trivias), 1),
                ( '[', _, _ ) => new Tuple<Symbols, uint>(new LeftBracket(start, start + 1, trivias), 1),
                ( '{', _, _ ) => new Tuple<Symbols, uint>(new LeftCurly(start, start + 1, trivias), 1),
                ( ')', _, _ ) => new Tuple<Symbols, uint>(new RightParen(start, start + 1, trivias), 1),
                ( ']', _, _ ) => new Tuple<Symbols, uint>(new RightBracket(start, start + 1, trivias), 1),
                ( '}', _, _ ) => new Tuple<Symbols, uint>(new RightCurly(start, start + 1, trivias), 1),
                ( '/', _, _ ) => new Tuple<Symbols, uint>(new Slash(start, start + 1, trivias), 1),
                ( '\\', _, _ ) => new Tuple<Symbols, uint>(new BackSlash(start, start + 1, trivias), 1),
                ( '´', _, _ ) => new Tuple<Symbols, uint>(new BackQuote(start, start + 1, trivias), 1),
                ( '-', _, _ ) => new Tuple<Symbols, uint>(new Minus(start, start + 1, trivias), 1),
                ( '?', _, _ ) => new Tuple<Symbols, uint>(new QuestionMark(start, start + 1, trivias), 1),
                ( '&', _, _ ) => new Tuple<Symbols, uint>(new And(start, start + 1, trivias), 1),
                ( '~', _, _ ) => new Tuple<Symbols, uint>(new Invert(start, start + 1, trivias), 1),
                ( '^', _, _ ) => new Tuple<Symbols, uint>(new Xor(start, start + 1, trivias), 1),
                ( '#', _, _ ) => new Tuple<Symbols, uint>(new NotEqual(start, start + 1, trivias), 1),
                ( '=', _, _ ) => new Tuple<Symbols, uint>(new Equal(start, start + 1, trivias), 1),
                ( ';', _, _) => new Tuple<Symbols, uint>(new SemiColon(start, start + 1, trivias), 1),
                ( ',', _, _) => new Tuple<Symbols, uint>(new Comma(start, start + 1, trivias), 1),
                _ => new Tuple<Symbols, uint>(new Empty(), 0)
            };

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
                "abs" or "ABS" => new Abs(start, end, trivias),
                "addressof" or "ADDRESSOF" => new AddressOf(start, end, trivias),
                "all" or "ALL" => new All(start, end, trivias),
                "any" or "ANY" => new Any(start, end, trivias),
                "ash" or "ASH" => new Ash(start, end, trivias),
                "assert" or "ASSERT" => new Assert(start, end, trivias),
                "boolean" or "BOOLEAN" => new Boolean(start, end, trivias),
                "cap" or "CAP" => new Cap(start, end, trivias),
                "cas" or "CAS" => new Cas(start, end, trivias),
                "char" or "CHAR" => new Char(start, end, trivias),
                "chr" or "CHR" => new Chr(start, end, trivias),
                "complex" or "COMPLEX" => new Complex(start, end, trivias),
                "complex32" or "COMPLEX32" => new Complex32(start, end, trivias),
                "complex64" or "COMPLEX64" => new Complex64(start, end, trivias),
                "copy" or "COPY" => new Copy(start, end, trivias),
                "dec" or "DEC" => new Dec(start, end, trivias),
                "decmul" or "DECMUL" => new DecMul(start, end, trivias),
                "dim" or "DIM" => new Dim(start, end, trivias),
                "entier" or "ENTIER" => new Entier(start, end, trivias),
                "entierh" or "ENTIERH" => new EntierH(start, end, trivias),
                "excl" or "EXCL" => new Excl(start, end, trivias),
                "first" or "FIRST" => new First(start, end, trivias),
                "float32" or "FLOAT32" => new Float32(start, end, trivias),
                "float64" or "FLOAT64" => new Float64(start, end, trivias),
                "floor" or "FLOOR" => new Floor(start, end, trivias),
                "halt" or "HALT" => new Halt(start, end, trivias),
                "im" or "IM" => new Im(start, end, trivias),
                "inc" or "INC" => new Inc(start, end, trivias),
                "incl" or "INCL" => new Incl(start, end, trivias),
                "incmul" or "INCMUL" => new IncMul(start, end, trivias),
                "incr" or "INCR" => new Incr(start, end, trivias),
                "integer" or "Integer" => new Integer(start, end, trivias),
                "integerset" or "INTEGERSET" => new IntegerSet(start, end, trivias),
                "last" or "LAST" => new Last(start, end, trivias),
                "len" or "LEN" => new Len(start, end, trivias),
                "long" or "LONG" => new Long(start, end, trivias),
                "longinteger" or "LONGINTEGER" => new LongInteger(start, end, trivias),
                "lsh" or "LSH" => new Lsh(start, end, trivias),
                "max" or "MAX" => new Max(start, end, trivias),
                "min" or "MIN" => new Min(start, end, trivias),
                "odd" or "ODD" => new Odd(start, end, trivias),
                "range" or "RANGE" => new Range(start, end, trivias),
                "re" or "RE" => new Re(start, end, trivias),
                "real" or "REAL" => new Real(start, end, trivias),
                "reshape" or "RESHAPE" => new Reshape(start, end, trivias),
                "rol" or "ROL" => new Rol(start, end, trivias),
                "ror" or "ROR" => new Ror(start, end, trivias),
                "rot" or "ROT" => new Rot(start, end, trivias),
                "set" or "SET" => new Set(start, end, trivias),
                "set8" or "SET8" => new Set8(start, end, trivias),
                "set16" or "SET16" => new Set16(start, end, trivias),
                "set32" or "SEt32" => new Set32(start, end, trivias),
                "set64" or "SET64" => new Set64(start, end, trivias),
                "shl" or "SHL" => new Shl(start, end, trivias),
                "short" or "SHORT" => new Short(start, end, trivias),
                "shr" or "SHR" => new Shr(start, end, trivias),
                "signed8" or "SIGNED8" => new Signed8(start, end, trivias),
                "signed16" or "SIGNED16" => new Signed16(start, end, trivias),
                "signed32" or "SIGNED32" => new Signed32(start, end, trivias),
                "signed64" or "SIGNED64" => new Signed64(start, end, trivias),
                "sizeof" or "SIZEOF" => new SizeOf(start, end, trivias),
                "step" or "STEP" => new Step(start, end, trivias),
                "sum" or "SUM" => new Sum(start, end, trivias),
                "unsigned8" or "INSIGNED8" => new Unsigned8(start, end, trivias),
                "unsigned16" or "INSIGNED16" => new Unsigned16(start, end, trivias),
                "unsigned32" or "INSIGNED32" => new Unsigned32(start, end, trivias),
                "unsigned64" or "INSIGNED64" => new Unsigned64(start, end, trivias),
                _ => new Ident(start, end, trivias, text)
            };

        private char GetChar() => _index < _source.Length ? _source[_index] : '\0';

        private (char, char, char) GetThreeChars() => 
            _index + 2 < _source.Length ? (_source[_index], _source[_index + 1], _source[_index + 2]) :
            _index + 1 < _source.Length ? (_source[_index], _source[_index + 1], '\0') :
            _index < _source.Length ? (_source[_index], '\0', '\0') : ('\0', '\0', '\0');

        private void NextChar(int steps = 1) => _index += steps;
        

        public void Advance(bool advance = true)
        {
            Position = (uint)_index;

            /* Handle reserved keyword or identifiers */
            if (char.IsLetter(GetChar()) || GetChar() == '_')
            {
                var builder = new StringBuilder();

                while (char.IsLetterOrDigit(GetChar()) || GetChar() == '_')
                {
                    builder.Append(GetChar());
                    NextChar();
                }

                Symbol = IsReservedKeyword(builder.ToString(), Position, (uint)_index, _trivias.ToArray());
                _trivias = new List<Trivia>();

                return;
            }

            /* Handle Operators or delimiters */
            var (c1, c2, c3) = GetThreeChars();
            var (symb, steps) = IsOperatorOrDelimiters(c1, c2, c3, Position, _trivias.ToArray());
            if (symb is not Empty)
            {
                Symbol = symb;
                NextChar((int)steps);
                _trivias = new List<Trivia>();

                return;
            }


            /* Check for end of file */
            if (GetChar() == '\0')
            {
                Symbol = new EndOfFile(Position, _trivias.ToArray());

                return;
            }

            throw new SyntaxError(Position, _moduleName, $"Illegal character '{GetChar()}'!");
        }

    }
}
