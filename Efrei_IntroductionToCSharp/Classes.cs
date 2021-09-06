using System;
using System.Collections.Generic;
using Efrei_IntroductionToCSharp.Ressources;

namespace Efrei_IntroductionToCSharp
{
    public class Classes
    {
        public void Exemple()
        {
            var grade = new Grade(19);
            
            var student1 = new Student("Jacques", "3 rue Blois", 23);
            student1.GradesList.Add(grade);
            student1.GradesList.Add(new Grade(77));
            var gradeList = new List<Grade> {new Grade(45), new Grade(30), new Grade(99)};
            student1.GradesList.AddRange(gradeList);
            student1.IntroduceYourself();

            var student2 = new Student
            {
                Name = "Emily",
                Adress = "10 Downing St",
                Age = 22,
                GradesList = new List<Grade>
                {
                    new Grade(78),
                    new Grade(100),
                    new Grade(99),
                    new Grade(53),
                }
            };
            student2.IntroduceYourself();

            DoesStudentPass(student1);
            DoesStudentPass(student2);
        }

        private static void DoesStudentPass(Student student)
        {
            if (student.MeanOfAllGrades() > 70)
                Console.WriteLine($"Congratulation {student.Name}, you pass !");
            else
                Console.WriteLine($"Sorry {student.Name}, you failed...");
        }
    }
}

