namespace TheTestCode;

public static class Test
{
    public enum MyEnum
    {
        A,
        B,
        C
    }

    public static void Run()
    {
        ReadOnlySpan<MyEnum> myEnums = new[] { MyEnum.A, MyEnum.B, MyEnum.C };
        Console.WriteLine(string.Join(", ", myEnums.ToArray()));
    }
}
