using static System.Console;

namespace FractorialCalculator
{
    internal class Continue
    {
        public static bool IsContinue()
        {
            string[] yes = {"y", "yes", "yup" };
            string[] no = { "n", "no", "nope" };

            WriteLine("\nPress any key to continue");
            ReadKey();

            do
            {
                Clear();
                Write("Continue Y/N? : ");
                string input = ReadLine().ToLower().Trim();
                Clear();
                if(yes.Contains(input)) return true;
                else if(no.Contains(input)) return false;               
            } while(true);
        }
    }
}
