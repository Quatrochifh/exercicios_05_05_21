using System;

namespace exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool nomerep = false;
            
            do
            {
                Console.WriteLine("insira seu nome");
                string nome = Console.ReadLine();

                 if (nome == "")
                {
                    nomerep = false;
                Console.WriteLine ("insira uma nome valido!!!\n");
                }
                else
                {
                    Console.WriteLine("ola " + nome + " !!");
                    nomerep = true;
                }
            } while (nomerep == false);

            //idade
            int idade = 0;
            bool idaderep = false;
             do
            {
                Console.WriteLine("insira sua idade");
                idade = int.Parse(Console.ReadLine());

                 if (idade >=0 && idade <=150)
                {
                    idaderep = true;
                    Console.WriteLine ("idade computada!\n");
                   
                }
                else
                {
                    Console.WriteLine("idade invalida!" );
                }
            } while (idaderep == false);
            
            //salario

            bool salariorep = false;
             do
            {
                Console.WriteLine("insira seu salario");
                string salario = Console.ReadLine();

                 if (salario == "")
                {
                    salariorep = false;
                    Console.WriteLine ("insira uma salario valido!!!\n");
                }
                else
                {
                    Console.WriteLine("salario aceito");
                    salariorep = true;
                }
            } while (salariorep == false);


            // estado civil

            bool respostaverdade = false;
            do
            {

            Console.WriteLine ("qual o seu estado civil? sendo (S) de solteiro (C) de (casado(a), (V) de (viuvo(a), (D) de (divorciado(a)");
            string numero = Console.ReadLine();

            switch (numero){
                case "s":
                    Console.WriteLine("Obrigado");
                    respostaverdade = true;
                    break;
                case "c":
                    Console.WriteLine("obrigado");
                    respostaverdade = true;
                    break;
                case "v":
                    Console.WriteLine("Obrigado");
                    respostaverdade = true;
                    break;
                case "d":
                    Console.WriteLine("Obrigado");
                    respostaverdade = true;
                    break;
            
                default:
                    Console.WriteLine("seu numero é invalido");
                    respostaverdade = false;
                    break;
            }
                
            } while (respostaverdade == false);

            Console.WriteLine("suas respostas foram");

        }
    }
}
