using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaInterno
{
    class SistemaInterno
    {
        public bool Logar (IAutenticavel funcionario, string senha)
        {
            bool usuarioAutenticadp = funcionario.Autenticar(senha);

            if (usuarioAutenticadp)
            {
                Console.WriteLine("Bem-vindo ao sistema!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
                return false;
            }
        }
    }
}
