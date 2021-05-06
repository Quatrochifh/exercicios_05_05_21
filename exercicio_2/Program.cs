using System;

namespace exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
        //    Faça um programa que leia um nome de usuário e a sua senha e não aceite a senha igual ao nome do usuário,
        //  mostrando uma mensagem de erro e voltando a pedir as informações.

          Console.WriteLine("insira seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine("ola " + nome + " !!");
            bool respostaverdade = false;
       
        do
        {
            Console.WriteLine("por favor, escolha seu nome de usuario\n");
            string usuario = Console.ReadLine();

            Console.WriteLine("por favor escolha uma senha");
            string senha = Console.ReadLine();

            if(usuario == senha)
            {
                respostaverdade = false;
                Console.WriteLine ("insira uma senha diferente do usuario\n");
            }else{ respostaverdade = true;
                Console.WriteLine("esta correto, muito obrigado " + nome + "!");
                
            }

          } while (respostaverdade == false);

        }
    }
}
