using System;
namespace ExerciciosPropostos
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return 2 * Largura + 2 * Altura;
        }

        public double Diagonal()
        {
            return Math.Sqrt((Math.Pow(Altura,2)) + (Math.Pow(Largura,2)));
        }

        public override string ToString()
        {
            return $"Os dados são: Altura = {Area():F2}," +
                $" perímetro = {Perimetro():F2}" +
                $" e a diagonal é {Diagonal():F2}"; 
        }
    }
}
