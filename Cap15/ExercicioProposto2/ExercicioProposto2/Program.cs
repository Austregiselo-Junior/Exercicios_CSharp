using System;
using System.Collections.Generic;
using System.IO;


namespace ExercicioProposto2
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            Dictionary<string, int> keyValues = new Dictionary<string, int>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!(sr.EndOfStream))
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        int voti = int.Parse(line[1]);

                        if (keyValues.ContainsKey(name))
                        {
                            keyValues[name] += voti; // para acumular os voti dos name que já existem na coleção
                        }
                        else
                        {
                            keyValues[name] = voti; // Se a coleção não tiver o name ele só adiciona
                        }
                        // Como Dictionary não aceita repetições de chave, então é necessário esse if e else para acumular os votos de candidatos reperidos
                    }
                    foreach (var i in keyValues)
                    {
                        Console.WriteLine($"Candidate: {i.Key} - {i.Value}");
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
