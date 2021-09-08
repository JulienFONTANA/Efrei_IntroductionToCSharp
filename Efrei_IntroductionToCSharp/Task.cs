using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Efrei_IntroductionToCSharp
{
    public class TaskEx
    {
        public void Exemple()
        {
            var dirPath = new ConcurrentBag<string>();  // Concurrent collection 
            string[] dirNames = { ".", "..", "C:\\" };  // array of hard coded directory path
            var tasks = new List<Task>();
            
            // Foreach directory name... 
            foreach (var dirName in dirNames) 
            {
                // Create a new task...
                Task t = Task.Run(() => 
                {
                    // The task role is to iterate through directory file path
                    // and add these filepath into the collection.
                    foreach (var path in Directory.GetFiles(dirName))
                    {
                        dirPath.Add(path); 
                    }
                });
                tasks.Add(t); // Each task t is added to the collection
            }
            // Waiting for all task to finnish
            Task.WaitAll(tasks.ToArray());
            
            // Iteration on completed tasks 
            foreach (Task t in tasks)
            {
                Console.WriteLine("Task {0} Status: {1}", t.Id, t.Status);
            }
         
            Console.WriteLine("Number of files read: {0}", dirPath.Count);
        }
    }
}

