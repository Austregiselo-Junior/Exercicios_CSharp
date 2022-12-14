using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ExtratorValorDeArgumentosURL
    {
        private readonly string _argumentos;
        public string URL { get; }

        public ExtratorValorDeArgumentosURL(string url)
        {
            if (String.IsNullOrEmpty(url))
            {
                throw new ArgumentException("O argumento url não pode ser nulo ou vazio", nameof(url));
            }

            URL = url;
            int indiceInterrogacao = url.IndexOf('?');
            _argumentos = url.Substring(indiceInterrogacao + 1);
        }

        public string GetValor(string nomeParametro)
        {
            nomeParametro = nomeParametro.ToUpper();
            string argumentoCaixaAlta = _argumentos.ToUpper();

            string palavra = nomeParametro + "=";
            int indice = argumentoCaixaAlta.IndexOf(palavra);

            string resultado = _argumentos.Substring(indice + palavra.Length);
            int indiceEComercial = resultado.IndexOf('&');

            if (indiceEComercial == -1)
            {
                return resultado;
            }

            return resultado.Remove(indiceEComercial);
          
        }
    }
}
