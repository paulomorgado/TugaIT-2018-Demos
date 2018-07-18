using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[10];
        Span<int> span = array.AsSpan();
        for (int i = 0; i < 10; i++) array[i] = i;
        foreach (int v in span) WriteLine(v);
    }
}