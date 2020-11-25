using System;
using System.Collections.Generic;

namespace ExercicioProposto
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            //OBS Coleções não trabalha com valores iguais

            HashSet<int> CourseA = new HashSet<int>();
            HashSet<int> CourseB = new HashSet<int>();
            HashSet<int> CourseC = new HashSet<int>();

            Console.Write("How many studants dor course A? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                CourseA.Add(cod);
            }


            Console.Write("How many studants dor course B? ");
             n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                CourseB.Add(cod);
            }


            Console.Write("How many studants dor course C? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                CourseC.Add(cod);
            }

            HashSet<int> all = new HashSet<int>();
            all.UnionWith(CourseA);
            all.UnionWith(CourseB);
            all.UnionWith(CourseC);
            Console.WriteLine("Total students: "+ all.Count);
            Console.ReadLine();





        }
    }
}
