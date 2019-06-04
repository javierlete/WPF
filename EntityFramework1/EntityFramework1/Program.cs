﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework1
{
    class Program
    {
        static void Main()
        {
            using (SchoolContext ctx = new SchoolContext())
            {
                ctx.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);

                var students = from s in ctx.Students
                               where s.StudentID < 3
                               select s;

                students = ctx.Students.Where(s => s.StudentID < 5);

                students = students.Where(s => s.StudentName.Contains("Lete"));

                foreach (var s in students)
                {
                    Console.WriteLine(s.StudentID);
                }
            }
        }

        static void MainActualizaciones(string[] args)
        {
            using (SchoolContext ctx = new SchoolContext())
            {
                Student s = ctx.Students.FirstOrDefault();

                Console.WriteLine(ctx.Entry(s).State);

                s.StudentName = "Javier Lete";

                Console.WriteLine(ctx.Entry(s).State);

                Console.WriteLine(s);

                ctx.Students.Remove(s);

                Console.WriteLine(ctx.Entry(s).State);


                Student student = new Student()
                {
                    StudentName = "Javier",
                    Height = 2.0m,
                    Weight = 70.0f
                };

                Console.WriteLine(ctx.Entry(student).State);
                ctx.Students.Add(student);
                Console.WriteLine(ctx.Entry(student).State);

                ctx.SaveChanges();
            }
        }
    }
}
