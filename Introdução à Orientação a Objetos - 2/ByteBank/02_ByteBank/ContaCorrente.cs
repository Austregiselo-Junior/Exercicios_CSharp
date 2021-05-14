using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class ContaCorrente
    {
      ////  private Clinte _titular;
      //  private int _agencia;
      //  private int _numero;
        private double _saldo = 100;

        public Clinte Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }

        public static int TotalContasCriadas { get; private set; }

        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;
            TotalContasCriadas++;
        }

        public double Saldo
        {
            get { _saldo = 100; return _saldo; }
            set 
            {
                if (value <0)
                {
                    return;
                }
                _saldo = value; 
            }
        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            this._saldo -= valor;
            return true;
        }

        public bool Trasferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo<valor)
            {
                return false;
            }
            this._saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
            
    }
}
