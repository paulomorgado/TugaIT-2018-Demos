using System.Linq;
using System.Threading.Tasks;
using static System.Console;

class Program
{
    static async Task Main(string[] args)
    {
        int[] numbers = { 0b1, 0b10, 0b100, 0b1000, 0b1_0000, 0b10_0000 };
        int result = await SumOfSquaresAsync(numbers);
        WriteLine(result);
    }

    static Task<int> SumOfSquaresAsync(int[] numbers)
    {
        return Task.Run(Compute);

        int Compute() => numbers.Select(i => i * i).Sum();
    }
}
