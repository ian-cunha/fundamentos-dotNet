﻿using fundamentos.dotNet.Models;

//Calculadora calc = new Calculadora();
Calculadora calc = new();

//calc.Somar(10, 30);
//calc.Subtrair(10, 50);
//calc.Multiplicar(15, 45);
//calc.Dividir(2, 2);
//calc.Potencia(3, 3);
//calc.Seno(30);
//calc.Coseno(30);
//calc.Tangente(30);
calc.RaizQuadrada(9);

/*
int numeroIncremento = 10;

Console.WriteLine(numeroIncremento);
Console.WriteLine("Incrementando o 10");
//numeroIncremento += 1;
numeroIncremento++;
Console.WriteLine(numeroIncremento);

int numeroDecremento = 20;

Console.WriteLine(numeroDecremento);
Console.WriteLine("Decrementando o 20");
//numeroIncremento -= 1;
numeroDecremento--;
Console.WriteLine(numeroDecremento);
*/

/*
// Negação !
bool choveu = false;
bool estaTarde = false;

if (!choveu && !estaTarde)
{
    Console.WriteLine("Vou pedalar.");
}
else
{
    Console.WriteLine("Vou pedalar outro dia.");
}
*/

/*
// AND &&
bool possuiPresencaMinima = true;
double media = 8.5;

if (possuiPresencaMinima && media >= 7)
{
    Console.WriteLine("Aprovado!");
}
else
{
    Console.WriteLine("Reprovado!");
}
*/

/*
// OR ||
bool ehMaiorDeIdade = false;
bool possuiAutorizacaoDoResponsavel = true;

if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
{
    Console.WriteLine("Entrada liberada");
}
else
{
    Console.WriteLine("Entrada não foi liberada");
}
*/

// Switch Case
/*
Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;
    default:
        Console.Write("Não é uma vogal");
        break;
}
*/

/*
if (letra == "a" ||
    letra == "e" ||
    letra == "i" ||
    letra == "o" ||
    letra == "u")
{
    Console.WriteLine("Vogal");
}
else
{
    Console.WriteLine("Não é uma Vogal");
}
*/


/*
if (letra == "a")
{
    Console.WriteLine("Vogal");
}
else if (letra == "e")
{
    Console.WriteLine("Vogal");
}
else if (letra == "i")
{
    Console.WriteLine("Vogal");
}
else if (letra == "o")
{
    Console.WriteLine("Vogal");
}
else if (letra == "u")
{
    Console.WriteLine("Vogal");
}
else
{
    Console.WriteLine("Não é uma vogal");
}
*/

/*
int quantidadeEmEstoque = 3;
int quantidadeCompra = 0;
bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

if (quantidadeCompra == 0)
{
    Console.WriteLine("Venda inválida");
}
else if (possivelVenda)
{
    Console.WriteLine("Venda realizada.");
}
else
{
    Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque.");
}
*/


// double a = 4 / (2 + 2);
// Console.WriteLine(a);

//string a = "15-";
//int b = 0;
//int.TryParse(a, out int b);

//Console.WriteLine(b);
//Console.WriteLine("Conversão realizada com sucesso!");

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
