using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    public delegate bool Callback(int x);
    internal class Exemplo2
    {
        public static IEnumerable<int> Filter(List<int> numbers, Callback callback) //Se um inteiro fizer com que o retorno de chamada retorne true,
                                                                                    //o resultado do Filter()método incluirá esse inteiro:
        {
            foreach (int x in numbers)
            {
                if (callback(x))
                    yield return x;

            }
        }

        public static bool IsOdd(int x) => x % 2 != 0 ? true : false; // retorna truese um número for ímpar, (Tem que ter o mesmo parâmetro que o delegado Callback).
        public static bool IsEven(int x) => x % 2 == 0; // retorna truese um número for par, (Tem que ter o mesmo parâmetro que o delegado Callback)

    }
}
