using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[10];
        ReadOnlySpan<int> span = array.AsSpan();
        ReadOnlySpan<int> slice = span.Slice(3, 5);
        for (int i = 0; i < 10; i++) array[i] = i;
        foreach (int v in slice) WriteLine(v);
    }
}