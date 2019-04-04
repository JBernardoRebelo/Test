﻿using System;

namespace Ex17
{
    class Program
    {
        /*
          - Escreve um programa que solicite ao utilizador um número inteiro
          e imprima o número seguido de um ponto de exclamação.

          - Por exemplo, ao ler o número sete, vai mostrar no ecrã 7!. 
          - No entanto, se o número for divisível por 3 vai mostrar "Fizz!"
          - Se for divisível por 5 vai mostrar Buzz!
          - Se for divisível por 3 e por 5 mostra FizzBuzz! 
          -Sugestão: o operador % permite obter o resto da divisão para calcular se dado número é divisível.
         */
        static void Main(string[] args)
        {
            //declare variables
            int x;

            //ask user
            Console.Write("Insert an integer: ");
            //stores and converts variable
            x = Convert.ToInt32(Console.ReadLine());

            //final result
            //if statments using "%"
            //if divisible by 3 and 5
            if (x % 5 == 0 && x % 3 == 0)
            {
                //shows fizzbuzz
                Console.WriteLine("FizzBuzz!");
            }
            //if divisible by 3
            else if (x % 3 == 0)
            {
                //shows fizz
                Console.WriteLine("Fizz!");
            }
            //if divisible by 5
            else if (x % 5 == 0)
            {
                //shows buzz
                Console.WriteLine("Buzz!");
            }           
            //if nothing else is true
            else
            {
                //shows default message, the variable and "!"
                Console.WriteLine(x + "!");
            }
        }
    }
}
