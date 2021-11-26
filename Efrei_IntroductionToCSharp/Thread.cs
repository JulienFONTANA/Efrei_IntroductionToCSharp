using System;
using System.Threading;

namespace Efrei_IntroductionToCSharp
{
    public class ThreadEx : IExemple
    {
        private const int MillisecondsTimer = 500;
        
        // The ThreadProc method is called when the thread starts.
        // It loops ten times, writing to the console and yielding
        // the rest of its time slice each time, and then ends.
        private static void ThreadProc() 
        {
            for (var i = 0; i < 10; i++) 
            {
                Console.WriteLine("ThreadProc: {0}", i);
                // Yield the rest of the time slice.
                Thread.Sleep(MillisecondsTimer);
            }
        }
        
        private static void ThreadProc2() 
        {
            for (var i = 0; i < 10; i++) 
            {
                Console.WriteLine("ThreadProc: {0}", i);
                // Yield the rest of the time slice.
                Thread.Sleep(MillisecondsTimer);
            }
        }

        // Try this program many times, the output will differ
        // because the threads order is not define
        public void Run() 
        {
            Console.WriteLine("Main thread: Start the main thread.");
            var t = new Thread(ThreadProc);     // Second thread
            var t2 = new Thread(ThreadProc2);   // Third thread
            
            t.Start();
            t2.Start();

            for (var i = 0; i < 7; i++) 
            {
                Console.WriteLine("Main thread: Do some work.");
                Thread.Sleep(MillisecondsTimer);
            }

            Console.WriteLine("Main thread: Call Join(), to wait until ThreadProc ends.");
            t.Join();
            t2.Join();
        }

        public string DisplayExempleName()
        {
            return "Thread";
        }
    }
}

