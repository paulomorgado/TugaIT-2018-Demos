using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 0b1, 0b10, 0b100, 0b1000, 0b1_0000, 0b10_0000 };
        int result = SumOfSquares(numbers);
        WriteLine(result);
    }

    static int SumOfSquares(int[] numbers)
    {
        return numbers.Select(i => i * i).Sum();
    }
}
