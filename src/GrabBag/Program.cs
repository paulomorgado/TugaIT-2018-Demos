using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

class Program
{
    static async Task Main(string[] args)
    {
        int[] numbers = { 0b1, 0b10, 0b100, 0b_1000, 0b1_0000, 0b10_0000 };
        int result = await SumOfSquaresAsync(numbers, default);
        WriteLine(result);
    }

    static Task<int> SumOfSquaresAsync(int[] numbers, CancellationToken cancellationToken)
    {
        return Task.Run(function: Compute, cancellationToken);

        int Compute() => numbers.Select(i => i * i).Sum();
    }

    unsafe void M<D,E,T>(D d, E e, T *p)
        where D: Delegate
        where E: Enum
        where T: unmanaged
    {
    }

    unsafe void M()
    {
        var i = 10;
        var p = &i;
        M<Action, StringComparison, int>(
            delegate() { },
            StringComparison.InvariantCultureIgnoreCase,
            p);
    }
}
