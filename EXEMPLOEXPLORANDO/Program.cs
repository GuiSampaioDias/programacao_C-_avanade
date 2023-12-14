using EXEMPLOEXPLORANDO.Models;
using System.Globalization; // essa importação foi feita para alterar a localização do código

Pessoa p1 = new Pessoa();
p1.Nome = "Gui"; // se o nome for vazio entrará em excessão e uma string será mostrada no console
p1.Sobrenome = "Sampaio";
p1.Idade = 37;// se a idade for menor do que zero uma string será mostrada no console.
p1.Apresentar();


Pessoa p2 = new Pessoa();
p2.Nome = "Guilherme";
p2.Sobrenome = "Sampaio Dias";

Pessoa p3 = new Pessoa("Pedro",  "Henrique");


Pessoa p4 = new Pessoa(nome: "João", sobrenome: "Martins");


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.AdicionarAluno(p3);
cursoDeIngles.AdicionarAluno(p4);

cursoDeIngles.ListarAlunos();

// ### Manipulando valores Monetários

decimal valorMonetario = 82.40M;

Console.WriteLine($"{valorMonetario:C}"); //  <:C> determina que estamos formatando o valor em uma moeda, nesse caso a cultura do sistema está configurada para o Brasil e por esse motivo o valor vai sair em padrão de reais - R$ 82,40

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");//depois de importar a biblioteca na linha dois do código com essa linha do código a formatação da moeda americana será exibida por causa do "en-US".

decimal novoValorMonetario = 1223.80M;
Console.WriteLine($"{novoValorMonetario:C}");

// Se no caso de precisarmos alterar localização da cultura mesmo o sistema travado em outra cultura pode ser feito como no exemplo abaixo.

decimal valorReal = 235341.99M;
Console.WriteLine(valorReal.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));

// ### Para definir quantas casas decimais terão os valores que aparecerao no  cosole.

Console.WriteLine(valorReal.ToString("C4")); // neste caso o valor será representado com 4 casas decimais.resultado - $235,341.9900 . Se  usacemos o N no lugar do C ("N4") ficaria sem o $ na frente. ficaria 235,341.9900

//### Representando a porcentagem

double porcentagem = .3352;

Console.WriteLine(porcentagem.ToString("P")); // nesse caso o valor que aparecerá no console é -  33.520%

int numero =  123456;
Console.WriteLine(numero.ToString("##-##-##")); // resultado 12-34-56

// ### Formatando o tipo DateTime

DateTime data = DateTime.Now; 

Console.WriteLine(data);
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));// transformando em uma string podemos formatar a saida da forma que quisermos

Console.WriteLine(data.ToShortDateString());// aqui só exibe a data
Console.WriteLine(data.ToShortTimeString());// aqui só exibe o horário

// Se caso precisamos ajustar a data e o horario sem usar o valor que está ligado ao sistema da máquina. Lembrando que é necessário colocar uma data válida se não o programa dará erro.

DateTime da = DateTime.Parse("04/15/2022 14:00");

Console.WriteLine(da);

// ### DateTime com TryParse

string dataString = "2023-13-17 13:00";

bool sucesso = DateTime.TryParseExact(dataString, "yyy-MM-dd HH:mm", 
                       CultureInfo.InvariantCulture,
                       DateTimeStyles.None, out DateTime novaData);
if (sucesso)
{
    Console.WriteLine($"Conversão com sucesso Data: {novaData}");
}
else
{
    Console.WriteLine($"{novaData} não é uma data válida");
}