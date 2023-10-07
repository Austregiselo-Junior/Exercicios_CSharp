using ClasseAbstrataXInterface.ClasseAbstrata;
using ClasseAbstrataXInterface.Interface;
using Microsoft.SqlServer.Server;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstrataXInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("// ------------------- Classe Abstrata ------------------------//");

            //Neste exemplo, a Shape classe é uma classe abstrata que define dois métodos abstratos GetAreae GetPerimeter.Qualquer
            //classe herdada da classe Shape precisa implementar esses métodos.
            //A Shapeclasse também possui um método concreto Displayque exibe a área e o perímetro de uma forma.
            //Todas as subclasses da Shapeclasse compartilharão o mesmo Displaymétodo.
            //As classes Rectangle e Circle estendem a classe Shape.Ambas as classes compartilham a mesma implementação de Displaymétodo,
            //mas cada uma fornece sua própria implementação de métodos GetAreae GetPerimeter.

            List<Shape> shape = new List<Shape>() { new Rectangle(5, 10), new Circle(3) };

            foreach (var item in shape)
            {
                item.Display();
            }
            Console.ReadLine();

            Console.WriteLine("// ------------------- Interface ------------------------//");

            //Neste exemplo, definimos a ILoggerinterface que possui um único método Log. O Logmétodo recebe uma string que representa a mensagem a ser registrada.
            //As classes ConsoleLoggere FileLoggerimplementam a ILoggerinterface e fornecem suas próprias implementações do Logmétodo.
            //No Mainmétodo, criamos uma instância ConsoleLoggerou FileLoggercom base no argumento da linha de comando.
            //Se o argumento for "file", criamos um FileLoggerobjeto.Caso contrário, criamos um ConsoleLoggerobjeto.
            //Independentemente se FileLoggerou ConsoleLoggerinstância foi criada, chamamos o Logmétodo para registrar algumas mensagens
            //Como as classes FileLoggere ConsoleLoggerimplementam a mesma interface, podemos alternar facilmente entre elas em tempo de execução.

            ILogger logger;

            if (args.Length > 0 && args[0] == "file")
            {
                logger = new FileLogger("log.txt");
                logger.log("Starting application...");
            }
            else 
            { 
                logger = new ConsoleLogger();
                logger.log("Application stopped.");
            }
            Console.ReadLine();

        }
    }
}
