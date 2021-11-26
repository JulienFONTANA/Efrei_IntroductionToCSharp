using System;

namespace Efrei_IntroductionToCSharp
{
    public class ConditionalStructures : IExemple
    {
        public void Run()
        {
            /* If / If else / else can be chained as many time as you want,
             * but 3 is the norm. Having only "if" statement can make your
             * condition be true on multiple lines.
             *
             * Order given to statement is crucial. The line "I'm an adult now"
             * is not displayed for example.
             */ 
            
            var myAge = 27;
            if (myAge >= 1 && myAge < 18)
            {
                Console.WriteLine("I'm a minor");
            }
            else if (myAge >= 18 && myAge < 30)
            {
                Console.WriteLine("Living my best life ;)");
            }
            else if (myAge >= 18 && myAge < 100)
            {
                Console.WriteLine("I'm an adult now");
            }
            else
            {
                Console.WriteLine("I'm a liar");
                if (myAge > 150)
                {
                    Console.WriteLine("Maybe I should not lie about my age...");
                }
            }

            /* For is the classic "C-style" loop.
             * Like any conditional structures, it can be nested
             */
            for (var i = 1; i < 5; i++)
            {
                for (var j = 1; j < 5; j++)
                {
                    if (i*j % 2 == 0)
                    {
                        Console.WriteLine($"{i}*{j}={i*j}");
                    }
                }
            }

            /* Foreach loops are a very common and powerful tool
             * to iterate on collections, such as array, list,
             * or dictionaries 
             */
            int[] myIntArray= {1, 2, 3, 4, 5, 6, 7, 8, 9};
            foreach (var myInt in myIntArray)
            {
                Console.Write(myInt + " ");
            }
            Console.WriteLine();

            /* Switch statement can be used to iterate on a define series of elements.
             * Each case can lead to a different output. Please note the "break" keyword
             * at the end of cases and a default case (which could be reach is some instances
             * but not here, as all days of the week are switch cases)
             */
            var today = DateTime.Now.DayOfWeek;
            switch (today)
            {
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                    Console.WriteLine("All work and no play made Jack a dull boy.");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Soon !");
                    break;
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("Week-end, yay !");
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            // This switch is similar to the first example
            switch (myAge)
            {
                case >= 1 and < 18:
                    Console.WriteLine("I'm a minor");
                    break;
                case >= 18 and < 30:
                    Console.WriteLine("Living my best life ;)");
                    break;
                case >= 18 and < 100:
                    Console.WriteLine("I'm an adult now");
                    break;
                default:
                {
                    Console.WriteLine("I'm a liar");
                    if (myAge > 150)
                    {
                        Console.WriteLine("Maybe I should not lie about my age...");
                    }

                    break;
                }
            }
        }

        public string DisplayExempleName()
        {
            return "Conditional Structures and Loops";
        }
    }
}