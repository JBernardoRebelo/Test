using System;

namespace Test2
{
    class Program
    {
        //método principal
        static void Main(string[] args)
        {
            //variaveis de dados de personagens

            //nome:
            string charName;
            charName = "Jorge";

            //idades;
            int charAge;
            charAge = 55;

            //a história
            Console.WriteLine("Era uma vez um homem chamado " + charName);
            Console.WriteLine("Ele tinha " + charAge + " anos.");

            charName = "João";
            charAge = 18;

            Console.WriteLine("Ele gostava mesmo do nome " + charName);
            Console.WriteLine("Mas não gostava de ter " + charAge + " anos");



            Console.ReadLine();
        }
    }
}
