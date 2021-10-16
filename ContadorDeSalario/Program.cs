using System;

namespace ContadorDeSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            Criar um programa que receba o valor do salário de um funcionário
            e o valor do salário mínimo e apresente na tela quantos salários 
            mínimos ganha esse funcionário.

            */
            double salarioMinimo, salario,calculo;

            Console.WriteLine("\n--------- Bem-Vindo(a) a calculadora de salário ---------\n");

            Console.WriteLine("Digite seu salário");
            salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o salário minimo");
            salarioMinimo = Convert.ToDouble(Console.ReadLine());

            calculo = Math.Round(salario/salarioMinimo, 2);

            Console.WriteLine("\n-----------------\nSeu salário é de: {0} reais\nO salário minimo é: {1} reais\nVocê recebe {2} salários minimos.\n-----------------\n", salario,salarioMinimo,calculo);


        }
    }
}
