namespace Algorithms.DynamicProgramming;

public static class Fibonacci
{
    private static Dictionary<int, long> memo = new();

    public static long Compute(int n)
    {
        if (n < 1) return n;
        if (memo.ContainsKey(n)) return memo[n];

        memo[n] = Compute(n - 1) + Compute(n - 2);

        return memo[n];
    }
}