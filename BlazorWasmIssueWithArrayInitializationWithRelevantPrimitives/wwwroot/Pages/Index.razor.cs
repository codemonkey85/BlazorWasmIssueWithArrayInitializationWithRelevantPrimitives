namespace DoesntWorkInBlazorWasm.wwwroot.Pages;

public partial class Index
{
    protected override void OnInitialized()
    {
        ReadOnlySpan<MyEnum> myEnums = new[]
        {
            MyEnum.A,
            MyEnum.B,
            MyEnum.C
        };
        Console.WriteLine(string.Join(", ", myEnums.ToArray()));
        base.OnInitialized();
    }

    enum MyEnum
    {
        A,
        B,
        C
    }
}
