using System;

namespace ExerciciosPropostos
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
            Pessoas P1 = new Pessoas();
            Pessoas P2 = new Pessoas();
            Console.WriteLine("Dados das pessoas");
            Console.WriteLine("Nome: ");
            P1.Nome = Console.ReadLine();
            P2.Nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            P1.Idade = int.Parse(Console.ReadLine());
            P2.Idade = int.Parse(Console.ReadLine());

            if(P1.Idade > P2.Idade )
            {
                Console.WriteLine($"A primeira pessoa {P1.Nome}, é mais velha!");
            }
            else
            {
                Console.WriteLine($"A segunda pessoa {P2.Nome}, é a mais velha");
            }
            Console.ReadLine();
            */

            /*
            Pessoas p1 = new Pessoas();
            Pessoas p2 = new Pessoas();
            Console.WriteLine("Dados do primeiro funcionário");
            p1.Nome = Console.ReadLine();
            p1.Idade = int.Parse(Console.ReadLine());
            p1.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionário");
            p2.Nome = Console.ReadLine();
            p2.Idade = int.Parse(Console.ReadLine());
            p2.Salario = double.Parse(Console.ReadLine());

            double Media = (p1.Salario + p2.Salario) / 2;
            Console.WriteLine($"A média dos salários são: {Media:F2}");
            if(p1.Idade>p2.Idade)
            {
                Console.WriteLine($"O funcionário {p1.Nome} é mais velho!");
            }
            else
            {
                Console.WriteLine($"O funcionário {p2.Nome} é mais velho!");
            }
            */

            /*
            Retangulo ret = new Retangulo();
            Console.WriteLine("Entre com os dados do retângulo!");
            Console.Write("Altura: ");
            ret.Altura = double.Parse(Console.ReadLine());

            Console.Write("Largura: ");
            ret.Largura = double.Parse(Console.ReadLine());

            Console.WriteLine(ret);
            */

            /*
            Funcionaio funcionaio = new Funcionaio();
            Console.WriteLine("Qual os dados do funcionário?");
            Console.Write("Nome: ");
            funcionaio.Nome = Console.ReadLine();

            Console.Write("Salário bruto: ");
            funcionaio.SalarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Imposto: ");
            funcionaio.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine(funcionaio);
            Console.Write("Digite a porcentagem para aumentar o saário: ");
            double aumento = double.Parse(Console.ReadLine());
            funcionaio.AumentarSalario(aumento);

            Console.WriteLine(funcionaio);

    */
            /*
                    Aluno aluno = new Aluno();
                    Console.WriteLine("---- Insira os dados do aluno ----");
                    Console.Write("Nome do aluno: ");
                    aluno.Nome = Console.ReadLine();
                    Console.WriteLine("Digite as notas:");
                    Console.Write("Nota 1:  ");
                    aluno.Nota1 = double.Parse(Console.ReadLine());

                    Console.Write("Nota 2: ");
                    aluno.Nota2 = double.Parse(Console.ReadLine());

                    Console.Write("Nota 3: ");
                    aluno.Nota3 = double.Parse(Console.ReadLine());

                    Console.WriteLine($"A nota final do aluno {aluno.Nome} é igual a {aluno.NotaFinal():F2}");

                    if (aluno.NotaFinal() > aluno.NotaMinima)
                    {
                        Console.WriteLine("O aluno está aprovado!");
                    }
                    else
                    {
                        Console.WriteLine("Alino reprovado!");
                        Console.WriteLine($"Faltão  {aluno.Didefenca():F2}");
                    }
                    */
         
            Console.Write("Qual a cotação do dólar: ");
            double cotacao = double.Parse(Console.ReadLine());

            Console.Write("Quantos dólares você vai comprar? ");
            double quantoa = double.Parse(Console.ReadLine());

            double result = ConversorDeModeda.DolarParaResal(quantoa, cotacao);

            Console.WriteLine($"O valor será {result:F2}");
            Console.ReadLine();





        }
    }
}
