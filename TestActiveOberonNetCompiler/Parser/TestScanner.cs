
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
