using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // ----------------------- Exemplo 1 ------------------------//
            Console.WriteLine("// ----------------------- Exemplo 1 ------------------------//");
            //Para chamar o SayHi() método por meio do Greetingdelegado, você cria uma instância do Greetingdelegado com o SayHi método
            //como argumento e chama o Invoke()método da instância do delegado assim:

            Exemplo1.Greeting greeting = new Exemplo1.Greeting(Exemplo1.SayHi); //Nesta sintaxe, o greetingé uma instância do Greetingtipo delegado.
                                                                                //O greetingdelegado contém uma referência ao SayHi()método.Internamente,
                                                                                //o greetingdelegado mantém uma lista de invocação que possui uma referência ao SayHi() método.


            greeting?.Invoke("John"); // Comn o Invoke(), C# chamará o SayHi()método com o mesmo argumento.


            Exemplo1.Greeting greetingSemInvoke = Exemplo1.SayHi;// Mesma coisa que a chamada anterior.
            greetingSemInvoke("John sem Invoke()");

            Console.ReadLine();

            // ----------------------- Exemplo 2 ------------------------//
            Console.WriteLine("// ----------------------- Exemplo 2 ------------------------//");
            var numbers = new List<int> { 1, 2, 3, 4, 5 };

            var evenNumbers = Exemplo2.Filter(numbers, Exemplo2.IsEven);

            Console.WriteLine("Even numbers:");
            foreach (var number in evenNumbers)
            {
                Console.WriteLine($"{number}");
            }

            var oddNumbers = Exemplo2.Filter(numbers, Exemplo2.IsOdd);

            Console.WriteLine("Odd numbers:");
            foreach (var number in oddNumbers)
            {
                Console.WriteLine($"{number}");
            }
            Console.ReadLine();

            // Ao usar um delegado como retorno de chamada, você pode passar um método como argumento para outro método.Neste exemplo,
            // o Filter()método é muito dinâmico e pode aceitar qualquer método para filtrar a lista de inteiros.
            // Nesse caso o Filter contém a chamada do tipo delegado e vc passa o algum método que tem o mesmo parãmetro


            // ----------------------- Exemplo 3 ------------------------//

            //  Um delegago pode ter vários métodos a serem chamados, para adicionar ou remover usamos o += e -=

            Console.WriteLine("// ----------------------- Exemplo 3 ------------------------//");
            Greeting greetingComMaisdeumMétodo = Exemplo3.SayHi;
            greetingComMaisdeumMétodo += Exemplo3.SayBye;
            greetingComMaisdeumMétodo += Exemplo3.Say;
            greetingComMaisdeumMétodo -= Exemplo3.SayHi;
            greetingComMaisdeumMétodo?.Invoke("John");
            Console.ReadLine();
        }


    }

}
