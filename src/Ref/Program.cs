using static System.Console;

static class Program
{
    static ref readonly int OrMaybe(this in int x, in int y)
    {
        //x++; //y--;
        return ref x;
    }

    static void Main(string[] args)
    {
        int a = 1, b = 10;
        ref readonly int c = ref a.OrMaybe(b);
        a = 1000;

        WriteLine($"a = {a}, b = {b}, c = {c}");
    }
}