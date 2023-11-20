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

//### Criando a calculadora na prática:

Calculadora calc = new Calculadora();
 calc.Somar(10,30);
 calc.Dividir(10, 0);
 calc.Dividir(10, 2);
 calc.Multiplicar(20,3);
 calc.Subtrair(35, 5);
 calc.Potencia(10, 2);
 calc.Seno(30);
 calc.Coseno(30);
 calc.Tangente(30);
 calc.RaizQuadrada(9);

 // ### Incremento e Decremento
 int numero = 10;
 Console.WriteLine(numero);

 Console.WriteLine("Incrementando o 10");
 numero++;    // nessa linha será icrementado 1 ao 10 reusultado = 11
 Console.WriteLine(numero);

 numero--;   // nesse linha será decrementado 1 ao 11 resultado = 10
 Console.WriteLine(numero); 
