using static System.Console;

static class Program
{
    static int OrMaybe(int x, int y)
    {
        x++; y--;
        return x;
    }

    static void Main(string[] args)
    {
        int a = 1, b = 10;
        int c = OrMaybe(a, b);

        WriteLine($"a = {a}, b = {b}, c = {c}");
    }
}