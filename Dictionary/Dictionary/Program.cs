using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("// ---------------- Criando dicionarios --------------------//");

            var state = new Dictionary<string, string>();
            state.Add("PB", "Paraiba");
            state.Add("CA", "California");
            state.Add("NY", "New York");

            Dictionary<int, string> Order = new Dictionary<int, string>()
            {
                {1, "Amburger com batata"  },
                {2, "Amburger duplo"  },
                {3, "Batata e cerveja"  }
            };

            Console.WriteLine("// ---------------- Recuperando um elemento por sua key --------------------//");
            Console.WriteLine($"Pedido 1: {Order[1]}");
            Console.WriteLine($"Pedido 3: {Order[3]}");
            Console.ReadLine();

            Console.WriteLine("// ---------------- Para saber se a chave existe podemos usar o ContainKeys() ou TryGetValue() --------------------//");
            if (state.ContainsKey("PB"))
            {
                Console.WriteLine($"Estado PB: {state["PB"]}");
            }
            else Console.WriteLine("No state with the abbreviation PB exists");
            Console.ReadLine();

            if (Order.TryGetValue(3, out string order))
            {
                Console.WriteLine($"Pedido 3: {Order[3]}");
            }
            else Console.WriteLine("No state with the abbreviation PB exists");
            Console.ReadLine();

            Console.WriteLine("// ---------------- Iterando um dicionário, as chaves e os valores de um dicionário  --------------------//");
            Console.WriteLine("Iterando um dicionário");
            foreach (var item in state) { Console.WriteLine(item); }
            Console.ReadLine();

            Console.WriteLine("Iterando as chaves de um dicionário");
            foreach (var item in state.Keys) { Console.WriteLine(item); }
            Console.ReadLine();

            Console.WriteLine("Iterando os valores de um dicionário");
            foreach (var item in state.Values) { Console.WriteLine(item); }
            Console.ReadLine();

            Console.WriteLine("// ---------------- UIsando um dicionário ao em vez de um encadeamento de ifs  --------------------//");
            GetDayofWeek(5);
            Console.ReadLine();
        }

        private static void GetDayofWeek(int dia)
        {
            var days = new Dictionary<int, string>()
            {
                {1, "sunday" },
                {2, "Monday" },
                {3, "Tuesday" },
                {4, "Wednesday" },
                {5, "Thursday" },
                {6, "Fryday" },
                {7, "Saturday" },
            };

            if (days.TryGetValue(dia, out string day))
            {
                 Console.WriteLine($"Dia valido: {day}.");
            }
            else Console.WriteLine("Dia inválido.");



        }
    }
}
