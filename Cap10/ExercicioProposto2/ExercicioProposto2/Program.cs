using ExercicioProposto2.Entities;
using System;
using System.Collections.Generic;

namespace ExercicioProposto2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<ContribuicaoGeral> listaCG = new List<ContribuicaoGeral>();

            Console.Write("Quantas pessoas? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Cliente número {i}:");
                Console.Write("O cliente é pessoa física ou jurídica? ");
                char chf = char.Parse(Console.ReadLine());
                if (chf == 'F' || chf == 'f')
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Qual a renda anual: ");
                    double rendaanual = double.Parse(Console.ReadLine());
                    double imposto = 0;
                    Console.Write("O cliente teve gasto do saúde? ");
                    char chfs = char.Parse(Console.ReadLine());
                    if (chfs == 's' || chfs == 'S')
                    {
                        Console.Write("Qual o gasto com saúde?");
                        double gastosaude = double.Parse(Console.ReadLine());

                        if (rendaanual < 20000)
                        {
                            imposto = 0.15;
                            listaCG.Add(new P_Fisica(nome, imposto, rendaanual, gastosaude));
                        }
                        else if (rendaanual >= 20000)
                        {
                            imposto = 0.25;
                            listaCG.Add(new P_Fisica(nome, imposto, rendaanual, gastosaude));
                        }

                    }
                    else
                    {
                        if (rendaanual < 20000)
                        {
                            imposto = 0.15;
                            listaCG.Add(new P_Fisica(nome, imposto, rendaanual));
                        }
                        else if (rendaanual >= 20000)
                        {
                            imposto = 0.25;
                            listaCG.Add(new P_Fisica(nome, imposto, rendaanual));
                        }
                    }

                }
                else
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Qual a renda anual: ");
                    double rendaanual = double.Parse(Console.ReadLine());
                    double imposto = 0.16;
                    Console.Write("Quantos funcionarios existem? ");
                    int nfuncionarios = int.Parse(Console.ReadLine());

                    if (nfuncionarios > 10)
                    {
                        imposto = 0.14;
                        listaCG.Add(new P_Juridica(nome, imposto, rendaanual, nfuncionarios));
                    }
                }

            }

            double total = 0;
            Console.WriteLine("----  Balanço  ----");
            foreach (ContribuicaoGeral i in listaCG)
            {
                double soma = i.Contribuicao();
                Console.WriteLine($"Nome do cliente: {i.Nome}, imposto pago: R${i.Imposto:F2} e contribuição:{i.Contribuicao():F2}");
                total += soma;
            }

            Console.WriteLine();
            Console.WriteLine($"Total: {total:F2}");
            Console.ReadLine();
        }
    }
}
