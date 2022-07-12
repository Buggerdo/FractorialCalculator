
namespace FractorialCalculator
{
    internal class FractorialRecursion
    {
        public static ulong Fractorial(ulong number)
        {
            if(number == 0)
            {
                return 1;
            }
            return number * Fractorial(number - 1);
        }
    }
}
