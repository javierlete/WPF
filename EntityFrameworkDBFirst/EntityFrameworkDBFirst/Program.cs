using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDBFirst
{
    class Program
    {
        static void Main()
        {
            using (ContosoUniversityMigrationsEntities ctx = new ContosoUniversityMigrationsEntities())
            {
                ctx.Database.Log = s => Console.WriteLine(s);

                foreach (Department d in ctx.Departments.Include(d => d.Courses).Include(d => d.Person))
                {
                    //ctx.Entry(d).Reference(dpto => dpto.Person).Load();
                    //ctx.Entry(d).Collection(dpto => dpto.Courses).Load();

                    Console.WriteLine(d.Name);
                    Console.WriteLine(d.Person.FirstName);

                    foreach(Course c in d.Courses)
                    {
                        Console.WriteLine($"\t{c.Title}");
                    }
                }
            }
        }

        static void MainSchool(string[] args)
        {
            using (SchoolEntities ctx = new SchoolEntities())
            {
                foreach (Estudiante estudiante in ctx.Estudiantes)
                {
                    Console.WriteLine(estudiante);
                }
            }
        }
    }
}
