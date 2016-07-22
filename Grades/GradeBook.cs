using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeBook
    {
        List<float> Grades;
        public GradeBook()
        {
            Grades = new List<float>();
        }

        public void AddGrade(float grade) {
            Grades.Add(grade);
        }

        public GradeStatistics computeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();
            float sum = 0;
            stats.LowestGrade = Grades.First();
            foreach (float grade in Grades)
            {
                
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum = sum + grade;
            }
                stats.AverageGrade = sum/Grades.Count;
                return stats;
        }
    }
}
