using static FractorialCalculator.Continue;

namespace FractorialCalculator
{
    internal class Program
    {
        static void Main()
        {
            do
            {
                _ = new Calculator();
            } while(IsContinue());
        }
    }
}