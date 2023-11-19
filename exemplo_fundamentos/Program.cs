using exemplo_fundamentos.Models;
// ###Class na Prática

Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Guileherme";
pessoa1.Idade = 37;
pessoa1.Apresentar();


//### Operador Condicional na Prática
int quantidadeEmEstoque = 10;
int quantidadeCompra = 4;

if (quantidadeEmEstoque >= quantidadeCompra)
{
    Console.WriteLine("Venda realizada");
}
else
{
    Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque");
}

// ### Operador Or na prática

bool ehMaiorDeIdade = true;
bool possuiAutorizacaoDoResponsavel = false;

if  (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
{
    Console.WriteLine("Entrada liberada.");
}
else
{
    Console.WriteLine("Entrada não liberada.");
}


// ### Operador AND na prática

bool possuiPresencaMinima = true;
double media = 7.5;

if (possuiPresencaMinima && media >= 7)
{
    Console.WriteLine("Aprovado!");
}
else
{
    Console.WriteLine("Reprovado!");
}


// ### Operador NOT na prática.
bool choveu = false;
bool estaTarde = false;

if (!choveu && !estaTarde)
{
    Console.WriteLine("Vou pedalar!");
}
else
{
    Console.WriteLine("Vou pedalar um ourto dia");
}