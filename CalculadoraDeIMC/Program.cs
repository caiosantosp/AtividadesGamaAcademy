using System;

namespace CalculadoraDeIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  
        ------ DESCRIÇÃO DA ATIVIDADE ------

        Criar um programa que leia o peso e a altura de uma pessoa, 
        calcule o seu IMC (Índice de Massa Corporal), e apresente na
        tela uma mensagem informando se a pessoa está ou não no seu 
        peso ideal, de acordo com a tabela abaixo. A fórmula para 
        calcular o IMC é: IMC = peso / altura².

        ---------------
        IMC < 20
        Abaixo do peso
        ---------------
        20 <= IMC < 25 
        Peso Ideal
        ---------------
        IMC >= 25
        Acima do peso
        ---------------

        */
            double peso, altura, imc;

            Console.WriteLine("\n--------- Bem-Vindo(a) a calculadora de IMC ---------\n");

            Console.WriteLine("Digite seu peso em Kg");
            peso = Convert.ToDouble((Console.ReadLine()));

            Console.WriteLine("Digite sua altura");
            altura = Math.Pow(Convert.ToDouble(Console.ReadLine()), 2);

            //IMC = peso / altura²
            imc = Math.Round(peso / altura);

            Console.WriteLine("\n-----------------\nSeu IMC é de: {0}", imc);

            if (imc < 20)
            {
                Console.WriteLine("Você está abaixo do peso\n-----------------\n");
            }
            else if (imc >= 20 && imc < 25)
            {
                Console.WriteLine("Você está no peso ideal\n-----------------\n");
            }
            else
            {
                Console.WriteLine("Você está acima do peso\n-----------------\n");
            }

        }
    }
}
