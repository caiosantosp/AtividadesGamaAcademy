using System;

namespace Animais
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            
            Crie um algoritmo/programa no qual o usuário deverá informar o nome e o 
            tipo de cinco animais de estimação. O programa deverá exibir na tela para 
            o usuário quantos cachorros, gatos e peixes foram informados.
            Regras que deverão ser seguidas para a implementação do algoritmo:

            * Os únicos tipos de animais válidos são cachorro, gato e peixe.
            * Caso seja informado um tipo diferente, o programa deverá definir o tipo do animal como peixe.
            * É obrigatório criar uma classe para representar o animal.
            * A classe deverá possuir dois dados privados (propriedades) para representar as características do animal.
            * A classe deverá possuir métodos de acesso para permitir que o usuário armazene/leia os dados dos dois dados privados (propriedades).

            */

            Console.WriteLine("\n--------- Bem-Vindo(a) a contador de animais ---------\n");


            Animal[] listaDeAnimais = new Animal[5];
            string nome, tipo;
            int numGato = 0;
            int numPeixe = 0;
            int numCachorro = 0;

            for (int i = 0; i < listaDeAnimais.Length; i++)
            {
                // Console.WriteLine("Digite o nome do Animal");
                nome = "gggg";

                Console.WriteLine("Digite o tipo do Animal");
                tipo = Console.ReadLine().ToLower();

                listaDeAnimais[i] = new Animal(nome, tipo);

                if (listaDeAnimais[i].GetTipo().Equals("gato"))
                {
                    numGato += 1;
                }
                if (listaDeAnimais[i].GetTipo().Equals("cachorro"))
                {
                    numCachorro += 1;
                }
                if (listaDeAnimais[i].GetTipo() != "gato" && listaDeAnimais[i].GetTipo() != "cachorro")
                {
                    numPeixe += 1;
                }

            }

            Console.WriteLine("\n---------------------------\nVocê tem:\n{0} Peixes.\n{1} Gatos.\n{2} Cachorros.\n---------------------------\n", numPeixe,numGato,numCachorro);
        }
    }
}
