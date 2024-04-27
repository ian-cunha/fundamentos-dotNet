using fundamentos.Models;

Pessoa pessoa1 = new Pessoa
{
    Nome = "Ian",
    Idade = 24
};

/* 
Modelo antigo:

Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "Ian";
pessoa1.Idade = 24;
*/

pessoa1.Apresentar();
