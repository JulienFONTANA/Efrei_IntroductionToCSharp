using System;
using System.Collections.Generic;

namespace Efrei_IntroductionToCSharp.Ressources
{
    public class Student
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public int Age { get; set; }
        
        public GenderEnum Gender { get; set; }
        
        public List<Grade> GradesList { get; set; }

        public double GradePointAverage { get; set; }
        
        // Defaulted constructor with list initialisation
        public Student()
        {
            GradesList = new List<Grade>();
        }
        
        // Classic constructors with arguments
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
            GradesList = new List<Grade>();
        }
        
        public Student(string name, string adress, int age)
        {
            Name = name;
            Adress = adress;
            Age = age;
            GradesList = new List<Grade>();
        }

        public int MeanOfAllGrades()
        {
            if (GradesList.Count == 0)
                return 0;

            var sumOfGrades = 0;
            foreach (var grade in GradesList)
            {
                sumOfGrades += grade.GradeOn100;
            }

            return sumOfGrades / GradesList.Count;
        }

        public void IntroduceYourself()
        {
            Console.WriteLine($"I'm {Name}, living in {Adress}, and I'm {Age}.");
        }
        
        public void Greet()
        {
            Console.WriteLine($"Hello I am {Name} and I'm {Age}.");
        }
    }
}