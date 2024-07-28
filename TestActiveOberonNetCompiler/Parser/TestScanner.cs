
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
    }
}
