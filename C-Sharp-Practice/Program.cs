using System;

namespace C_Sharp_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            bool status = true;
            Console.WriteLine("Please enter first number");
            string input1 = Console.ReadLine();
            int convertedNumber1 = VerifyUserInput(input1, status);

            Console.WriteLine("Please enter second number");
            string input2 = Console.ReadLine();
            int convertedNumber2 = VerifyUserInput(input2, status);

            Console.WriteLine("What would you like to do?\nPlease type 'Add', 'Subtract', 'Multiply', or 'Divide'");
            string operation = Console.ReadLine();
            operation = VerifyOperation(operation, status);
            switch (operation)
            {
                case "Add":
                    Add(convertedNumber1, convertedNumber2);
                    break;
                case "Subtract":
                    Subtract(convertedNumber1, convertedNumber2);
                    break;
                case "Multiply":
                    Multiply(convertedNumber1, convertedNumber2);
                    break;
                case "Divide":
                    Divide(convertedNumber1, convertedNumber2);
                    break;
            }
        }

        // Verifies if the user's operation request is a valid choice. If not, will continue to ask the user until they enter a valid input.
        public static string VerifyOperation (string math, bool status)
        {
            string operation = math;
            if (math != "Add" && math != "Subtract" && math != "Multiply" && math != "Divide")
            {
                status = false;
                while (status == false)
                {
                    Console.WriteLine("Please enter a valid operation");
                    string fixedInput = Console.ReadLine();
                    if (fixedInput == "Add" || fixedInput == "Subtract" || fixedInput == "Multiply" || fixedInput == "Divide")
                    {
                        status = true;
                        operation = fixedInput;
                        break;
                    }
                }
            }
            return operation;
        }

        // Takes user's input and verifies if it is a valid number. If it is not a valid number, will continue asking for a valid number.
        public static int VerifyUserInput (string input, bool status)
        {
            int number = 0;
            if (VerifyIsNumber(input) == false)
            {
                status = false;
                while (status == false)
                {
                    Console.WriteLine("Please enter a valid number");
                    string fixedInput = Console.ReadLine();
                    if (VerifyIsNumber(fixedInput))
                    {
                        status = true;
                        number = Convert.ToInt32(fixedInput);
                        break;
                    }
                }
            }
            else
            {
                number = Convert.ToInt32(input);
            }
            return number;
        }

        // Simple method to add two numbers and return the sum.
        public static void Add(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine("The sum of " + num1 + " plus " + num2 + " is " + sum);
        }

        // Simple method to subtract two numbers and return the difference.
        public static void Subtract(int num1, int num2)
        {
            int diff = num1 - num2;
            Console.WriteLine("The difference of " + num1 + " minus " + num2 + " is " + diff);
        }

        // Simple method to multiply two numbers and return the product.
        public static void Multiply(int num1, int num2)
        {
            int product = num1 * num2;
            Console.WriteLine("The product of " + num1 + " times " + num2 + " is " + product);
        }

        // Simple method to divide two numbers and return the quotient.
        public static void Divide(int num1, int num2)
        {
            double quotient = num1 / num2;
            Console.WriteLine("The quotient of " + num1 + " divided by " + num2 + " is " + quotient);
        }

        // Verifies is the user's input is a number or not. Returns 'true' if it is a number, otherwise returns 'false'.
        public static bool VerifyIsNumber(string input)
        {
            int myInt;
            bool isNumeric = int.TryParse(input, out myInt);
            return isNumeric;
        }
    }
}
