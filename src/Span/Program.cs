using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[10];
        Span<int> span = array.AsSpan();
        Span<int> slice = span.Slice(3, 5);
        for (int i = 0; i < 10; i++) span[i] = i;
        foreach (int v in slice) WriteLine(v);
    }
}