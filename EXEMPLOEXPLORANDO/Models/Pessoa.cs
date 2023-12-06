using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXEMPLOEXPLORANDO.Models
{
    public class Pessoa // qualquer um pode instanciar a classe Pessoa pq ela é public
    {
     
        public Pessoa(string nome, string sobrenome)// esse aqui é construtor, todo construtor tem o mesmo nome da classe que pertence
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

           public Pessoa()
        {
            
        }
        private string _nome; //um campo onde será armazenado o nome, encapsulamento.
        private int _idade;// o private só pode acessar dentro da própria classe. 
        
        public string Nome // qualquer um pode acessar essa propriedade pq ela é publica
        { 
            get
            {
                return _nome.ToUpper();//o nome retornara em caixa alta
            } 
            // o Get poderia ser resumido assim
            // get => _nome.ToUpper();

            set
            {
                if (value == "")// trata se o valor do nome passado for vazio
                {
                    throw new ArgumentException("O nome não pode ser vazio.");
                }

                _nome = value;
            }
        } 

        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        public int Idade 
        { 
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero.");
                }
                _idade = value;
            } 
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}