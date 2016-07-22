using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();
            book.AddGrade(87);
            book.AddGrade(90.98f);
            book.AddGrade(76);

            GradeBook book2 = new GradeBook();
            book2.AddGrade(79);
            book2.AddGrade(78);

            GradeBook book3 = book2;
            book3.AddGrade(65);

            GradeStatistics stats = book.computeStatistics();

            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LowestGrade);
            Console.WriteLine(stats.AverageGrade);
        }
    }
}
