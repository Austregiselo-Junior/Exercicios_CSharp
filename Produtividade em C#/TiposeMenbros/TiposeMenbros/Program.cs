using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposeMenbros
{
    internal class Program
    {
        // Usanso espressão lambda em propriedade calculável
        public int Qta { get; set; }
        public int Preco { get; set; }
        public int Total => Qta * Preco; // retorna o resultado do calculo.

        static void Main(string[] args)
        {
            // Tipos anuláveis
            TiposAnulaveis();
            Console.WriteLine("------------------------------------");
            Console.ReadLine();

            // Iterando um ENUN
            IterandoumENUM();
            Console.WriteLine("------------------------------------");
            Console.ReadLine();

            // Inicializando objetos ou coleções 
            InicializandoObjeto();
            InicializandoColecao();
            Console.WriteLine("------------------------------------");
            Console.ReadLine();

            // Utilizando parâmetros opcionais e nomeados
            UtilizandoParametrosOpcionaiseNomeados(sexo: 'M', nome: "Astro");
            Console.WriteLine("------------------------------------");
            Console.ReadLine();

            // Utilizando o tipo dynamic para retornar objetos diferentes
            Console.WriteLine("passando objeto tipo pessoa:");
            Console.WriteLine(UtilizandooTipoDynamicparaRetornarObjetosDiferentes( new { GetObjetoPessoa = new Pessoa() }));

            Console.WriteLine("passando objeto tipo autor:");
            Console.WriteLine(UtilizandooTipoDynamicparaRetornarObjetosDiferentes("autor"));

            Console.WriteLine("passando objeto tipo livro:");
            Console.WriteLine(UtilizandooTipoDynamicparaRetornarObjetosDiferentes("livro"));
            Console.WriteLine("------------------------------------");
            Console.ReadLine();
        }

        /// <summary>
        /// Com o dynamic um método pode retornar vários tipos de objetos.
        /// </summary>
        private static dynamic UtilizandooTipoDynamicparaRetornarObjetosDiferentes(object obj)
        {
           
            switch (obj?.GetType())
            {
                case obj.GetObjetoPessoa != null:
                    var pessoa = new Pessoa() { Nome = "Austregselo", Idade = 32, Sexo = "M" };
                    return $"Passando {pessoa} como objeto temos: {pessoa.Nome}, {pessoa.Idade} e {pessoa.Sexo}";

                case "autor":
                    var autor = new Autor() { Nome = "Austregiselo Junior", Sexo = "M", Idade = 32, Email = "dededed@.com" };
                    return $"Passando {autor} como objeto temos: {autor.Nome}, {autor.Idade}, {autor.Sexo} e {autor.Email}";

                case "livro":
                    var livro = new Livro() { Titulo = "Agora vai!", Ano = 2023, Edicao = "sedunda edição" };
                    return $"Passando {livro} como objeto temos: {livro.Titulo}, {livro.Ano} e {livro.Edicao} ";
                default:
                    return $"O parâmetro {obj}, não foi passado corretamente!";

            }
        }

        /// <summary>
        /// Com o usu de parâmetros nomeados podemos misturar as ordens or parâmetros passados na chamada do método.
        /// E mesmo ele não sendo obrigatórios podemos misturalo.
        /// </summary>
        private static void UtilizandoParametrosOpcionaiseNomeados(string nome, int idade = 32, char sexo = 'M')
        {
            Console.WriteLine($@"Nome: {nome}
Idade: {idade} e sexo: {sexo}");
        }

        private static void InicializandoColecao()
        {
            var pessoa = new List<Pessoa> { new Pessoa() { Nome = "Austregiselo como lista", Idade = 32 } };
        }

        private static void InicializandoObjeto()
        {
            var pessoa = new Pessoa() { Nome = "Austregiselo", Idade = 32 };
            Console.WriteLine($@"Nome: {pessoa.Nome}
Idade: {pessoa.Idade}");
        }

        private static void TiposAnulaveis()
        {
            int? classificacao = null; // Declaração de tipo anulável
            int posicao = 0;

            if (classificacao is int)
                posicao = classificacao.Value;

            Console.WriteLine($"Classificação: {classificacao}");
            Console.WriteLine($"Posição: {posicao}");
        }

        // Exemplo de construtor com um parâmetro: 
        // Public Pessoa(string nome) => Nome = nome

        // Propriedade somento leitura:
        // public int MyProperty { get; }

        public static void IterandoumENUM()
        {
            foreach (var item in Enum.GetNames(typeof(Estacao)))
            {
                Console.WriteLine(item);
            }
        }
    }

    public enum Estacao
    {
        Primavera,
        Verao,
        Outono,
        Inverno
    }

    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }
    }

    public class Autor : Pessoa { public string Email { get; set; } }

    class Livro
    {
        public string Titulo { get; set; }
        public string Edicao { get; set; }
        public int Ano { get; set; }
    }


}
