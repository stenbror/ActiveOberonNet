
using ActiveOberonNetCompiler.Parser;
using Assert = Xunit.Assert;
using Record = ActiveOberonNetCompiler.Parser.Record;

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
        public void TestReservedKeyword_Module()
        {
            var lower = Scanner.IsReservedKeyword("module", 0, 6, []);
            Assert.IsType<Module>(lower);
            Assert.Equal(new Module(0, 6, []), lower);

            var higher = Scanner.IsReservedKeyword("MODULE", 0, 6, []);
            Assert.IsType<Module>(higher);
            Assert.Equal(new Module(0, 6, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_Mod()
        {
            var lower = Scanner.IsReservedKeyword("mod", 0, 3, []);
            Assert.IsType<Mod>(lower);
            Assert.Equal(new Mod(0, 3, []), lower);

            var higher = Scanner.IsReservedKeyword("MOD", 0, 3, []);
            Assert.IsType<Mod>(higher);
            Assert.Equal(new Mod(0, 3, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_Nil()
        {
            var lower = Scanner.IsReservedKeyword("nil", 0, 3, []);
            Assert.IsType<Nil>(lower);
            Assert.Equal(new Nil(0, 3, []), lower);

            var higher = Scanner.IsReservedKeyword("NIL", 0, 3, []);
            Assert.IsType<Nil>(higher);
            Assert.Equal(new Nil(0, 3, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_Object()
        {
            var lower = Scanner.IsReservedKeyword("object", 0, 6, []);
            Assert.IsType<ActiveOberonNetCompiler.Parser.Object>(lower);
            Assert.Equal(new ActiveOberonNetCompiler.Parser.Object(0, 6, []), lower);

            var higher = Scanner.IsReservedKeyword("OBJECT", 0, 6, []);
            Assert.IsType<ActiveOberonNetCompiler.Parser.Object>(higher);
            Assert.Equal(new ActiveOberonNetCompiler.Parser.Object(0, 6, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_Of()
        {
            var lower = Scanner.IsReservedKeyword("of", 0, 2, []);
            Assert.IsType<Of>(lower);
            Assert.Equal(new Of(0, 2, []), lower);

            var higher = Scanner.IsReservedKeyword("OF", 0, 2, []);
            Assert.IsType<Of>(higher);
            Assert.Equal(new Of(0, 2, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_Or()
        {
            var lower = Scanner.IsReservedKeyword("or", 0, 2, []);
            Assert.IsType<Or>(lower);
            Assert.Equal(new Or(0, 2, []), lower);

            var higher = Scanner.IsReservedKeyword("OR", 0, 2, []);
            Assert.IsType<Or>(higher);
            Assert.Equal(new Or(0, 2, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_Out()
        {
            var lower = Scanner.IsReservedKeyword("out", 0, 3, []);
            Assert.IsType<Out>(lower);
            Assert.Equal(new Out(0, 3, []), lower);

            var higher = Scanner.IsReservedKeyword("OUT", 0, 3, []);
            Assert.IsType<Out>(higher);
            Assert.Equal(new Out(0, 3, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_Operator()
        {
            var lower = Scanner.IsReservedKeyword("operator", 0, 8, []);
            Assert.IsType<Operator>(lower);
            Assert.Equal(new Operator(0, 8, []), lower);

            var higher = Scanner.IsReservedKeyword("OPERATOR", 0, 8, []);
            Assert.IsType<Operator>(higher);
            Assert.Equal(new Operator(0, 8, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_Pointer()
        {
            var lower = Scanner.IsReservedKeyword("pointer", 0, 7, []);
            Assert.IsType<Pointer>(lower);
            Assert.Equal(new Pointer(0, 7, []), lower);

            var higher = Scanner.IsReservedKeyword("POINTER", 0, 7, []);
            Assert.IsType<Pointer>(higher);
            Assert.Equal(new Pointer(0, 7, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_Procedure()
        {
            var lower = Scanner.IsReservedKeyword("procedure", 0, 9, []);
            Assert.IsType<Procedure>(lower);
            Assert.Equal(new Procedure(0, 9, []), lower);

            var higher = Scanner.IsReservedKeyword("PROCEDURE", 0, 9, []);
            Assert.IsType<Procedure>(higher);
            Assert.Equal(new Procedure(0, 9, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_Port()
        {
            var lower = Scanner.IsReservedKeyword("port", 0, 4, []);
            Assert.IsType<Port>(lower);
            Assert.Equal(new Port(0, 4, []), lower);

            var higher = Scanner.IsReservedKeyword("PORT", 0, 4, []);
            Assert.IsType<Port>(higher);
            Assert.Equal(new Port(0, 4, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_Repeat()
        {
            var lower = Scanner.IsReservedKeyword("repeat", 0, 6, []);
            Assert.IsType<Repeat>(lower);
            Assert.Equal(new Repeat(0, 6, []), lower);

            var higher = Scanner.IsReservedKeyword("REPEAT", 0, 6, []);
            Assert.IsType<Repeat>(higher);
            Assert.Equal(new Repeat(0, 6, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_Return()
        {
            var lower = Scanner.IsReservedKeyword("return", 0, 6, []);
            Assert.IsType<Return>(lower);
            Assert.Equal(new Return(0, 6, []), lower);

            var higher = Scanner.IsReservedKeyword("RETURN", 0, 6, []);
            Assert.IsType<Return>(higher);
            Assert.Equal(new Return(0, 6, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_Self()
        {
            var lower = Scanner.IsReservedKeyword("self", 0, 4, []);
            Assert.IsType<Self>(lower);
            Assert.Equal(new Self(0, 4, []), lower);

            var higher = Scanner.IsReservedKeyword("SELF", 0, 4, []);
            Assert.IsType<Self>(higher);
            Assert.Equal(new Self(0, 4, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_New()
        {
            var lower = Scanner.IsReservedKeyword("new", 0, 3, []);
            Assert.IsType<New>(lower);
            Assert.Equal(new New(0, 3, []), lower);

            var higher = Scanner.IsReservedKeyword("NEW", 0, 3, []);
            Assert.IsType<New>(higher);
            Assert.Equal(new New(0, 3, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_Record()
        {
            var lower = Scanner.IsReservedKeyword("record", 0, 6, []);
            Assert.IsType<Record>(lower);
            Assert.Equal(new Record(0, 6, []), lower);

            var higher = Scanner.IsReservedKeyword("RECORD", 0, 6, []);
            Assert.IsType<Record>(higher);
            Assert.Equal(new Record(0, 6, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_Result()
        {
            var lower = Scanner.IsReservedKeyword("result", 0, 6, []);
            Assert.IsType<Result>(lower);
            Assert.Equal(new Result(0, 6, []), lower);

            var higher = Scanner.IsReservedKeyword("RESULT", 0, 6, []);
            Assert.IsType<Result>(higher);
            Assert.Equal(new Result(0, 6, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_Size()
        {
            var lower = Scanner.IsReservedKeyword("size", 0, 4, []);
            Assert.IsType<Size>(lower);
            Assert.Equal(new Size(0, 4, []), lower);

            var higher = Scanner.IsReservedKeyword("SIZE", 0, 4, []);
            Assert.IsType<Size>(higher);
            Assert.Equal(new Size(0, 4, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_Then()
        {
            var lower = Scanner.IsReservedKeyword("then", 0, 4, []);
            Assert.IsType<Then>(lower);
            Assert.Equal(new Then(0, 4, []), lower);

            var higher = Scanner.IsReservedKeyword("THEN", 0, 4, []);
            Assert.IsType<Then>(higher);
            Assert.Equal(new Then(0, 4, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_True()
        {
            var lower = Scanner.IsReservedKeyword("true", 0, 4, []);
            Assert.IsType<True>(lower);
            Assert.Equal(new True(0, 4, []), lower);

            var higher = Scanner.IsReservedKeyword("TRUE", 0, 4, []);
            Assert.IsType<True>(higher);
            Assert.Equal(new True(0, 4, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_To()
        {
            var lower = Scanner.IsReservedKeyword("to", 0, 2, []);
            Assert.IsType<To>(lower);
            Assert.Equal(new To(0, 2, []), lower);

            var higher = Scanner.IsReservedKeyword("TO", 0, 2, []);
            Assert.IsType<To>(higher);
            Assert.Equal(new To(0, 2, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_Type()
        {
            var lower = Scanner.IsReservedKeyword("type", 0, 4, []);
            Assert.IsType<ActiveOberonNetCompiler.Parser.Type>(lower);
            Assert.Equal(new ActiveOberonNetCompiler.Parser.Type(0, 4, []), lower);

            var higher = Scanner.IsReservedKeyword("TYPE", 0, 4, []);
            Assert.IsType<ActiveOberonNetCompiler.Parser.Type>(higher);
            Assert.Equal(new ActiveOberonNetCompiler.Parser.Type(0, 4, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_Until()
        {
            var lower = Scanner.IsReservedKeyword("until", 0, 5, []);
            Assert.IsType<Until>(lower);
            Assert.Equal(new Until(0, 5, []), lower);

            var higher = Scanner.IsReservedKeyword("UNTIL", 0, 5, []);
            Assert.IsType<Until>(higher);
            Assert.Equal(new Until(0, 5, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_Var()
        {
            var lower = Scanner.IsReservedKeyword("var", 0, 3, []);
            Assert.IsType<Var>(lower);
            Assert.Equal(new Var(0, 3, []), lower);

            var higher = Scanner.IsReservedKeyword("VAR", 0, 3, []);
            Assert.IsType<Var>(higher);
            Assert.Equal(new Var(0, 3, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_While()
        {
            var lower = Scanner.IsReservedKeyword("while", 0, 5, []);
            Assert.IsType<While>(lower);
            Assert.Equal(new While(0, 5, []), lower);

            var higher = Scanner.IsReservedKeyword("WHILE", 0, 5, []);
            Assert.IsType<While>(higher);
            Assert.Equal(new While(0, 5, []), higher);
        }

        [Fact]
        public void TestReservedKeyword_With()
        {
            var lower = Scanner.IsReservedKeyword("with", 0, 4, []);
            Assert.IsType<With>(lower);
            Assert.Equal(new With(0, 4, []), lower);

            var higher = Scanner.IsReservedKeyword("WITH", 0, 4, []);
            Assert.IsType<With>(higher);
            Assert.Equal(new With(0, 4, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Abs()
        {
            var lower = Scanner.IsReservedKeyword("abs", 0, 3, []);
            Assert.IsType<Abs>(lower);
            Assert.Equal(new Abs(0, 3, []), lower);

            var higher = Scanner.IsReservedKeyword("ABS", 0, 3, []);
            Assert.IsType<Abs>(higher);
            Assert.Equal(new Abs(0, 3, []), higher);
        }

        [Fact]
        public void TestReservedMethods_AddressOf()
        {
            var lower = Scanner.IsReservedKeyword("addressof", 0, 9, []);
            Assert.IsType<AddressOf>(lower);
            Assert.Equal(new AddressOf(0, 9, []), lower);

            var higher = Scanner.IsReservedKeyword("ADDRESSOF", 0, 9, []);
            Assert.IsType<AddressOf>(higher);
            Assert.Equal(new AddressOf(0, 9, []), higher);
        }

        [Fact]
        public void TestReservedMethods_All()
        {
            var lower = Scanner.IsReservedKeyword("all", 0, 3, []);
            Assert.IsType<All>(lower);
            Assert.Equal(new All(0, 3, []), lower);

            var higher = Scanner.IsReservedKeyword("ALL", 0, 3, []);
            Assert.IsType<All>(higher);
            Assert.Equal(new All(0, 3, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Any()
        {
            var lower = Scanner.IsReservedKeyword("any", 0, 3, []);
            Assert.IsType<Any>(lower);
            Assert.Equal(new Any(0, 3, []), lower);

            var higher = Scanner.IsReservedKeyword("ANY", 0, 3, []);
            Assert.IsType<Any>(higher);
            Assert.Equal(new Any(0, 3, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Ash()
        {
            var lower = Scanner.IsReservedKeyword("ash", 0, 3, []);
            Assert.IsType<Ash>(lower);
            Assert.Equal(new Ash(0, 3, []), lower);

            var higher = Scanner.IsReservedKeyword("ASH", 0, 3, []);
            Assert.IsType<Ash>(higher);
            Assert.Equal(new Ash(0, 3, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Assert()
        {
            var lower = Scanner.IsReservedKeyword("assert", 0, 6, []);
            Assert.IsType<ActiveOberonNetCompiler.Parser.Assert>(lower);
            Assert.Equal(new ActiveOberonNetCompiler.Parser.Assert(0, 6, []), lower);

            var higher = Scanner.IsReservedKeyword("ASSERT", 0, 6, []);
            Assert.IsType<ActiveOberonNetCompiler.Parser.Assert>(higher);
            Assert.Equal(new ActiveOberonNetCompiler.Parser.Assert(0, 6, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Boolean()
        {
            var lower = Scanner.IsReservedKeyword("boolean", 0, 7, []);
            Assert.IsType<ActiveOberonNetCompiler.Parser.Boolean>(lower);
            Assert.Equal(new ActiveOberonNetCompiler.Parser.Boolean(0, 7, []), lower);

            var higher = Scanner.IsReservedKeyword("BOOLEAN", 0, 7, []);
            Assert.IsType<ActiveOberonNetCompiler.Parser.Boolean>(higher);
            Assert.Equal(new ActiveOberonNetCompiler.Parser.Boolean(0, 7, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Cap()
        {
            var lower = Scanner.IsReservedKeyword("cap", 0, 3, []);
            Assert.IsType<Cap>(lower);
            Assert.Equal(new Cap(0, 3, []), lower);

            var higher = Scanner.IsReservedKeyword("CAP", 0, 3, []);
            Assert.IsType<Cap>(higher);
            Assert.Equal(new Cap(0, 3, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Cas()
        {
            var lower = Scanner.IsReservedKeyword("cas", 0, 3, []);
            Assert.IsType<Cas>(lower);
            Assert.Equal(new Cas(0, 3, []), lower);

            var higher = Scanner.IsReservedKeyword("CAS", 0, 3, []);
            Assert.IsType<Cas>(higher);
            Assert.Equal(new Cas(0, 3, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Char()
        {
            var lower = Scanner.IsReservedKeyword("char", 0, 4, []);
            Assert.IsType<ActiveOberonNetCompiler.Parser.Char>(lower);
            Assert.Equal(new ActiveOberonNetCompiler.Parser.Char(0, 4, []), lower);

            var higher = Scanner.IsReservedKeyword("CHAR", 0, 4, []);
            Assert.IsType<ActiveOberonNetCompiler.Parser.Char>(higher);
            Assert.Equal(new ActiveOberonNetCompiler.Parser.Char(0, 4, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Complex()
        {
            var lower = Scanner.IsReservedKeyword("complex", 0, 7, []);
            Assert.IsType<Complex>(lower);
            Assert.Equal(new Complex(0, 7, []), lower);

            var higher = Scanner.IsReservedKeyword("COMPLEX", 0, 7, []);
            Assert.IsType<Complex>(higher);
            Assert.Equal(new Complex(0, 7, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Complex32()
        {
            var lower = Scanner.IsReservedKeyword("complex32", 0, 9, []);
            Assert.IsType<Complex32>(lower);
            Assert.Equal(new Complex32(0, 9, []), lower);

            var higher = Scanner.IsReservedKeyword("COMPLEX32", 0, 9, []);
            Assert.IsType<Complex32>(higher);
            Assert.Equal(new Complex32(0, 9, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Complex64()
        {
            var lower = Scanner.IsReservedKeyword("complex64", 0, 9, []);
            Assert.IsType<Complex64>(lower);
            Assert.Equal(new Complex64(0, 9, []), lower);

            var higher = Scanner.IsReservedKeyword("COMPLEX64", 0, 9, []);
            Assert.IsType<Complex64>(higher);
            Assert.Equal(new Complex64(0, 9, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Copy()
        {
            var lower = Scanner.IsReservedKeyword("copy", 0, 4, []);
            Assert.IsType<Copy>(lower);
            Assert.Equal(new Copy(0, 4, []), lower);

            var higher = Scanner.IsReservedKeyword("COPY", 0, 4, []);
            Assert.IsType<Copy>(higher);
            Assert.Equal(new Copy(0, 4, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Dec()
        {
            var lower = Scanner.IsReservedKeyword("dec", 0, 3, []);
            Assert.IsType<Dec>(lower);
            Assert.Equal(new Dec(0, 3, []), lower);

            var higher = Scanner.IsReservedKeyword("DEC", 0, 3, []);
            Assert.IsType<Dec>(higher);
            Assert.Equal(new Dec(0, 3, []), higher);
        }

        [Fact]
        public void TestReservedMethods_DecMul()
        {
            var lower = Scanner.IsReservedKeyword("decmul", 0, 6, []);
            Assert.IsType<DecMul>(lower);
            Assert.Equal(new DecMul(0, 6, []), lower);

            var higher = Scanner.IsReservedKeyword("DECMUL", 0, 6, []);
            Assert.IsType<DecMul>(higher);
            Assert.Equal(new DecMul(0, 6, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Dim()
        {
            var lower = Scanner.IsReservedKeyword("dim", 0, 3, []);
            Assert.IsType<Dim>(lower);
            Assert.Equal(new Dim(0, 3, []), lower);

            var higher = Scanner.IsReservedKeyword("DIM", 0, 3, []);
            Assert.IsType<Dim>(higher);
            Assert.Equal(new Dim(0, 3, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Entier()
        {
            var lower = Scanner.IsReservedKeyword("entier", 0, 6, []);
            Assert.IsType<Entier>(lower);
            Assert.Equal(new Entier(0, 6, []), lower);

            var higher = Scanner.IsReservedKeyword("ENTIER", 0, 6, []);
            Assert.IsType<Entier>(higher);
            Assert.Equal(new Entier(0, 6, []), higher);
        }

        [Fact]
        public void TestReservedMethods_EntierH()
        {
            var lower = Scanner.IsReservedKeyword("entierh", 0, 7, []);
            Assert.IsType<EntierH>(lower);
            Assert.Equal(new EntierH(0, 7, []), lower);

            var higher = Scanner.IsReservedKeyword("ENTIERH", 0, 7, []);
            Assert.IsType<EntierH>(higher);
            Assert.Equal(new EntierH(0, 7, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Excl()
        {
            var lower = Scanner.IsReservedKeyword("excl", 0, 4, []);
            Assert.IsType<Excl>(lower);
            Assert.Equal(new Excl(0, 4, []), lower);

            var higher = Scanner.IsReservedKeyword("EXCL", 0, 4, []);
            Assert.IsType<Excl>(higher);
            Assert.Equal(new Excl(0, 4, []), higher);
        }

        [Fact]
        public void TestReservedMethods_First()
        {
            var lower = Scanner.IsReservedKeyword("first", 0, 5, []);
            Assert.IsType<First>(lower);
            Assert.Equal(new First(0, 5, []), lower);

            var higher = Scanner.IsReservedKeyword("FIRST", 0, 5, []);
            Assert.IsType<First>(higher);
            Assert.Equal(new First(0, 5, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Float32()
        {
            var lower = Scanner.IsReservedKeyword("float32", 0, 7, []);
            Assert.IsType<Float32>(lower);
            Assert.Equal(new Float32(0, 7, []), lower);

            var higher = Scanner.IsReservedKeyword("FLOAT32", 0, 7, []);
            Assert.IsType<Float32>(higher);
            Assert.Equal(new Float32(0, 7, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Float64()
        {
            var lower = Scanner.IsReservedKeyword("float64", 0, 7, []);
            Assert.IsType<Float64>(lower);
            Assert.Equal(new Float64(0, 7, []), lower);

            var higher = Scanner.IsReservedKeyword("FLOAT64", 0, 7, []);
            Assert.IsType<Float64>(higher);
            Assert.Equal(new Float64(0, 7, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Floor()
        {
            var lower = Scanner.IsReservedKeyword("floor", 0, 5, []);
            Assert.IsType<Floor>(lower);
            Assert.Equal(new Floor(0, 5, []), lower);

            var higher = Scanner.IsReservedKeyword("FLOOR", 0, 5, []);
            Assert.IsType<Floor>(higher);
            Assert.Equal(new Floor(0, 5, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Halt()
        {
            var lower = Scanner.IsReservedKeyword("halt", 0, 4, []);
            Assert.IsType<Halt>(lower);
            Assert.Equal(new Halt(0, 4, []), lower);

            var higher = Scanner.IsReservedKeyword("HALT", 0, 4, []);
            Assert.IsType<Halt>(higher);
            Assert.Equal(new Halt(0, 4, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Im()
        {
            var lower = Scanner.IsReservedKeyword("im", 0, 2, []);
            Assert.IsType<Im>(lower);
            Assert.Equal(new Im(0, 2, []), lower);

            var higher = Scanner.IsReservedKeyword("IM", 0, 2, []);
            Assert.IsType<Im>(higher);
            Assert.Equal(new Im(0, 2, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Inc()
        {
            var lower = Scanner.IsReservedKeyword("inc", 0, 3, []);
            Assert.IsType<Inc>(lower);
            Assert.Equal(new Inc(0, 3, []), lower);

            var higher = Scanner.IsReservedKeyword("INC", 0, 3, []);
            Assert.IsType<Inc>(higher);
            Assert.Equal(new Inc(0, 3, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Incl()
        {
            var lower = Scanner.IsReservedKeyword("incl", 0, 4, []);
            Assert.IsType<Incl>(lower);
            Assert.Equal(new Incl(0, 4, []), lower);

            var higher = Scanner.IsReservedKeyword("INCL", 0, 4, []);
            Assert.IsType<Incl>(higher);
            Assert.Equal(new Incl(0, 4, []), higher);
        }

        [Fact]
        public void TestReservedMethods_IncMul()
        {
            var lower = Scanner.IsReservedKeyword("incmul", 0, 6, []);
            Assert.IsType<IncMul>(lower);
            Assert.Equal(new IncMul(0, 6, []), lower);

            var higher = Scanner.IsReservedKeyword("INCMUL", 0, 6, []);
            Assert.IsType<IncMul>(higher);
            Assert.Equal(new IncMul(0, 6, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Incr()
        {
            var lower = Scanner.IsReservedKeyword("incr", 0, 4, []);
            Assert.IsType<Incr>(lower);
            Assert.Equal(new Incr(0, 4, []), lower);

            var higher = Scanner.IsReservedKeyword("INCR", 0, 4, []);
            Assert.IsType<Incr>(higher);
            Assert.Equal(new Incr(0, 4, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Integer()
        {
            var lower = Scanner.IsReservedKeyword("integer", 0, 7, []);
            Assert.IsType<Integer>(lower);
            Assert.Equal(new Integer(0, 7, []), lower);

            var higher = Scanner.IsReservedKeyword("INTEGER", 0, 7, []);
            Assert.IsType<Integer>(higher);
            Assert.Equal(new Integer(0, 7, []), higher);
        }

        [Fact]
        public void TestReservedMethods_IntegerSet()
        {
            var lower = Scanner.IsReservedKeyword("integerset", 0, 11, []);
            Assert.IsType<IntegerSet>(lower);
            Assert.Equal(new IntegerSet(0, 11, []), lower);

            var higher = Scanner.IsReservedKeyword("INTEGERSET", 0, 11, []);
            Assert.IsType<IntegerSet>(higher);
            Assert.Equal(new IntegerSet(0, 11, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Last()
        {
            var lower = Scanner.IsReservedKeyword("last", 0, 4, []);
            Assert.IsType<Last>(lower);
            Assert.Equal(new Last(0, 4, []), lower);

            var higher = Scanner.IsReservedKeyword("LAST", 0, 4, []);
            Assert.IsType<Last>(higher);
            Assert.Equal(new Last(0, 4, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Len()
        {
            var lower = Scanner.IsReservedKeyword("len", 0, 3, []);
            Assert.IsType<Len>(lower);
            Assert.Equal(new Len(0, 3, []), lower);

            var higher = Scanner.IsReservedKeyword("LEN", 0, 3, []);
            Assert.IsType<Len>(higher);
            Assert.Equal(new Len(0, 3, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Long()
        {
            var lower = Scanner.IsReservedKeyword("long", 0, 4, []);
            Assert.IsType<Long>(lower);
            Assert.Equal(new Long(0, 4, []), lower);

            var higher = Scanner.IsReservedKeyword("LONG", 0, 4, []);
            Assert.IsType<Long>(higher);
            Assert.Equal(new Long(0, 4, []), higher);
        }

        [Fact]
        public void TestReservedMethods_LongInteger()
        {
            var lower = Scanner.IsReservedKeyword("longinteger", 0, 11, []);
            Assert.IsType<LongInteger>(lower);
            Assert.Equal(new LongInteger(0, 11, []), lower);

            var higher = Scanner.IsReservedKeyword("LONGINTEGER", 0, 11, []);
            Assert.IsType<LongInteger>(higher);
            Assert.Equal(new LongInteger(0, 11, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Lsh()
        {
            var lower = Scanner.IsReservedKeyword("lsh", 0, 3, []);
            Assert.IsType<Lsh>(lower);
            Assert.Equal(new Lsh(0, 3, []), lower);

            var higher = Scanner.IsReservedKeyword("LSH", 0, 3, []);
            Assert.IsType<Lsh>(higher);
            Assert.Equal(new Lsh(0, 3, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Max()
        {
            var lower = Scanner.IsReservedKeyword("max", 0, 3, []);
            Assert.IsType<Max>(lower);
            Assert.Equal(new Max(0, 3, []), lower);

            var higher = Scanner.IsReservedKeyword("MAX", 0, 3, []);
            Assert.IsType<Max>(higher);
            Assert.Equal(new Max(0, 3, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Min()
        {
            var lower = Scanner.IsReservedKeyword("min", 0, 3, []);
            Assert.IsType<Min>(lower);
            Assert.Equal(new Min(0, 3, []), lower);

            var higher = Scanner.IsReservedKeyword("MIN", 0, 3, []);
            Assert.IsType<Min>(higher);
            Assert.Equal(new Min(0, 3, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Odd()
        {
            var lower = Scanner.IsReservedKeyword("odd", 0, 3, []);
            Assert.IsType<Odd>(lower);
            Assert.Equal(new Odd(0, 3, []), lower);

            var higher = Scanner.IsReservedKeyword("ODD", 0, 3, []);
            Assert.IsType<Odd>(higher);
            Assert.Equal(new Odd(0, 3, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Range()
        {
            var lower = Scanner.IsReservedKeyword("range", 0, 5, []);
            Assert.IsType<ActiveOberonNetCompiler.Parser.Range>(lower);
            Assert.Equal(new ActiveOberonNetCompiler.Parser.Range(0, 5, []), lower);

            var higher = Scanner.IsReservedKeyword("RANGE", 0, 5, []);
            Assert.IsType<ActiveOberonNetCompiler.Parser.Range>(higher);
            Assert.Equal(new ActiveOberonNetCompiler.Parser.Range(0, 5, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Re()
        {
            var lower = Scanner.IsReservedKeyword("re", 0, 2, []);
            Assert.IsType<Re>(lower);
            Assert.Equal(new Re(0, 2, []), lower);

            var higher = Scanner.IsReservedKeyword("RE", 0, 2, []);
            Assert.IsType<Re>(higher);
            Assert.Equal(new Re(0, 2, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Real()
        {
            var lower = Scanner.IsReservedKeyword("real", 0, 4, []);
            Assert.IsType<Real>(lower);
            Assert.Equal(new Real(0, 4, []), lower);

            var higher = Scanner.IsReservedKeyword("REAL", 0, 4, []);
            Assert.IsType<Real>(higher);
            Assert.Equal(new Real(0, 4, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Reshape()
        {
            var lower = Scanner.IsReservedKeyword("reshape", 0, 7, []);
            Assert.IsType<Reshape>(lower);
            Assert.Equal(new Reshape(0, 7, []), lower);

            var higher = Scanner.IsReservedKeyword("RESHAPE", 0, 7, []);
            Assert.IsType<Reshape>(higher);
            Assert.Equal(new Reshape(0, 7, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Rol()
        {
            var lower = Scanner.IsReservedKeyword("rol", 0, 3, []);
            Assert.IsType<Rol>(lower);
            Assert.Equal(new Rol(0, 3, []), lower);

            var higher = Scanner.IsReservedKeyword("ROL", 0, 3, []);
            Assert.IsType<Rol>(higher);
            Assert.Equal(new Rol(0, 3, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Ror()
        {
            var lower = Scanner.IsReservedKeyword("ror", 0, 3, []);
            Assert.IsType<Ror>(lower);
            Assert.Equal(new Ror(0, 3, []), lower);

            var higher = Scanner.IsReservedKeyword("ROR", 0, 3, []);
            Assert.IsType<Ror>(higher);
            Assert.Equal(new Ror(0, 3, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Rot()
        {
            var lower = Scanner.IsReservedKeyword("rot", 0, 3, []);
            Assert.IsType<Rot>(lower);
            Assert.Equal(new Rot(0, 3, []), lower);

            var higher = Scanner.IsReservedKeyword("ROT", 0, 3, []);
            Assert.IsType<Rot>(higher);
            Assert.Equal(new Rot(0, 3, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Set()
        {
            var lower = Scanner.IsReservedKeyword("set", 0, 3, []);
            Assert.IsType<Set>(lower);
            Assert.Equal(new Set(0, 3, []), lower);

            var higher = Scanner.IsReservedKeyword("SET", 0, 3, []);
            Assert.IsType<Set>(higher);
            Assert.Equal(new Set(0, 3, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Set8()
        {
            var lower = Scanner.IsReservedKeyword("set8", 0, 4, []);
            Assert.IsType<Set8>(lower);
            Assert.Equal(new Set8(0, 4, []), lower);

            var higher = Scanner.IsReservedKeyword("SET8", 0, 4, []);
            Assert.IsType<Set8>(higher);
            Assert.Equal(new Set8(0, 4, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Set16()
        {
            var lower = Scanner.IsReservedKeyword("set16", 0, 5, []);
            Assert.IsType<Set16>(lower);
            Assert.Equal(new Set16(0, 5, []), lower);

            var higher = Scanner.IsReservedKeyword("SET16", 0, 5, []);
            Assert.IsType<Set16>(higher);
            Assert.Equal(new Set16(0, 5, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Set32()
        {
            var lower = Scanner.IsReservedKeyword("set32", 0, 5, []);
            Assert.IsType<Set32>(lower);
            Assert.Equal(new Set32(0, 5, []), lower);

            var higher = Scanner.IsReservedKeyword("SET32", 0, 5, []);
            Assert.IsType<Set32>(higher);
            Assert.Equal(new Set32(0, 5, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Set64()
        {
            var lower = Scanner.IsReservedKeyword("set64", 0, 5, []);
            Assert.IsType<Set64>(lower);
            Assert.Equal(new Set64(0, 5, []), lower);

            var higher = Scanner.IsReservedKeyword("SET64", 0, 5, []);
            Assert.IsType<Set64>(higher);
            Assert.Equal(new Set64(0, 5, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Shl()
        {
            var lower = Scanner.IsReservedKeyword("shl", 0, 3, []);
            Assert.IsType<Shl>(lower);
            Assert.Equal(new Shl(0, 3, []), lower);

            var higher = Scanner.IsReservedKeyword("SHL", 0, 3, []);
            Assert.IsType<Shl>(higher);
            Assert.Equal(new Shl(0, 3, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Short()
        {
            var lower = Scanner.IsReservedKeyword("short", 0, 5, []);
            Assert.IsType<Short>(lower);
            Assert.Equal(new Short(0, 5, []), lower);

            var higher = Scanner.IsReservedKeyword("SHORT", 0, 5, []);
            Assert.IsType<Short>(higher);
            Assert.Equal(new Short(0, 5, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Shr()
        {
            var lower = Scanner.IsReservedKeyword("shr", 0, 3, []);
            Assert.IsType<Shr>(lower);
            Assert.Equal(new Shr(0, 3, []), lower);

            var higher = Scanner.IsReservedKeyword("SHR", 0, 3, []);
            Assert.IsType<Shr>(higher);
            Assert.Equal(new Shr(0, 3, []), higher);
        }

        [Fact]
        public void TestReservedMethods_SizeOf()
        {
            var lower = Scanner.IsReservedKeyword("sizeof", 0, 6, []);
            Assert.IsType<SizeOf>(lower);
            Assert.Equal(new SizeOf(0, 6, []), lower);

            var higher = Scanner.IsReservedKeyword("SIZEOF", 0, 6, []);
            Assert.IsType<SizeOf>(higher);
            Assert.Equal(new SizeOf(0, 6, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Step()
        {
            var lower = Scanner.IsReservedKeyword("step", 0, 4, []);
            Assert.IsType<Step>(lower);
            Assert.Equal(new Step(0, 4, []), lower);

            var higher = Scanner.IsReservedKeyword("STEP", 0, 4, []);
            Assert.IsType<Step>(higher);
            Assert.Equal(new Step(0, 4, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Sum()
        {
            var lower = Scanner.IsReservedKeyword("sum", 0, 3, []);
            Assert.IsType<Sum>(lower);
            Assert.Equal(new Sum(0, 3, []), lower);

            var higher = Scanner.IsReservedKeyword("SUM", 0, 3, []);
            Assert.IsType<Sum>(higher);
            Assert.Equal(new Sum(0, 3, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Signed8()
        {
            var lower = Scanner.IsReservedKeyword("signed8", 0, 7, []);
            Assert.IsType<Signed8>(lower);
            Assert.Equal(new Signed8(0, 7, []), lower);

            var higher = Scanner.IsReservedKeyword("SIGNED8", 0, 7, []);
            Assert.IsType<Signed8>(higher);
            Assert.Equal(new Signed8(0, 7, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Signed16()
        {
            var lower = Scanner.IsReservedKeyword("signed16", 0, 8, []);
            Assert.IsType<Signed16>(lower);
            Assert.Equal(new Signed16(0, 8, []), lower);

            var higher = Scanner.IsReservedKeyword("SIGNED16", 0, 8, []);
            Assert.IsType<Signed16>(higher);
            Assert.Equal(new Signed16(0, 8, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Signed32()
        {
            var lower = Scanner.IsReservedKeyword("signed32", 0, 8, []);
            Assert.IsType<Signed32>(lower);
            Assert.Equal(new Signed32(0, 8, []), lower);

            var higher = Scanner.IsReservedKeyword("SIGNED32", 0, 8, []);
            Assert.IsType<Signed32>(higher);
            Assert.Equal(new Signed32(0, 8, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Signed64()
        {
            var lower = Scanner.IsReservedKeyword("signed64", 0, 8, []);
            Assert.IsType<Signed64>(lower);
            Assert.Equal(new Signed64(0, 8, []), lower);

            var higher = Scanner.IsReservedKeyword("SIGNED64", 0, 8, []);
            Assert.IsType<Signed64>(higher);
            Assert.Equal(new Signed64(0, 8, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Unsigned8()
        {
            var lower = Scanner.IsReservedKeyword("unsigned8", 0, 9, []);
            Assert.IsType<Unsigned8>(lower);
            Assert.Equal(new Unsigned8(0, 9, []), lower);

            var higher = Scanner.IsReservedKeyword("UNSIGNED8", 0, 9, []);
            Assert.IsType<Unsigned8>(higher);
            Assert.Equal(new Unsigned8(0, 9, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Unsigned16()
        {
            var lower = Scanner.IsReservedKeyword("unsigned16", 0, 10, []);
            Assert.IsType<Unsigned16>(lower);
            Assert.Equal(new Unsigned16(0, 10, []), lower);

            var higher = Scanner.IsReservedKeyword("UNSIGNED16", 0, 10, []);
            Assert.IsType<Unsigned16>(higher);
            Assert.Equal(new Unsigned16(0, 10, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Unsigned32()
        {
            var lower = Scanner.IsReservedKeyword("unsigned32", 0, 10, []);
            Assert.IsType<Unsigned32>(lower);
            Assert.Equal(new Unsigned32(0, 10, []), lower);

            var higher = Scanner.IsReservedKeyword("UNSIGNED32", 0, 10, []);
            Assert.IsType<Unsigned32>(higher);
            Assert.Equal(new Unsigned32(0, 10, []), higher);
        }

        [Fact]
        public void TestReservedMethods_Unsigned64()
        {
            var lower = Scanner.IsReservedKeyword("unsigned64", 0, 10, []);
            Assert.IsType<Unsigned64>(lower);
            Assert.Equal(new Unsigned64(0, 10, []), lower);

            var higher = Scanner.IsReservedKeyword("UNSIGNED64", 0, 10, []);
            Assert.IsType<Unsigned64>(higher);
            Assert.Equal(new Unsigned64(0, 10, []), higher);
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
