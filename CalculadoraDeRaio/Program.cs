using System;

namespace CalculadoraDeRaio
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            Criar um programa que calcule e apresente na tela o volume
            de uma esfera de raio R, em que R é um dado fornecido pelo 
            usuário. O volume de uma esfera é dado por V = 4/3πR³.

            */

            double raio, volume;

            Console.WriteLine("\n--------- Bem-Vindo(a) a calculadora de volume ---------\n");

            Console.WriteLine("Digite o Raio da esfera");
            raio = Math.Pow(Convert.ToDouble(Console.ReadLine()), 3);

            //V = 4/3 π R³
            volume = Math.Round((4.0 / 3.0) * Math.PI * raio,2);

            Console.WriteLine("\n--------------------------------------------------------\nO volume da sua esfera é de: {0}\n--------------------------------------------------------\n", volume);


        }
    }
}
