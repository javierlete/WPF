using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SchoolContext ctx = new SchoolContext())
            {
                Student s = ctx.Students.FirstOrDefault();

                Console.WriteLine(s);

                Student student = new Student()
                {
                    StudentName = "Javier",
                    Height = 2.0m,
                    Weight = 70.0f
                };

                ctx.Students.Add(student);
                ctx.SaveChanges();
            }
        }
    }
}
