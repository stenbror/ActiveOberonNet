﻿
namespace ActiveOberonNetCompiler.Parser
{
    public record Symbols(uint StartPos, uint EndPos, Trivia[] Trivias);

    public record Empty() : Symbols(0, 0, []);
    public record EndOfFile(uint StartPos, Trivia[] Trivias) : Symbols(StartPos, 0, Trivias);

    public record Address(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Alias(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Array(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Await(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Begin(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record By(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Const(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);

    public record Case(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Cell(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record CellNet(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Code(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Do(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Div(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record End(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Enum(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Else(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Elsif(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Exit(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Extern(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record False(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record For(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Finally(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record If(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Ignore(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Imag(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record In(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Is(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Import(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Loop(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Module(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Mod(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Nil(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Object(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Of(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Or(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Out(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Operator(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Pointer(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Procedure(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Port(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Repeat(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Return(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Self(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record New(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Record(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Result(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Size(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Then(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record True(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record To(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Type(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Until(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Var(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record While(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record With(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);

    public record Abs(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record AddressOf(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record All(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Any(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Ash(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Assert(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Boolean(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Cap(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Cas(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Char(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Chr(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Complex(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Complex32(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Complex64(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Copy(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Dec(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record DecMul(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Dim(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Entier(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record EntierH(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Excl(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record First(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Float32(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Float64(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Floor(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Halt(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Im(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Inc(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Incl(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record IncMul(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Incr(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Integer(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record IntegerSet(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Last(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Len(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Long(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record LongInteger(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Lsh(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Max(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Min(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Odd(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Range(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Re(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Real(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Reshape(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Rol(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Ror(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Rot(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Set(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Set8(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Set16(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Set32(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Set64(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Shl(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Short(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Shr(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Step(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Signed8(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Signed16(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Signed32(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Signed64(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record SizeOf(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Sum(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Unsigned8(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Unsigned16(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Unsigned32(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Unsigned64(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);

    public record LeftParen(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record LeftBracket(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record LeftCurly(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record RightParen(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record RightBracket(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record RightCurly(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Comma(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Period(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record UpTo(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Colon(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record SemiColon(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record And(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Invert(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Xor(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record QuestionMark(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record NotEqual(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record DotNotEqual(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Equal(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record DotEqual(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Less(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record DotLess(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record LessEqual(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record DotLessEqual(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Greater(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record DotGreater(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record GreaterEqual(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record DotGreaterEqual(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Plus(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record PlusMul(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Minus(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Mul(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record DotMul(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Power(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Slash(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record DotSlash(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record BackSlash(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record BackQuote(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);
    public record Assign(uint StartPos, uint EndPos, Trivia[] Trivias) : Symbols(StartPos, EndPos, Trivias);

    public record Ident(uint StartPos, uint EndPos, Trivia[] Trivias, string text) : Symbols(StartPos, EndPos, Trivias);
}   
