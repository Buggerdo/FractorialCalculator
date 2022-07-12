using static System.Console;

namespace FractorialCalculator
{
    internal class GetUInt
    {
        public static uint UserInput()
        {
            uint userInput;
            do
            {
                Clear();
                Write("Please enter a whole number from 1 to 20 : ");
                string input = ReadLine();

                try
                {
                    userInput = Convert.ToUInt32(input);
                    if(userInput <= 20 && userInput > 0) return userInput;
                    else if(userInput == 0) WriteLine("Number can't be 0.");
                    else WriteLine("Number is too big.");
                }
                catch(FormatException)
                {
                    WriteLine("That is not a number.");
                }
                catch(OverflowException)
                {
                    WriteLine("Number is out of range.");
                }
                ReadKey();
            } while(true);
        }
    }
}
