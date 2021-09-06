using System;

namespace Efrei_IntroductionToCSharp.Ressources
{
    public class Grade
    {
        public int GradeOn100 { get; set; }

        public Grade(int grade)
        {
            if (grade >= 0 && grade <= 100)
                GradeOn100 = grade;
            else
                throw new ArgumentException("Incorrect grade");
        }
    }
}