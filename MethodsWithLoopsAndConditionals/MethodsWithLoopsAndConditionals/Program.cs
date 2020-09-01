using System;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Counter();

            //PauseConsole();

            //CounterThree();

            PauseConsole();

            int userNum1 = GetUserNumber();
            int userNum2 = GetUserNumber();
            bool areEqual = EqualChecker(userNum1, userNum2);
            Console.WriteLine($"{userNum1} is equal to {userNum2}: {areEqual}");

            PauseConsole();

            EvenOrOdd(userNum1);

            PauseConsole();

            userNum1 = GetUserNumber();

            PositiveOrNegative(userNum1);

            Console.WriteLine("Please tell me your age and I will tell you if you can vote! ");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Could not compute, try again");
            }

            AgeChecker(age);

            int userNumber = GetUserNumber();

            RangeChecker(userNumber);

            userNumber = GetUserNumber();

            int multiplyTo = GetUserNumber();

            MultiTable(userNumber, multiplyTo);

            int userNumber = GetUserNumber();

            int[] randoNumbers = Populater(userNumber);

            foreach (var number in randoNumbers)
            {
                Console.WriteLine(number);
            }

            int sumOfElements = SumArray(randoNumbers);

            Console.WriteLine($"The sum of integers in the array = {sumOfElements}");

            PauseConsole();

            userNumber = GetUserNumber();

            Cuber(userNumber);
        }

        private static void Cuber(int cubeTo)
        {
            double cubed = 0;

            for (int i = 0; i <= cubeTo; i++)
            {
                cubed = Math.Pow(i, 3);
                Console.WriteLine($"Number is {i} and the cube of {i} is: {cubed}");
            }
        }

        private static int SumArray(int[] randoNumbers)
        {
            int sum = 0;

            for (int i = 0; i < randoNumbers.Length; i++)
            {
                sum += randoNumbers[i];
            }

            return sum;
        }

        private static int[] Populater(int userNumber)
        {
            int[] randos = new int[userNumber];

            Random rng = new Random();

            for (int i = 0; i < randos.Length; i++)
            {
                randos[i] = rng.Next(501);
            }

            return randos;
        }

        private static void MultiTable(int userNumber, int multiplyTo)
        {
            int product = 0;

            for (int i = 1; i <= multiplyTo; i++)
            {
                product = userNumber * i;
                Console.WriteLine($"{userNumber} X {i} = {product}");
            }
        }

        private static void RangeChecker(int userNumber)
        {
            if (userNumber >= -10 && userNumber <= 10)
            {
                Console.WriteLine($"{userNumber} is in range!");
            }
            else
            {
                Console.WriteLine("Out of bounds");
            }
        }

        private static void AgeChecker(int userAge)
        {
            if (userAge >= 18)
            {
                Console.WriteLine("You may vote!");
            }
            else
            {
                Console.WriteLine("You are too young, try again when you are older!");
            }
        }

        private static void PositiveOrNegative(int num1)
        {
            if (num1 > 0)
            {
                Console.WriteLine("The number is positive");
            }
            else
            {
                Console.WriteLine("The number is negative");
            }
        }

        private static void EvenOrOdd(int userNumber)
        {
            if (userNumber % 2 == 0)
            {
                Console.WriteLine($"{userNumber} is even!!");
            }
            else if (userNumber % 2 != 0)
            {
                Console.WriteLine($"{userNumber} is odd!!");
            }
            else
            {
                Console.WriteLine("I have no clue what that is! Maybe Zero?");
            }
        }

        private static int GetUserNumber()
        {
            Console.Write("Give me a number: ");
            int userNumber = int.Parse(Console.ReadLine());

            return userNumber;
        }

        private static bool EqualChecker(int num1, int num2)
        {
            return num1 == num2;
        }

        private static void CounterThree()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        private static void Counter()
        {
            int goal = -1000;
            for (int i = 1000; i >= goal; i--)
            {
                Console.WriteLine(i);
            }
        }

        private static void PauseConsole()
        {
            Console.WriteLine();
            Console.ReadLine();
            Console.WriteLine();
        }
    }
}
