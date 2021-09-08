using System;

namespace Efrei_IntroductionToCSharp
{
    public static class Program
    {
        /* You could run this program all at once, but won't learn much.
         * What you can do is comment all sections but one, and then get inside the
         * class containing the examples.
         *
         * For instance, you could comment everything BUT the Conditional structures part
         * and then go to ConditionalStructures.cs to read the code.
         *
         * You have the option to run the program in "debug mode" which allow the useage of
         * breakpoint. Just click anywhere between the line number and a piece of code and a
         * red dot should appear. The program will then stop there, so you can look at what is
         * does step by step.
         *
         * Good luck !
         */
        
        public static void Main()
        {
            // Conditional structures
            Console.WriteLine("Conditional Structures and Loops");
            var conditionalStructuresExemple = new ConditionalStructures();
            conditionalStructuresExemple.Exemple();
            
            // Functions
            Console.WriteLine(NextPart() + "Functions");
            var functionExemple = new Function();
            functionExemple.Exemple();

            // Classes
            Console.WriteLine(NextPart() + "Classes");
            var classesExemple = new Classes();
            classesExemple.Exemple();

            // Collection
            Console.WriteLine(NextPart() + "Collection");
            var collectionExemple = new Collection();
            collectionExemple.Exemple();

            // LINQ
            Console.WriteLine(NextPart() + "Language integrated query aka LINQ");
            var linqExemple = new Linq();
            linqExemple.Exemple();

            // Inheritance
            Console.WriteLine(NextPart() + "Inheritance");
            var inheritanceExemple = new Inheritance();
            inheritanceExemple.Exemple();

            // Thread / Task
            Console.WriteLine(NextPart() + "Thread");
            var taskExemple = new TaskEx();
            taskExemple.Exemple();
            
            Console.WriteLine(NextPart() + "Task");
            var threadExemple = new ThreadEx();
            threadExemple.Exemple();
            
            // This might be useful to see logs written in console mode
            // if you're not running this program in debug mode.
            Console.WriteLine("Press a key to end program.");
            Console.ReadLine();
        }

        private static string NextPart()
        {
            return Environment.NewLine + "################################" + Environment.NewLine;
        }
    }
}