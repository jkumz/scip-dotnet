namespace Main;

public class ChainedExpressions
{
    public int Value { get; set; }
    public ChainedExpressions Next { get; set; } = null!;

    public ChainedExpressions Method(int x) => this;

    public void TestChains()
    {
        var obj = new ChainedExpressions();

        // Simple member access: a.b
        var v1 = obj.Value;

        // Chained member access: a.b.c
        var v2 = obj.Next.Value;

        // Member access + invocation: a.b(41)
        var v3 = obj.Method(41);

        // Complex chain: a.b(41).c(42).d(43)
        var v4 = obj.Method(41).Method(42).Method(43);

        // Chained member + invocation: a.b.c(41)
        var v5 = obj.Next.Method(41);

        // Standalone reference
        var v6 = obj;

        // Binary expression
        var v7 = obj.Value + obj.Value;
    }
}
