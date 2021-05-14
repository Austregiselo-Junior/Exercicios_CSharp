using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
          ContaCorrente contaDaGabriela =  new ContaCorrente(); //Intancia da classe "ContaCorrente"

            contaDaGabriela.Titular = "Isabele";
            contaDaGabriela.Agencia = 847;
            contaDaGabriela.numero = 8476270;
           

          
            Console.ReadLine();
        }
    }
}
