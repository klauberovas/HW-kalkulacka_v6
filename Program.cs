namespace HW_kalkulacka_v6
{
    internal class Program
    {
        public static (double, bool) GetNumber(string prompt, bool integerOnly = false)
        {

            while (true)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();

                if (CheckForExit(input)) return (0, false);


               
                if (integerOnly)
                {
                    if (int.TryParse(input, out int intResult)) return (intResult, true);
                }
                else
                {
                    if (double.TryParse(input, out double doubleResult)) return (doubleResult, true);
                }

                Console.WriteLine("Neplatné hodnota. Zkus to znovu.");
            }
        }

        public static string GetOperator(string prompt, Calculator kalkulacka)
        {
            

            while (true)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();

                if (CheckForExit(input)) return null;

                if (!kalkulacka.isValidOperator(input))
                {
                    Console.WriteLine("Neplatný operátor. Zadej znovu.");
                    continue;
                }
                return input;
            }
        }

        public static double Calculate(double numberTwo, string mathOperator, Calculator kalkulacka)
        {

            switch (mathOperator)
            {
                case "+":
                    return kalkulacka.SumUp(numberTwo);

                case "-":
                    return kalkulacka.Subtract(numberTwo);

                case "*":
                    return kalkulacka.Multiply(numberTwo);

                case "/":
                    return kalkulacka.Divide(numberTwo);
                case "^":
                    return kalkulacka.Power((int)numberTwo);
                default:
                    return 0;
            }
        }
        public static bool CheckForExit(string input)
        {
            if (input.ToUpper() == "X")
            {
                Console.WriteLine("Kalkulačka končí.");
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("KALKULAČKA");

            Calculator calculator = new Calculator();

            var (numberOne, shouldContinue) = GetNumber("Zadej první číslo:");
            if (!shouldContinue)
            {
                return;
            }

            calculator.SumUp(numberOne);

            while (true)
            {

                Console.WriteLine("Pokud si přejete během programu skončit, zadejte X pro ukončení.");

                string mathOperator = GetOperator("Zadej operátor (+, -, *, /, ^):", calculator);

                if (mathOperator == null)
                {
                    break;
                }

                if (mathOperator == "^")
                {
                    var (exponent, continueLoop) = GetNumber("Zadej mocnitele (celé číslo) :", true);
                    if (!continueLoop)
                    {
                        return;
                    }
                    numberOne = calculator.GetCurrentResult();
                    Calculate(exponent, mathOperator, calculator);
                    Console.WriteLine($"Výsledek: {numberOne} {mathOperator} {exponent} = {calculator.GetCurrentResult()}");
                }
                else
                {
                    var (numberTwo, continueLoop) = GetNumber("Zadej druhé číslo:");
                    if (!continueLoop)
                    {
                        return;
                    }

                    if (mathOperator == "/" && numberTwo == 0)
                    {
                        Console.WriteLine("Dělení 0 není možné.");
                        continue;
                    }
                    numberOne = calculator.GetCurrentResult();
                    Calculate(numberTwo, mathOperator, calculator);
                    Console.WriteLine($"Výsledek: {numberOne} {mathOperator} {numberTwo} = {calculator.GetCurrentResult()}");
                }

            }
        }
    }
}

