using System;

namespace Nota
{
    class Program
    {
        static void Main(string[] args)
        {

            /*

            Criar um programa que leia o valor de três notas escolares de um aluno. 
            Calcular a média aritmética e apresentar na tela a mensagem “Aprovado” 
            se a média obtida for maior ou igual a 7; caso contrário, o programa 
            deve solicitar a nota de exame do aluno e calcular uma nova média aritmética 
            entre a nota do exame e a primeira média aritmética. Se o valor da nova média 
            for maior ou igual a 5, apresentar na tela a mensagem “Aprovado em exame”; caso 
            contrário, apresentar a mensagem “Reprovado”. Informar junto com cada mensagem o 
            valor da média obtida.
           
            */

            double nota1, nota2, nota3, mediaInicial, notaDeExame;

            Console.WriteLine("\n--------- Bem-Vindo(a) a notas escolares ---------\n");

            Console.WriteLine("Digite o valor da primeira nota");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor da segunda nota");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor da terceira nota");
            nota3 = Convert.ToDouble(Console.ReadLine());

            mediaInicial = Math.Round(((nota1 + nota2 + nota3) / 3), 2);

            Console.Write("Sua média é de: {0} pontos.\n", mediaInicial);

            if (mediaInicial >= 7)
            {
                Console.WriteLine("Você foi APROVADO");
            }
            else
            {
                Console.WriteLine("Digite sua nota de exame");
                notaDeExame = Convert.ToDouble(Console.ReadLine());
                mediaInicial = ((mediaInicial + notaDeExame) / 2);
                Console.Write("Sua nova média é de: {0} pontos.\n", mediaInicial);
                if (mediaInicial >= 5)
                {
                    Console.WriteLine("Você foi APROVADO com exame");
                }
                else
                {
                    Console.WriteLine("Você foi REPROVADO");
                }
            }



        }
    }
}
