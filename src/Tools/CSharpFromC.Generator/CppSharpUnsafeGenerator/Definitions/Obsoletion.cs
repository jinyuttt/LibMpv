namespace CSharpFromC.Generator.CppSharpUnsafeGenerator.Definitions;

public record struct Obsoletion
{
    public bool IsObsolete { get; init; }
    public string Message { get; init; }
}
