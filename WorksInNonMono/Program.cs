ReadOnlySpan<MyEnum> myEnums = new[] { MyEnum.A, MyEnum.B, MyEnum.C };
Console.WriteLine(string.Join(", ", myEnums.ToArray()));

enum MyEnum
{
    A,
    B,
    C
}
