using System;
using System.Text;

namespace ExercicioProposto.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
               
        public Client(string nome, string email, DateTime birthDate)
        {
            Name = nome;
            Email = email;
            this.BirthDate = birthDate;
        }
             
    }
}
