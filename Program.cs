﻿//using fundamentos.Models;

// double a = 4 / (2 + 2);
// Console.WriteLine(a);

string a = "15-";
//int b = 0;
int.TryParse(a, out int b);

Console.WriteLine(b);
Console.WriteLine("Conversão realizada com sucesso!");

// Casting Implícito
//int a = 5;
//double b = a;

//long a = long.MaxValue;
//int b = Convert.ToInt32(a);

//int a = int.MaxValue;
//long b = a;
//Console.WriteLine(b);

/*
int inteiro = 5;
string a = inteiro.ToString();

Console.WriteLine(a);
*/

// Cast - Casting
//int a = Convert.ToInt32(null);
//int a = int.Parse("5");
//Console.WriteLine(a);

// int a = 10;
// int b = 20;

// int c = a + b;

// // c = c + 5;
// //c += 5;
// //c =- 5;
// c *= 5;

// Console.WriteLine(c);

//DateTime dataAtual = DateTime.Now.AddDays(5);
//Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));

/* 
string apresentacao = "Olá, seja bem vindo!";

int quantidade = 1;
Console.WriteLine("Valor da variável quantidade: " + quantidade);

quantidade = 10;
Console.WriteLine("Valor da variável quantidade: " + quantidade);

double altura = 1.80;

decimal preco = 1.80M;

bool condicao = true;

Console.WriteLine(apresentacao);
Console.WriteLine("Valor da variável quantidade: " + quantidade);
Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
Console.WriteLine("Valor da variável preco: " + preco);
Console.WriteLine("Valor da variável condicao: " + condicao);
*/

/* 

//Pessoa pessoa1 = new Pessoa();
//pessoa1.Nome = "Ian";
//pessoa1.Idade = 24;

Pessoa pessoa1 = new Pessoa
{
    Nome = "Ian",
    Idade = 24
};

pessoa1.Apresentar();

*/
