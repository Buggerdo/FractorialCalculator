using static System.Console;
using static FractorialCalculator.FractorialRecursion;
using static FractorialCalculator.GetUInt;


namespace FractorialCalculator
{
    internal class Calculator
    {
        public Calculator()
        {
            WriteLine(Fractorial(UserInput()));
        }
    }
}
