using System;
using System.Collections.Generic;
using System.Text;

namespace exemplo_git
{
    class Pessoa
    {
        public string nome  { get; set; }
        public int idade { get; set; }

        public Pessoa(string nome , int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }
    }
}
