using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fundamentos.Models
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome}, e tenho {Idade} anos");

            // Exemplo de corte de código
            //Console.WriteLine($"Olá meu nome é " + 
            //"{Nome}, e tenho {Idade} anos");

            // Exemplo de pulo de linha
            //Console.WriteLine($"Olá meu nome é {Nome}, \n e tenho {Idade} anos.");
        }
    }
}
