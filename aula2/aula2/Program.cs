using System;
using System.Threading;

namespace aula2
{
    public class Program
    {
        static void Main(string[] args)
        {

            ExibirCabecalho();
            ExibirOpcoesMenu();
        }

        public static void ExibirCabecalho()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("**************");
            Console.WriteLine("Hello World!");
            Console.WriteLine("\n**************");
            Console.WriteLine(@"
░██████╗███████╗███╗░░██╗░█████╗░░█████╗░
██╔════╝██╔════╝████╗░██║██╔══██╗██╔══██╗
╚█████╗░█████╗░░██╔██╗██║███████║██║░░╚═╝
░╚═══██╗██╔══╝░░██║╚████║██╔══██║██║░░██╗
██████╔╝███████╗██║░╚███║██║░░██║╚█████╔╝
╚═════╝░╚══════╝╚═╝░░╚══╝╚═╝░░╚═╝░╚════╝░");
            Console.ResetColor();
            Console.WriteLine("Bora ver");
        }


        public static void ExibirOpcoesMenu()
        {
            Console.WriteLine("\nDigite 1 para registrar informações");
            Console.WriteLine("\nDigite 2 para listar informações");
            Console.WriteLine("\nDigite 3 para apagar informações");
            Console.WriteLine("\nDigite 0 para sair\n");
            Console.WriteLine("\nDitite a opção escolhida: ");
            int opcaoEscolhidaNumero = int.Parse(Console.ReadLine());
            //int opcaoEscolhidaNumero = int.Parse(opcaoEscolhida);
            /*
            if (opcaoEscolhidaNumero == 1)
            {
                Console.WriteLine("\nVocê escolheu a o pção 1");
            }
            if (opcaoEscolhidaNumero == 2)
            {
                Console.WriteLine("\n Você escolheu a opção 2");
            } */

            switch (opcaoEscolhidaNumero)
            {
                case 1:
                    CadInfo();
                   
                   
                    
                    break;

                case 2:
                    Console.WriteLine("\nVocê escolheu a opção 2");
                    Thread.Sleep(3000);
                    Console.Clear();
                    ExibirCabecalho();
                    ExibirOpcoesMenu();

                    break;

                case 3:
                    Console.WriteLine("\nVocê escolheu a opção 3");
                    Thread.Sleep(3000);
                    Console.Clear();
                    ExibirCabecalho();
                    ExibirOpcoesMenu();
                    break;

                case 0:
                    Console.WriteLine("\nSair");
                    break;

                default:
                    Console.WriteLine("\n Você digitou uma opção inválida");
                    break;
            }
        }

    private static void CadInfo()
        {
            Console.Clear();
            Console.WriteLine("Cadastro de cliente");
            Console.WriteLine("Digite seu nome: ");
            string NomeDoUsuario = Console.ReadLine();
            Console.WriteLine($"\nNome cadastrado com sucesso! { NomeDoUsuario}");
            Thread.Sleep(3000);
            ExibirCabecalho();
            ExibirOpcoesMenu();

        }





    }
}
