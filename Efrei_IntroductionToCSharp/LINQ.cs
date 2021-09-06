using System;
using System.Collections.Generic;
using System.Linq;
using Efrei_IntroductionToCSharp.Ressources;

namespace Efrei_IntroductionToCSharp
{
    public class Linq
    {
        public void Exemple()
        {
            var studentList = new List<Student>
            {
                new Student {Name = "Joe", Gender = GenderEnum.Male, GradePointAverage = 1.86 },
                new Student {Name = "William", Gender = GenderEnum.Male, GradePointAverage = 2.01 },
                new Student {Name = "David", Gender = GenderEnum.Male, GradePointAverage = 3.45 },
                new Student {Name = "Avrell", Gender = GenderEnum.Male, GradePointAverage = 0.66 },
                new Student {Name = "Franck", Gender = GenderEnum.Male, GradePointAverage = 1.26 },
                new Student {Name = "Benjamin", Gender = GenderEnum.Male, GradePointAverage = 1.36 },
                new Student {Name = "Chris", Gender = GenderEnum.Male, GradePointAverage = 2.12 },
                new Student {Name = "Ludivine", Gender = GenderEnum.Female, GradePointAverage = 2.21 },
                new Student {Name = "Vanessa", Gender = GenderEnum.Female, GradePointAverage = 2.55 },
                new Student {Name = "Emily", Gender = GenderEnum.Female, GradePointAverage = 3.14 },
                new Student {Name = "Clara", Gender = GenderEnum.Female, GradePointAverage = 3.02 },
                new Student {Name = "Zoe", Gender = GenderEnum.Female, GradePointAverage = 2.40 },
                new Student {Name = "Elodie", Gender = GenderEnum.Female, GradePointAverage = 1.01 },
                new Student {Name = "Terminator", Gender = GenderEnum.Other, GradePointAverage = 4.00 },
            };
            
            Console.WriteLine("Number of student having a GPA over 2.6 : {0}", 
                studentList.Count(x => x.GradePointAverage > 2.6));
            
            Console.WriteLine("Name of student having a GPA over 3 : {0}", 
                string.Join(", ", studentList.Where(x => x.GradePointAverage > 3).Select(x => x.Name)));
            
            Console.WriteLine("Percentage of female student : {0:F3}%", 
                (double)studentList.Count(x => x.Gender == GenderEnum.Female) / studentList.Count * 100);
            
            Console.WriteLine("Ordered name of male student : {0}", 
                string.Join(", ", studentList.Where(x => x.Gender == GenderEnum.Male).Select(x => x.Name).OrderBy(x => x)));
        }
    }
}

