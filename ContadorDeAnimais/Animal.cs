using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais
{
    class Animal
    {

        public Animal(string nome, string tipo)
        {
            this.nome = nome;
            this.tipo = tipo;
        }

        private string nome;
        private string tipo;

        public string GetNome()
        {
            return this.nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string GetTipo()
        {
            return this.tipo;
        }

        public void SetTipo(string tipo)
        {
            this.tipo = tipo;
        }


        public void AdicionarAnimais()
        {
           


        }
    }
}
