using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemploPOO.Models
{
    public sealed class Professor : Pessoa
    {

        public Professor()
        {

        }
        public Professor(string nome) : base(nome)
        {

        }
        public decimal Salário { get; set; }
        public string Materia { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é  {Nome}, tenho {Idade} anos e leciono {Materia}.");
        }
    }
}