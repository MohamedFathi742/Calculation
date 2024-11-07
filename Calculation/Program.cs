namespace Calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // walcome to user 
            Console.WriteLine("Walcome to Calculation app\n");
            // ask user to enter value 1
            Console.WriteLine("Please Enter Value One  ");
            //reead value
            double dValue1 = 0;
            bool isConverted1 = double.TryParse(Console.ReadLine(), out dValue1);
            if (!isConverted1)
            {

                Console.WriteLine(" Please Enter Valid Number");
                return;
            }
            // ask user to enter value 2
            Console.WriteLine("Please Enter Value Tow  ");
            //reead value
            double dValue2 = 0;
            bool isConverted2 = double.TryParse(Console.ReadLine(), out dValue2);
            if (!isConverted2)
            {
                Console.WriteLine(" Please Enter Valid Number");
                return;
            } // ask user to enter ope
            Console.WriteLine("Please Enter Operation ");
            //reead ope
            char ope = 'm';
            bool isConvertedOpe = char.TryParse(Console.ReadLine(), out ope);
            if (!isConvertedOpe)
            {
                Console.WriteLine(" Please Enter Valid Operation");
                return;
            }
            //calc
            double result = 0;
            switch (ope)
            {

                case '+':
                    result = dValue1 + dValue2; Console.WriteLine();
                    break;
                case '-':
                    result = dValue1 - dValue2;
                    break;
                case '*':
                    result = dValue1 * dValue2;
                    break;
                case '/':
                    result = dValue1 / dValue2;
                    break;

            }
            Console.WriteLine($"Result = {result} ");
        }
    }
}
