using System;
using System.Collections.Generic;
using Cursos.Entities;

namespace Cursos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Students> courseA = new HashSet<Students>();
            HashSet<Students> courseB = new HashSet<Students>();
            HashSet<Students> courseC = new HashSet<Students>();

            Console.Write("How many students for course A? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int id = int.Parse(Console.ReadLine());
                courseA.Add(new Students(id));
            }

            Console.Write("How many students for course B? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int id = int.Parse(Console.ReadLine());
                courseB.Add(new Students(id));
            }

            Console.Write("How many students for course C? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int id = int.Parse(Console.ReadLine());
                courseC.Add(new Students(id));  
            }

            HashSet<Students> all = new HashSet<Students>(courseA);
            all.UnionWith(courseB);
            all.UnionWith(courseC);
            Console.WriteLine("Total Students: " + all.Count);

        }
    }
}
