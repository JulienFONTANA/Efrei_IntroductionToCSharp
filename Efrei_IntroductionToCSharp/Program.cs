using System;
using System.Collections.Generic;

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
         * You have the option to run the program in "debug mode" which allow the usage of
         * breakpoint. Just click anywhere between the line number and a piece of code and a
         * red dot should appear. The program will then stop there, so you can look at what is
         * does step by step.
         *
         * Good luck !
         */
        private static ConditionalStructures _conditionalStructuresExemple;
        private static Function _functionExemple;
        private static Classes _classesExemple;
        private static Collection _collectionExemple;
        private static Linq _linqExemple;
        private static Inheritance _inheritanceExemple;
        private static TaskEx _taskExemple;
        private static ThreadEx _threadExemple;
        
        public static void Main()
        {
            InitExample();
            
            // if you want to run all examples at the same time
            if (RunAll(true))
                return;
            
            Console.WriteLine(_conditionalStructuresExemple.DisplayExempleName());
            _conditionalStructuresExemple.Run();
            
            Console.WriteLine(NextPart() + _functionExemple.DisplayExempleName());
            _functionExemple.Run();

            Console.WriteLine(NextPart() + _classesExemple.DisplayExempleName());
            _classesExemple.Run();

            Console.WriteLine(NextPart() + _collectionExemple.DisplayExempleName());
            _collectionExemple.Run();

            Console.WriteLine(NextPart() + _linqExemple.DisplayExempleName());
            _linqExemple.Run();

            Console.WriteLine(NextPart() + _inheritanceExemple.DisplayExempleName());
            _inheritanceExemple.Run();

            Console.WriteLine(NextPart() + _taskExemple.DisplayExempleName());
            _taskExemple.Run();
            
            Console.WriteLine(NextPart() + _threadExemple.DisplayExempleName());
            _threadExemple.Run();
            
            // This might be useful to see logs written in console mode
            // if you're not running this program in debug mode.
            Console.WriteLine("Press a key to end program.");
            Console.ReadLine();
        }

        private static void InitExample()
        {
            _conditionalStructuresExemple = new ConditionalStructures();
            _functionExemple = new Function();
            _classesExemple = new Classes();
            _collectionExemple = new Collection();
            _linqExemple = new Linq();
            _inheritanceExemple = new Inheritance();
            _taskExemple = new TaskEx();
            _threadExemple = new ThreadEx();
        }

        // bool runAll = false is a default parameter
        // So RunAll() and RunAll(false) are similar
        private static bool RunAll(bool runAll = false)
        {
            if (runAll == false) 
                return false;

            var exemples = new List<IExemple>
            {
                _conditionalStructuresExemple,
                _functionExemple,
                _classesExemple,
                _collectionExemple,
                _linqExemple,
                _inheritanceExemple,
                _taskExemple,
                _threadExemple
            };

            foreach (var exemple in exemples)
            {
                exemple.Run();
                Console.WriteLine(NextPart() + exemple.DisplayExempleName());
            }

            return true;
        }
        
        private static string NextPart()
        {
            return Environment.NewLine + "################################" + Environment.NewLine;
        }
    }
}