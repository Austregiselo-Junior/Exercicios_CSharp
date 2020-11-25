using System;

namespace Exerciciofeito
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DateTime dt = new DateTime(0001, 01, 01, 0, 00, 00);
            Console.WriteLine(dt.ElapsedTime());


            string s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));
            Console.ReadLine();
        }

        //ONJ: No uso de extensões quando o pode ser aproveitar o namespace do objeto e por a estensão no mesmo nameepace.
        //Ex Datetime é do namespace System enão mesmo em outra pasta o método de extensão pode ser posto no namespace System, basta mudaro namespace do método.
    }
}
