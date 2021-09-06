using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Efrei_IntroductionToCSharp.Ressources;

namespace Efrei_IntroductionToCSharp
{
    public class Collection
    {
        /* To work on the differents parts of this code, I separated the collections
         * under "regions" that can easily be squeezed by clicking on the minus
         * symbol nest to it. So you can comment what's inside a region to only work with
         * Dictionnaries, for instance.
         */
        public void Exemple()
        {
            var student1 = new Student("John", 23);
            var student2 = new Student("Emily", 22);
            var student3 = new Student("Hugo", 26);
            var student4 = new Student("Claude", 17);
            var student5 = new Student("Oliver", 20);

            #region List
            Console.WriteLine("These are the list exemple :");
            var list = new List<Student> {student1, student2, student4};
            list.Reverse();
            list.Add(student3);
            list.Add(student5);
            list.Remove(student3);

            foreach (var student in list)
            {
                student.Greet();
            }
            #endregion

            #region QueueStack
            Console.WriteLine(Environment.NewLine + "Now for some Queue and Stacks :");
            
            // First In First Out (FIFO)
            var queue = new Queue<Student>();
            queue.Enqueue(student1);
            queue.Enqueue(student2);
            queue.Dequeue().Greet();

            // First In Last Out (FILO)
            var stack = new Stack<Student>();
            stack.Push(student1);
            stack.Push(student2);
            stack.Push(student3);
            stack.Pop().Greet();
            #endregion
            
            #region Dictionary
            Console.WriteLine(Environment.NewLine + "Onto dictionnaries :");
            
            var index = 1;
            var promotion = new Dictionary<int, Student>
            {
                {index++, student1},
                {index++, student2},
                {index++, student3},
                {index++, student4},
                {index++, student5}
            };

            promotion[1].Greet();
            promotion[3].Greet();
            promotion[3].Age = 29;  // Collection values can be accessed and modified 
            promotion[3].Greet();
            student3.Greet();       // student3 value is modified
            #endregion

            // Here are some concurrent collection you might need.
            var concurrentDictionary = new ConcurrentDictionary<Student, object>();
            var concurrentBag = new ConcurrentBag<float>();
            
            // It is of course possible to create complex objects, although this isn't recommended
            var pleaseDontDoThis = new Dictionary<Tuple<int, ConcurrentBag<char>>, List<Stack<Student>>>();
        }
    }
}

