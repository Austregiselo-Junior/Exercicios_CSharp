using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_SubstituicaoLiskov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando carro");
            var car = new Carro();
            TesteDriver(car);
            Console.ReadLine();

            Console.WriteLine("Testando onibus");
            var bus = new Onibus();
            TesteDriver(bus);
            Console.ReadLine();


            Console.WriteLine("Testando Veiculo");
            var veiculo = new Veiculo();
            TesteDriver(veiculo); // Aqui provamos a substituição que dá certo por conta que TesteDriver recebe veiculo e carro e onibus herdam de veiculo.
            Console.ReadLine();

        }

        private static void TesteDriver(Veiculo veiculo)
        {
            if (veiculo is Carro)
            {
                var car = new Carro();
                car.DriveCarro();
            }
            else if (veiculo is Onibus)
            {
                var bus = new Onibus();
                bus.DriveOnibus();
            }
            else veiculo.Drive();
        }

    }
}
