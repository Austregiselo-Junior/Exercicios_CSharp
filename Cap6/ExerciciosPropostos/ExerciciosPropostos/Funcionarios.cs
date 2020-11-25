using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosPropostos
{
    class Funcionarios
    {
     
        public int Id { get; set; }
        public string Nome { get; set; }
        public double  Salario { get; set; }

        public Funcionarios(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public double Aumento(ref double  x)
        {
            return Salario += Salario* x / 100;
        }

        public override string ToString()
        {
            return $"{Id}," +
                $"{Nome}," +
                $"{Salario:F2}"; 
        }
    }
}
