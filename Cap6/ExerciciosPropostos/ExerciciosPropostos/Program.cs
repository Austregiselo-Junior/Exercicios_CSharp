using System;

namespace ExerciciosPropostos
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            // Vetores 
            /*
            Pensionato[] vect = new Pensionato[10];
            Console.WriteLine($"Olá temos {vect.Length} quartos vagos!");
            Console.Write("Quantos quartos deseja alugar? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"----- Aluguel {i} -----");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine());
                vect[quarto] = new Pensionato { Nome = nome, Email = email, Preco = preco };
            }
            double sun = 0;
            for (int i = 1; i <= n; i++)
            {
                sun += vect[i].Preco;
            }

            Console.WriteLine("---- Quartos ocupados ----");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Quarto: {vect[i].Quarto}, Nome: {vect[i].Nome}, E-mail: {vect[i].Email} e Preço: {vect[i].Preco}");
            }
            Console.Write($"Valor total: {sun:F2}");
            */


            // Listas
            /*
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());
            List<Funcionarios> List = new List<Funcionarios>(n);

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"---- Employee {i} ----");
                Console.Write("ID: ");
                int Id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string Nome = Console.ReadLine();
                Console.Write("Salário: ");
                double Salario = double.Parse(Console.ReadLine());

                List.Add(new Funcionarios(Id, Nome, Salario));
                Console.WriteLine();
            }



            Console.Write("Enter the employee id that will have salary increase: ");
            int IdAumento = int.Parse(Console.ReadLine());
            Funcionarios emp = List.Find(x => x.Id == IdAumento); // Encontrar o ID "IdAumento" na lista
            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double X = double.Parse(Console.ReadLine());
                emp.Aumento(ref X); // Aumento feito a variável encontrada em "emp"
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }
            
            Console.WriteLine("---- Updated list of employess ----");
            foreach (var item in List)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
            */

            //  Matrizes

            Console.WriteLine("Entre com as dimenções:");
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());

            int[,] mat = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                string[] vect = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(j.ToString());
                }
            }

            Console.WriteLine($"A matriz é: {mat.Length}");
            Console.Write($"Escolha um núme da matriz! ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (mat[i, j] == x)
                    {
                        Console.WriteLine($"Posição {i}, {j}:");
                        if (j > 0)
                        {
                            Console.WriteLine($"Left: {mat[i, j - 1]}");
                        }
                        if (i > 0)
                        {
                            Console.WriteLine($"Up: {mat[i - 1, j]}");
                        }
                        if (j < N - 1)
                        {
                            Console.WriteLine($"Right: {mat[i, j + 1]}");
                        }
                        if (i < M - 1)
                        {
                            Console.WriteLine($"Down: {mat[i + 1, j]}");
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
