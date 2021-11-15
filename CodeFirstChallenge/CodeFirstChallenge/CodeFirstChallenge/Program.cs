using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var studentCtx = new StudentContext())
            {
                var student = new Student() { StudentId = 0, StudentFName = "Ryan", StudentLName = "Spears", StudentGrade = 12 };

                studentCtx.students.Add(student);
                studentCtx.SaveChanges();
            }
        }
    }
}
