using static System.Console;

static class Program
{
    static ref int OrMaybe(this ref int x, in int y)
    {
        x++; //y--;
        return ref x;
    }

    static void Main(string[] args)
    {
        int a = 1, b = 1000;
        ref int c = ref a.OrMaybe(b);

        WriteLine($"a = {a}, b = {b}, c = {c}");
    }
}