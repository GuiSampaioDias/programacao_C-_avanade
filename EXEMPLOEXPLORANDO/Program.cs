using EXEMPLOEXPLORANDO.Models;

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
