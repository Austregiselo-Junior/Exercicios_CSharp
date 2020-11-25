namespace ExerciciosPropostos
{
    internal class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;
        public double NotaMinima = 60;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public double Didefenca()
        {
            return NotaMinima - NotaFinal();
        }

    }
}
