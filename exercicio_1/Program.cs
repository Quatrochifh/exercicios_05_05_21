using System;

namespace exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool respostaverdade = false;
            do
            {

            Console.WriteLine("insira seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine("ola " + nome + " !!");

            Console.WriteLine ("por favor " + nome + " escolha um numero de 1 a 10");
            string numero = Console.ReadLine();

            switch (numero){
                case "1":
                    Console.WriteLine("Obrigado " + nome + " seu numero é valido");
                    respostaverdade = true;
                    break;
                case "2":
                    Console.WriteLine("Obrigado " + nome + " seu numero é valido");
                    respostaverdade = true;
                    break;
                case "3":
                    Console.WriteLine("Obrigado " + nome + " seu numero é valido");
                    respostaverdade = true;
                    break;
                case "4":
                    Console.WriteLine("Obrigado " + nome + " seu numero é valido");
                    respostaverdade = true;
                    break;
                case "5":
                    Console.WriteLine("Obrigado " + nome + " seu numero é valido");
                    respostaverdade = true;
                    break;
                case "6":
                    Console.WriteLine("Obrigado " + nome + " seu numero é valido");
                    respostaverdade = true;
                    break;
                case "7":
                    Console.WriteLine("Obrigado " + nome + " seu numero é valido");
                    respostaverdade = true;
                    break;
                case "8":
                    Console.WriteLine("Obrigado " + nome + " seu numero é valido");
                    respostaverdade = true;
                    break;
                case "9":
                    Console.WriteLine("Obrigado " + nome + " seu numero é valido");
                    respostaverdade = true;
                    break;
                case "10":
                    Console.WriteLine("Obrigado " + nome + " seu numero é valido");
                    respostaverdade = true;
                    break;
                default:
                    Console.WriteLine("seu numero é invalido");
                    respostaverdade = false;
                    break;
            }
                
            } while (respostaverdade == false);
           
        }
    }
}
