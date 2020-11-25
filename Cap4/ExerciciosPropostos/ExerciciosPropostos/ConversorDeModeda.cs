namespace ExerciciosPropostos
{
    internal class ConversorDeModeda
    {
        private static double IOF = 0.6;
       
        public static double DolarParaResal(double quantia, double cotacao)
        {
            double Total = quantia * cotacao;
            return Total + Total * IOF / 100; ;
        }


    }
}
