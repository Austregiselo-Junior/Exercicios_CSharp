using ExercicioResolvido.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace ExercicioResolvido
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            HashSet<LogRecord> set = new HashSet<LogRecord>(); //Usou o HashSet porque a ordem não importa eé mais rápido, diferente do SortedSet, que é rápido mas há uma ordem.

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' '); // Leitura da linha com base o espaço em brabco "' '"
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        set.Add(new LogRecord { Username = name, Instant = instant });
                    }
                    Console.WriteLine("Total users: " + set.Count);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();

            //OBSG: Para esse códogo funcionar é necessário antes criar um arquivo no qual o caminho para ele será o digitado pelo usuário.
        }
    }
}
