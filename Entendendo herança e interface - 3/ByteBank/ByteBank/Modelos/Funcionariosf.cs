using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionariosf
    {
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }
        public static int TotaldeFuncionarios { get; private set; }

        public Funcionariosf(string cpf, double salario)
        {
            TotaldeFuncionarios++;
            CPF = cpf;
            Salario = salario;
        }

        public abstract double GetBonificacao();


        public abstract void AumentarSalario();
       
    }
}
