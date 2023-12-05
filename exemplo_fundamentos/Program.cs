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


 // ### Introdução ao For:

 int num = 5;
 
 for (int contador = 0; contador <= 10; contador++)
 {
    Console.WriteLine($"{num} x {contador} = {contador * num} ");
 }

 // ### Introdução ao While

 int n = 10;
 int cont = 0;
 while(cont <= 10)
 {
    Console.WriteLine($"{n} x {cont} = {n * cont}");
    cont ++;
 }
 
 // Interrompendo o fluxo de execução

 int nu = 8;
 int con = 0;
 while (true)
 {
    Console.WriteLine($"{nu} x {con} = {nu * con}");
    con ++;
    if (con > 10)
        break;
 }

 // ### Do while

int soma = 0, nume = 0;


 do{
    Console.WriteLine("Digite um número (0 para parar): ");
    nume = Convert.ToInt32(Console.ReadLine());

    soma += nume;

 }while(nume != 0);
 Console.WriteLine($"Total da soma dos números digitados é: {soma}");


 // ### Construindo um menu interativo

 string opcao;
 bool exibirMenu = true;

 while(exibirMenu)
 {
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar Cliente");
    Console.WriteLine("2 - Buscar Cliente");
    Console.WriteLine("3 - Apagar Cliente");
    Console.WriteLine("4 - Encerrar");
 
    opcao = Console.ReadLine();
 
    switch(opcao)
    {
        case "1":
        Console.WriteLine("Cadastro de Cliente");
        break;

        case "2":
        Console.WriteLine("Busca de Cliente");
        break;

        case "3":
        Console.WriteLine("Apagar Cliente");
        break;

        case "4":
        Console.WriteLine("Encerrar");
        //Environment.Exit(0); // essa linha encerra o nosso programa
        exibirMenu = false; // essa variavel esta dentro do while como condição
        break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }
 }Console.WriteLine("O programa se encerrou!!");

 // ### Array

 int[] arrayInteiros = new int[3]; // esse array só aceita 3 valores dentro dele

 arrayInteiros[0] = 72;
 arrayInteiros[1] = 62;
 arrayInteiros[2] = 50; // se colocasse mais um valor na posição [3]daria erro no programa por que esse array so cabe 3 valores que foi pré definido na criação dele.
 
 // percorrendo o Array com FOR
 Console.WriteLine("Percorrendo o Array com o FOR");
 for (int c = 0; c < arrayInteiros.Length; c ++)
 {
    Console.WriteLine($"Posição N° {c} - {arrayInteiros[c]}");
 }

// Dobrando a capacidade desse Array
Console.WriteLine("Capacidade do Array dobrada");
Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

//percorrendo o Array com Foreach
Console.WriteLine("Percorrendo o Array com o FOREACH");
 foreach(int va in arrayInteiros)
 {
    Console.WriteLine(va);
 }


int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");
listaString.Add("RJ");

foreach(string estado in listaString)
{
    Console.WriteLine($"Estado - {estado}");
}
