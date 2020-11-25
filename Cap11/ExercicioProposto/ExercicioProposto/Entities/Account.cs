using System;
using ExercicioProposto.Entities;
using ExercicioProposto.Exeptions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProposto.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Claent { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string claent, double balance, double withdrawLimit)
        {
            Number = number;
            Claent = claent;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance = amount;
        }

        public void Withdraw(double amount)
        {
            if (Balance == 0)
            {
                throw new DomainException("Saldo igual a zero");
            }
            if (amount > WithdrawLimit)
            {
                throw new DomainException("Valor sacado é maior que o limite de saque");
            }
            if (amount > Balance)
            {
                throw new DomainException("Impossível, a conta não pode ficar negativada");
            }
            Balance -= amount; 
        }
    }
}
