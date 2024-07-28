
using ActiveOberonNetCompiler.Parser;
using Assert = Xunit.Assert;

namespace TestActiveOberonNetCompiler.Parser
{
    public class TestScanner
    {
        [Fact]
        public void TestOperatorOrDelimiter_DotLessEqual()
        {
            var res = Scanner.IsOperatorOrDelimiters('.', '<', '=', 0, []);
            Assert.IsType<DotLessEqual>(res.Item1);
            Assert.Equal(new Tuple<Symbols, uint>(new DotLessEqual(0, 3, []), 3), res);
        }

        [Fact]
        public void TestOperatorOrDelimiter_DotGreaterEqual()
        {
            var res = Scanner.IsOperatorOrDelimiters('.', '>', '=', 0, []);
            Assert.IsType<DotGreaterEqual>(res.Item1);
            Assert.Equal(new Tuple<Symbols, uint>(new DotGreaterEqual(0, 3, []), 3), res);
        }

        [Fact]
        public void TestOperatorOrDelimiter_DotNotEqual()
        {
            var res = Scanner.IsOperatorOrDelimiters('.', '#', ' ' , 0, []);
            Assert.IsType<DotNotEqual>(res.Item1);
            Assert.Equal(new Tuple<Symbols, uint>(new DotNotEqual(0, 2, []), 2), res);
        }

        [Fact]
        public void TestOperatorOrDelimiter_DotEqual()
        {
            var res = Scanner.IsOperatorOrDelimiters('.', '=', ' ', 0, []);
            Assert.IsType<DotEqual>(res.Item1);
            Assert.Equal(new Tuple<Symbols, uint>(new DotEqual(0, 2, []), 2), res);
        }

        [Fact]
        public void TestOperatorOrDelimiter_DotLess()
        {
            var res = Scanner.IsOperatorOrDelimiters('.', '<', ' ', 0, []);
            Assert.IsType<DotLess>(res.Item1);
            Assert.Equal(new Tuple<Symbols, uint>(new DotLess(0, 2, []), 2), res);
        }

        [Fact]
        public void TestOperatorOrDelimiter_DotGreater()
        {
            var res = Scanner.IsOperatorOrDelimiters('.', '>', ' ', 0, []);
            Assert.IsType<DotGreater>(res.Item1);
            Assert.Equal(new Tuple<Symbols, uint>(new DotGreater(0, 2, []), 2), res);
        }

        [Fact]
        public void TestOperatorOrDelimiter_DotMul()
        {
            var res = Scanner.IsOperatorOrDelimiters('.', '*', ' ', 0, []);
            Assert.IsType<DotMul>(res.Item1);
            Assert.Equal(new Tuple<Symbols, uint>(new DotMul(0, 2, []), 2), res);
        }

        [Fact]
        public void TestOperatorOrDelimiter_DotSlash()
        {
            var res = Scanner.IsOperatorOrDelimiters('.', '/', ' ', 0, []);
            Assert.IsType<DotSlash>(res.Item1);
            Assert.Equal(new Tuple<Symbols, uint>(new DotSlash(0, 2, []), 2), res);
        }

        [Fact]
        public void TestOperatorOrDelimiter_Upto()
        {
            var res = Scanner.IsOperatorOrDelimiters('.', '.', ' ', 0, []);
            Assert.IsType<UpTo>(res.Item1);
            Assert.Equal(new Tuple<Symbols, uint>(new UpTo(0, 2, []), 2), res);
        }

        [Fact]
        public void TestOperatorOrDelimiter_Period()
        {
            var res = Scanner.IsOperatorOrDelimiters('.', ' ', ' ', 0, []);
            Assert.IsType<Period>(res.Item1);
            Assert.Equal(new Tuple<Symbols, uint>(new Period(0, 1, []), 1), res);
        }

        [Fact]
        public void TestOperatorOrDelimiter_Assign()
        {
            var res = Scanner.IsOperatorOrDelimiters(':', '=', ' ', 0, []);
            Assert.IsType<Assign>(res.Item1);
            Assert.Equal(new Tuple<Symbols, uint>(new Assign(0, 2, []), 2), res);
        }

        [Fact]
        public void TestOperatorOrDelimiter_Colon()
        {
            var res = Scanner.IsOperatorOrDelimiters(':', ' ', ' ', 0, []);
            Assert.IsType<Colon>(res.Item1);
            Assert.Equal(new Tuple<Symbols, uint>(new Colon(0, 1, []), 1), res);
        }

        [Fact]
        public void TestOperatorOrDelimiter_GreaterEqual()
        {
            var res = Scanner.IsOperatorOrDelimiters('>', '=', ' ', 0, []);
            Assert.IsType<GreaterEqual>(res.Item1);
            Assert.Equal(new Tuple<Symbols, uint>(new GreaterEqual(0, 2, []), 2), res);
        }

        [Fact]
        public void TestOperatorOrDelimiter_Greater()
        {
            var res = Scanner.IsOperatorOrDelimiters('>', ' ', ' ', 0, []);
            Assert.IsType<Greater>(res.Item1);
            Assert.Equal(new Tuple<Symbols, uint>(new Greater(0, 1, []), 1), res);
        }

        [Fact]
        public void TestOperatorOrDelimiter_LessEqual()
        {
            var res = Scanner.IsOperatorOrDelimiters('<', '=', ' ', 0, []);
            Assert.IsType<LessEqual>(res.Item1);
            Assert.Equal(new Tuple<Symbols, uint>(new LessEqual(0, 2, []), 2), res);
        }

        [Fact]
        public void TestOperatorOrDelimiter_Less()
        {
            var res = Scanner.IsOperatorOrDelimiters('<', ' ', ' ', 0, []);
            Assert.IsType<Less>(res.Item1);
            Assert.Equal(new Tuple<Symbols, uint>(new Less(0, 1, []), 1), res);
        }

        [Fact]
        public void TestOperatorOrDelimiter_PlusMul()
        {
            var res = Scanner.IsOperatorOrDelimiters('+', '*', ' ', 0, []);
            Assert.IsType<PlusMul>(res.Item1);
            Assert.Equal(new Tuple<Symbols, uint>(new PlusMul(0, 2, []), 2), res);
        }

        [Fact]
        public void TestOperatorOrDelimiter_Plus()
        {
            var res = Scanner.IsOperatorOrDelimiters('+', ' ', ' ', 0, []);
            Assert.IsType<Plus>(res.Item1);
            Assert.Equal(new Tuple<Symbols, uint>(new Plus(0, 1, []), 1), res);
        }

        [Fact]
        public void TestOperatorOrDelimiter_Power()
        {
            var res = Scanner.IsOperatorOrDelimiters('*', '*', ' ', 0, []);
            Assert.IsType<Power>(res.Item1);
            Assert.Equal(new Tuple<Symbols, uint>(new Power(0, 2, []), 2), res);
        }

        [Fact]
        public void TestOperatorOrDelimiter_Mul()
        {
            var res = Scanner.IsOperatorOrDelimiters('*', ' ', ' ', 0, []);
            Assert.IsType<Mul>(res.Item1);
            Assert.Equal(new Tuple<Symbols, uint>(new Mul(0, 1, []), 1), res);
        }

        [Fact]
        public void TestOperatorOrDelimiter_LeftParen()
        {
            var res = Scanner.IsOperatorOrDelimiters('(', ' ', ' ', 0, []);
            Assert.IsType<LeftParen>(res.Item1);
            Assert.Equal(new Tuple<Symbols, uint>(new LeftParen(0, 1, []), 1), res);
        }

        [Fact]
        public void TestOperatorOrDelimiter_RightParen()
        {
            var res = Scanner.IsOperatorOrDelimiters(')', ' ', ' ', 0, []);
            Assert.IsType<RightParen>(res.Item1);
            Assert.Equal(new Tuple<Symbols, uint>(new RightParen(0, 1, []), 1), res);
        }

        [Fact]
        public void TestOperatorOrDelimiter_LeftBracket()
        {
            var res = Scanner.IsOperatorOrDelimiters('[', ' ', ' ', 0, []);
            Assert.IsType<LeftBracket>(res.Item1);
            Assert.Equal(new Tuple<Symbols, uint>(new LeftBracket(0, 1, []), 1), res);
        }

        [Fact]
        public void TestOperatorOrDelimiter_RightBracket()
        {
            var res = Scanner.IsOperatorOrDelimiters(']', ' ', ' ', 0, []);
            Assert.IsType<RightBracket>(res.Item1);
            Assert.Equal(new Tuple<Symbols, uint>(new RightBracket(0, 1, []), 1), res);
        }

        [Fact]
        public void TestOperatorOrDelimiter_LeftCurly()
        {
            var res = Scanner.IsOperatorOrDelimiters('{', ' ', ' ', 0, []);
            Assert.IsType<LeftCurly>(res.Item1);
            Assert.Equal(new Tuple<Symbols, uint>(new LeftCurly(0, 1, []), 1), res);
        }

        [Fact]
        public void TestOperatorOrDelimiter_RightCurly()
        {
            var res = Scanner.IsOperatorOrDelimiters('}', ' ', ' ', 0, []);
            Assert.IsType<RightCurly>(res.Item1);
            Assert.Equal(new Tuple<Symbols, uint>(new RightCurly(0, 1, []), 1), res);
        }

        [Fact]
        public void TestOperatorOrDelimiter_Slash()
        {
            var res = Scanner.IsOperatorOrDelimiters('/', ' ', ' ', 0, []);
            Assert.IsType<Slash>(res.Item1);
            Assert.Equal(new Tuple<Symbols, uint>(new Slash(0, 1, []), 1), res);
        }

        [Fact]
        public void TestOperatorOrDelimiter_BackSlash()
        {
            var res = Scanner.IsOperatorOrDelimiters('\\', ' ', ' ', 0, []);
            Assert.IsType<BackSlash>(res.Item1);
            Assert.Equal(new Tuple<Symbols, uint>(new BackSlash(0, 1, []), 1), res);
        }

        [Fact]
        public void TestOperatorOrDelimiter_BackQuote()
        {
            var res = Scanner.IsOperatorOrDelimiters('´', ' ', ' ', 0, []);
            Assert.IsType<BackQuote>(res.Item1);
            Assert.Equal(new Tuple<Symbols, uint>(new BackQuote(0, 1, []), 1), res);
        }

        [Fact]
        public void TestOperatorOrDelimiter_Minus()
        {
            var res = Scanner.IsOperatorOrDelimiters('-', ' ', ' ', 0, []);
            Assert.IsType<Minus>(res.Item1);
            Assert.Equal(new Tuple<Symbols, uint>(new Minus(0, 1, []), 1), res);
        }

        [Fact]
        public void TestOperatorOrDelimiter_QuestionMark()
        {
            var res = Scanner.IsOperatorOrDelimiters('?', ' ', ' ', 0, []);
            Assert.IsType<QuestionMark>(res.Item1);
            Assert.Equal(new Tuple<Symbols, uint>(new QuestionMark(0, 1, []), 1), res);
        }

        [Fact]
        public void TestOperatorOrDelimiter_And()
        {
            var res = Scanner.IsOperatorOrDelimiters('&', ' ', ' ', 0, []);
            Assert.IsType<And>(res.Item1);
            Assert.Equal(new Tuple<Symbols, uint>(new And(0, 1, []), 1), res);
        }

        [Fact]
        public void TestOperatorOrDelimiter_Invert()
        {
            var res = Scanner.IsOperatorOrDelimiters('~', ' ', ' ', 0, []);
            Assert.IsType<Invert>(res.Item1);
            Assert.Equal(new Tuple<Symbols, uint>(new Invert(0, 1, []), 1), res);
        }

        [Fact]
        public void TestOperatorOrDelimiter_xor()
        {
            var res = Scanner.IsOperatorOrDelimiters('^', ' ', ' ', 0, []);
            Assert.IsType<Xor>(res.Item1);
            Assert.Equal(new Tuple<Symbols, uint>(new Xor(0, 1, []), 1), res);
        }

        [Fact]
        public void TestOperatorOrDelimiter_NotEqual()
        {
            var res = Scanner.IsOperatorOrDelimiters('#', ' ', ' ', 0, []);
            Assert.IsType<NotEqual>(res.Item1);
            Assert.Equal(new Tuple<Symbols, uint>(new NotEqual(0, 1, []), 1), res);
        }

        [Fact]
        public void TestOperatorOrDelimiter_Equal()
        {
            var res = Scanner.IsOperatorOrDelimiters('=', ' ', ' ', 0, []);
            Assert.IsType<Equal>(res.Item1);
            Assert.Equal(new Tuple<Symbols, uint>(new Equal(0, 1, []), 1), res);
        }

        [Fact]
        public void TestOperatorOrDelimiter_SemiColon()
        {
            var res = Scanner.IsOperatorOrDelimiters(';', ' ', ' ', 0, []);
            Assert.IsType<SemiColon>(res.Item1);
            Assert.Equal(new Tuple<Symbols, uint>(new SemiColon(0, 1, []), 1), res);
        }

        [Fact]
        public void TestOperatorOrDelimiter_Comma()
        {
            var res = Scanner.IsOperatorOrDelimiters(',', ' ', ' ', 0, []);
            Assert.IsType<Comma>(res.Item1);
            Assert.Equal(new Tuple<Symbols, uint>(new Comma(0, 1, []), 1), res);
        }

        [Fact]
        public void TestReservedKeyword_Address()
        {
            var lower = Scanner.IsReservedKeyword("address", 0, 7, []);
            Assert.IsType<Address>(lower);
            Assert.Equal(new Address(0, 7, []), lower);

            var higher = Scanner.IsReservedKeyword("ADDRESS", 0, 7, []);
            Assert.IsType<Address>(higher);
            Assert.Equal(new Address(0, 7, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_Alias()
        {
            var lower = Scanner.IsReservedKeyword("alias", 0, 5, []);
            Assert.IsType<Alias>(lower);
            Assert.Equal(new Alias(0, 5, []), lower);

            var higher = Scanner.IsReservedKeyword("ALIAS", 0, 5, []);
            Assert.IsType<Alias>(higher);
            Assert.Equal(new Alias(0, 5, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_Array()
        {
            var lower = Scanner.IsReservedKeyword("array", 0, 5, []);
            Assert.IsType<ActiveOberonNetCompiler.Parser.Array>(lower);
            Assert.Equal(new ActiveOberonNetCompiler.Parser.Array(0, 5, []), lower);

            var higher = Scanner.IsReservedKeyword("ARRAY", 0, 5, []);
            Assert.IsType<ActiveOberonNetCompiler.Parser.Array>(higher);
            Assert.Equal(new ActiveOberonNetCompiler.Parser.Array(0, 5, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_Await()
        {
            var lower = Scanner.IsReservedKeyword("await", 0, 5, []);
            Assert.IsType<Await>(lower);
            Assert.Equal(new Await(0, 5, []), lower);

            var higher = Scanner.IsReservedKeyword("AWAIT", 0, 5, []);
            Assert.IsType<Await>(higher);
            Assert.Equal(new Await(0, 5, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_Begin()
        {
            var lower = Scanner.IsReservedKeyword("begin", 0, 5, []);
            Assert.IsType<Begin>(lower);
            Assert.Equal(new Begin(0, 5, []), lower);

            var higher = Scanner.IsReservedKeyword("BEGIN", 0, 5, []);
            Assert.IsType<Begin>(higher);
            Assert.Equal(new Begin(0, 5, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_By()
        {
            var lower = Scanner.IsReservedKeyword("by", 0, 2, []);
            Assert.IsType<By>(lower);
            Assert.Equal(new By(0, 2, []), lower);

            var higher = Scanner.IsReservedKeyword("BY", 0, 2, []);
            Assert.IsType<By>(higher);
            Assert.Equal(new By(0, 2, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_Const()
        {
            var lower = Scanner.IsReservedKeyword("const", 0, 5, []);
            Assert.IsType<Const>(lower);
            Assert.Equal(new Const(0, 5, []), lower);

            var higher = Scanner.IsReservedKeyword("CONST", 0, 5, []);
            Assert.IsType<Const>(higher);
            Assert.Equal(new Const(0, 5, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_Case()
        {
            var lower = Scanner.IsReservedKeyword("case", 0, 4, []);
            Assert.IsType<Case>(lower);
            Assert.Equal(new Case(0, 4, []), lower);

            var higher = Scanner.IsReservedKeyword("CASE", 0, 4, []);
            Assert.IsType<Case>(higher);
            Assert.Equal(new Case(0, 4, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_Cell()
        {
            var lower = Scanner.IsReservedKeyword("cell", 0, 4, []);
            Assert.IsType<Cell>(lower);
            Assert.Equal(new Cell(0, 4, []), lower);

            var higher = Scanner.IsReservedKeyword("CELL", 0, 4, []);
            Assert.IsType<Cell>(higher);
            Assert.Equal(new Cell(0, 4, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_CellNet()
        {
            var lower = Scanner.IsReservedKeyword("cellnet", 0, 7, []);
            Assert.IsType<CellNet>(lower);
            Assert.Equal(new CellNet(0, 7, []), lower);

            var higher = Scanner.IsReservedKeyword("CELLNET", 0, 7, []);
            Assert.IsType<CellNet>(higher);
            Assert.Equal(new CellNet(0, 7, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_Code()
        {
            var lower = Scanner.IsReservedKeyword("code", 0, 4, []);
            Assert.IsType<Code>(lower);
            Assert.Equal(new Code(0, 4, []), lower);

            var higher = Scanner.IsReservedKeyword("CODE", 0, 4, []);
            Assert.IsType<Code>(higher);
            Assert.Equal(new Code(0, 4, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_Do()
        {
            var lower = Scanner.IsReservedKeyword("do", 0, 2, []);
            Assert.IsType<Do>(lower);
            Assert.Equal(new Do(0, 2, []), lower);

            var higher = Scanner.IsReservedKeyword("DO", 0, 2, []);
            Assert.IsType<Do>(higher);
            Assert.Equal(new Do(0, 2, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_Div()
        {
            var lower = Scanner.IsReservedKeyword("div", 0, 3, []);
            Assert.IsType<Div>(lower);
            Assert.Equal(new Div(0, 3, []), lower);

            var higher = Scanner.IsReservedKeyword("DIV", 0, 3, []);
            Assert.IsType<Div>(higher);
            Assert.Equal(new Div(0, 3, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_End()
        {
            var lower = Scanner.IsReservedKeyword("end", 0, 3, []);
            Assert.IsType<End>(lower);
            Assert.Equal(new End(0, 3, []), lower);

            var higher = Scanner.IsReservedKeyword("END", 0, 3, []);
            Assert.IsType<End>(higher);
            Assert.Equal(new End(0, 3, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_Enum()
        {
            var lower = Scanner.IsReservedKeyword("enum", 0, 4, []);
            Assert.IsType<ActiveOberonNetCompiler.Parser.Enum>(lower);
            Assert.Equal(new ActiveOberonNetCompiler.Parser.Enum(0, 4, []), lower);

            var higher = Scanner.IsReservedKeyword("ENUM", 0, 4, []);
            Assert.IsType<ActiveOberonNetCompiler.Parser.Enum>(higher);
            Assert.Equal(new ActiveOberonNetCompiler.Parser.Enum(0, 4, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_Else()
        {
            var lower = Scanner.IsReservedKeyword("else", 0, 4, []);
            Assert.IsType<Else>(lower);
            Assert.Equal(new Else(0, 4, []), lower);

            var higher = Scanner.IsReservedKeyword("ELSE", 0, 4, []);
            Assert.IsType<Else>(higher);
            Assert.Equal(new Else(0, 4, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_Elsif()
        {
            var lower = Scanner.IsReservedKeyword("elsif", 0, 5, []);
            Assert.IsType<Elsif>(lower);
            Assert.Equal(new Elsif(0, 5, []), lower);

            var higher = Scanner.IsReservedKeyword("ELSIF", 0, 5, []);
            Assert.IsType<Elsif>(higher);
            Assert.Equal(new Elsif(0, 5, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_exit()
        {
            var lower = Scanner.IsReservedKeyword("exit", 0, 4, []);
            Assert.IsType<Exit>(lower);
            Assert.Equal(new Exit(0, 4, []), lower);

            var higher = Scanner.IsReservedKeyword("EXIT", 0, 4, []);
            Assert.IsType<Exit>(higher);
            Assert.Equal(new Exit(0, 4, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_Extern()
        {
            var lower = Scanner.IsReservedKeyword("extern", 0, 6, []);
            Assert.IsType<Extern>(lower);
            Assert.Equal(new Extern(0, 6, []), lower);

            var higher = Scanner.IsReservedKeyword("EXTERN", 0, 6, []);
            Assert.IsType<Extern>(higher);
            Assert.Equal(new Extern(0, 6, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_False()
        {
            var lower = Scanner.IsReservedKeyword("false", 0, 5, []);
            Assert.IsType<False>(lower);
            Assert.Equal(new False(0, 5, []), lower);

            var higher = Scanner.IsReservedKeyword("FALSE", 0, 5, []);
            Assert.IsType<False>(higher);
            Assert.Equal(new False(0, 5, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_For()
        {
            var lower = Scanner.IsReservedKeyword("for", 0, 3, []);
            Assert.IsType<For>(lower);
            Assert.Equal(new For(0, 3, []), lower);

            var higher = Scanner.IsReservedKeyword("FOR", 0, 3, []);
            Assert.IsType<For>(higher);
            Assert.Equal(new For(0, 3, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_Finally()
        {
            var lower = Scanner.IsReservedKeyword("finally", 0, 7, []);
            Assert.IsType<Finally>(lower);
            Assert.Equal(new Finally(0, 7, []), lower);

            var higher = Scanner.IsReservedKeyword("FINALLY", 0, 7, []);
            Assert.IsType<Finally>(higher);
            Assert.Equal(new Finally(0, 7, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_If()
        {
            var lower = Scanner.IsReservedKeyword("if", 0, 2, []);
            Assert.IsType<If>(lower);
            Assert.Equal(new If(0, 2, []), lower);

            var higher = Scanner.IsReservedKeyword("IF", 0, 2, []);
            Assert.IsType<If>(higher);
            Assert.Equal(new If(0, 2, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_Ignore()
        {
            var lower = Scanner.IsReservedKeyword("ignore", 0, 6, []);
            Assert.IsType<Ignore>(lower);
            Assert.Equal(new Ignore(0, 6, []), lower);

            var higher = Scanner.IsReservedKeyword("IGNORE", 0, 6, []);
            Assert.IsType<Ignore>(higher);
            Assert.Equal(new Ignore(0, 6, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_Imag()
        {
            var lower = Scanner.IsReservedKeyword("imag", 0, 4, []);
            Assert.IsType<Imag>(lower);
            Assert.Equal(new Imag(0, 4, []), lower);

            var higher = Scanner.IsReservedKeyword("IMAG", 0, 4, []);
            Assert.IsType<Imag>(higher);
            Assert.Equal(new Imag(0, 4, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_In()
        {
            var lower = Scanner.IsReservedKeyword("in", 0, 2, []);
            Assert.IsType<In>(lower);
            Assert.Equal(new In(0, 2, []), lower);

            var higher = Scanner.IsReservedKeyword("IN", 0, 2, []);
            Assert.IsType<In>(higher);
            Assert.Equal(new In(0, 2, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_Is()
        {
            var lower = Scanner.IsReservedKeyword("is", 0, 2, []);
            Assert.IsType<Is>(lower);
            Assert.Equal(new Is(0, 2, []), lower);

            var higher = Scanner.IsReservedKeyword("IS", 0, 2, []);
            Assert.IsType<Is>(higher);
            Assert.Equal(new Is(0, 2, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_Import()
        {
            var lower = Scanner.IsReservedKeyword("import", 0, 6, []);
            Assert.IsType<Import>(lower);
            Assert.Equal(new Import(0, 6, []), lower);

            var higher = Scanner.IsReservedKeyword("IMPORT", 0, 6, []);
            Assert.IsType<Import>(higher);
            Assert.Equal(new Import(0, 6, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_Loop()
        {
            var lower = Scanner.IsReservedKeyword("loop", 0, 4, []);
            Assert.IsType<Loop>(lower);
            Assert.Equal(new Loop(0, 4, []), lower);

            var higher = Scanner.IsReservedKeyword("LOOP", 0, 4, []);
            Assert.IsType<Loop>(higher);
            Assert.Equal(new Loop(0, 4, []), higher);
        }




        [Fact]
        public void TestScannerReservedKeyword()
        {
            var scanner = new Scanner("VAR");
            scanner.Advance();
            Assert.IsType<Var>(scanner.Symbol);
            Assert.Equal(0u, scanner.Position);
        }

        [Fact]
        public void TestScannerIdent()
        {
            var scanner = new Scanner("__Test3__");
            scanner.Advance();
            Assert.IsType<Ident>(scanner.Symbol);
            Assert.Equal(0u, scanner.Position);

            Assert.Equal(0u, scanner.Position);
            Assert.Equal(0u, scanner.Symbol.StartPos);
            Assert.Equal(9u, scanner.Symbol.EndPos);
            Assert.Equal([], scanner.Symbol.Trivias);

            var res = scanner.Symbol as Ident;
            Assert.Equal("__Test3__", res?.text);
        }

        [Fact]
        public void TestScannerOperator()
        {
            var scanner = new Scanner(".<=");
            scanner.Advance();
            Assert.IsType<DotLessEqual>(scanner.Symbol);
            Assert.Equal(0u, scanner.Position);
            Assert.Equal(0u, scanner.Symbol.StartPos);
            Assert.Equal(3u, scanner.Symbol.EndPos);
            Assert.Equal([], scanner.Symbol.Trivias);
        }

        [Fact]
        public void TestEndOfFile()
        {
            var scanner = new Scanner("");
            scanner.Advance();
            Assert.IsType<EndOfFile>(scanner.Symbol);
            Assert.Equal(0u, scanner.Position);
        }

        [Fact]
        public void TestKeywordWithWhitespace()
        {
            var scanner = new Scanner("     Test");
            scanner.Advance();
            Assert.IsType<Ident>(scanner.Symbol);
            Assert.Equal(5u, scanner.Position);

            var trivias = scanner.Symbol.Trivias;
            Assert.Equal([ new WhiteSpaceTrivia(0, 5) ], trivias);
        }

        [Fact]
        public void TestKeywordWithComment()
        {
            var scanner = new Scanner("(* This is (* a test *) in Active Oberon *)Test");
            scanner.Advance();
            Assert.IsType<Ident>(scanner.Symbol);
            Assert.Equal(43u, scanner.Position);

            var trivias = scanner.Symbol.Trivias;
            Assert.Equal([new CommentTrivia(0, 43, "(* This is (* a test *) in Active Oberon *)")], trivias);
        }
    }
}
