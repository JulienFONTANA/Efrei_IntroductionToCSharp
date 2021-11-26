using System;

namespace Efrei_IntroductionToCSharp
{
    public class Function : IExemple
    {
        public void Run()
        {
            // Functions can be linked
            Print(AddNumbers(1, 2));
            Print(AddNumbers(AddNumbers(1, 3), 2));
            Print(AddNumbers(3, AddNumbers(4, 5)));
            Print(AddNumbers(AddNumbers(1, 3), AddNumbers(4, 5)));
            
            // Functions Overloading
            Print(AddNumbers(1, 2, 3));
            Print(AddNumbers(1, 2, 5, 5, 6, 7));
        }

        public string DisplayExempleName()
        {
            return "Functions";
        }

        // Fct 1
        private static int AddNumbers(int first, int second)
        {
            return first + second;
        }
        
        // Fct 2
        private static int AddNumbers(int first, int second, int third)
        {
            return first + second + third;
        }

        // All functions could be replaced by this one, using the params keyword
        private static int AddNumbers(params int[] numbers)
        {
            var result = 0;
            foreach (var num in numbers)
            {
                result += num;
            }

            return result;
            // Could also be return numbers.Sum(), using LINQ;
        }
        
        private static void Print(int number)
        {
            Console.WriteLine(number);   
        }
    }
}

