using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locação_Carro
{
    class Program
    {
        static string[,] baseDeCarros;
        static void Main(string[] args)
        {
            CarregaBaseDeDados();

            var opcaoMenu = MenuPrincipal();

            while (opcaoMenu != 4)
            {
                if (opcaoMenu == 1)
                    AlocarUmCarro();
                if (opcaoMenu == 2)
                    ReservarUmCarro();

                if (opcaoMenu == 3)
                    DesalocarUmCarro();

                opcaoMenu = MenuPrincipal();
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Mostra as informações iniciais do sistema.
        /// </summary>
        public static void MostrarSejaBemVindo()
        {
            Console.WriteLine("|                                              |");
            Console.WriteLine("|______________________________________________|");
            Console.WriteLine("|             Bem Vindo a Localiza             |");
            Console.WriteLine("|______________________________________________|");
            Console.WriteLine("|          Sua Locadora Personalizada          |");
            Console.WriteLine("|______________________________________________|");
            Console.WriteLine("|______________________________________________|");
            Console.WriteLine("|           Playtest V - 0.0.1/2019            |");
            Console.WriteLine("|______________________________________________|");

        }
        /// <summary>
        /// Metodo que mostra o menu inicial com as opções para escolha.
        /// </summary>
        /// <returns>Retorna o número do menu escolhido.</returns>
        public static int MenuPrincipal()
        {
            Console.Clear();

            MostrarSejaBemVindo();

            Console.WriteLine("    Menu Inicial   ");
            Console.WriteLine("O Que Você Deseja Fazer?");
            Console.WriteLine("1 - Alocar um Carro.");
            Console.WriteLine("2 - Reservar um Carro.");
            Console.WriteLine("3 - Devolver um Carro.");
            Console.WriteLine("4 - Sair do sistema.");
            Console.WriteLine("Digite o número desejado:");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            return opcao;
        }
        /// <summary>
        /// Metodo que carrega a base de dados dentro do sistema.
        /// </summary>
        public static void CarregaBaseDeDados()
        {
            baseDeCarros = new string[3, 3]
            {
                {"ka",      "2000",     "sim"},
                {"onix",    "2000",     "não"},
                {"cg",      "2000",     "reservado"}
            };
        }
        /// <summary>
        /// Metodo que retorna se um livro pode ser alocado.
        /// </summary>
        /// <param name="nomeCarro">Nome do livro a ser pesquisado</param>
        /// <returns>Retorna verdadeiro em caso o livro estiver livre para alocação.</returns>
        public static bool PesquisaCarroParaAlocacao(string nomeCarro)
        {
            for (int i = 0; i < baseDeCarros.GetLength(0); i++)
            {
                if (nomeCarro == baseDeCarros[i, 0])
                {
                    Console.WriteLine($"O Carro:{nomeCarro}" +
                          $" pode ser alocado?:{baseDeCarros[i, 2]}");

                    return baseDeCarros[i, 2] == "sim";
                }
            }

            return false;
        }
        /// <summary> 
        /// Metodo para alterar a informação de alocação do livro.
        /// </summary>
        /// <param name="nomeCarro">Nome do livro</param>
        /// <param name="alocar">Valor booleano que define se o livro esta ou não disponivel.</param>
        public static void AlocarCarro(string nomeCarro, bool alocar)
        {
            for (int i = 0; i < baseDeCarros.GetLength(0); i++)
            {
                if (nomeCarro == baseDeCarros[i, 0])
                {
                    baseDeCarros[i, 2] = alocar ? "não" : "sim";
                }
            }

            Console.Clear();
            MostrarSejaBemVindo();
            Console.WriteLine("Atualizado com Sucesso!");
        }
        /// <summary>
        /// Metodo que carrega o conteudo inicial da aplicação do menu 1
        /// </summary>
        public static void AlocarUmCarro()
        {
            MostrarMenuInicialCarros("Alocar um Carro:");

            var nomedocarro = Console.ReadLine();
            if (PesquisaCarroParaAlocacao(nomedocarro))
            {
                Console.Clear();
                MostrarSejaBemVindo();
                Console.WriteLine("Você deseja alocar o carro? para NÃO (0) ou SIM (1)");

                AlocarCarro(nomedocarro, Console.ReadKey().KeyChar.ToString() == "1");

                MostrarListaDeCarros();

                Console.ReadKey();
            }
        }
        /// <summary>
        /// Metodo que mostra a lista de livros atualizado
        /// </summary>
        public static void MostrarListaDeCarros()
        {
            Console.WriteLine("Listagem de carros:");

            for (int i = 0; i < baseDeCarros.GetLength(0); i++)
            {
                Console.WriteLine($"Nome do Carro: [{baseDeCarros[i, 0]}] Disponivel: ({baseDeCarros[i, 2]})");
            }
        }
        public static void DesalocarUmCarro()
        {
            MostrarMenuInicialCarros("Desalocar um Carro:");

            var nomedocarro = Console.ReadLine();
            if (!PesquisaCarroParaAlocacao(nomedocarro))
            {
                Console.Clear();
                MostrarSejaBemVindo();
                Console.WriteLine("Você deseja desalocar o Carro? para sim(1) para não(0)");

                AlocarCarro(nomedocarro, Console.ReadKey().KeyChar.ToString() == "0");

                MostrarListaDeCarros();

                Console.ReadKey();
            }
        }
        public static void MostrarMenuInicialCarros(string operacao)
        {
            Console.Clear();

            MostrarSejaBemVindo();

            Console.WriteLine($"Menu - {operacao}");
            Console.WriteLine("                  ");
            MostrarListaDeCarros();
            Console.WriteLine("                  ");
            Console.WriteLine("Digite o nome do Carro para realizar a operação:");
        }
        public static void ReservarUmCarro()
        {
            MostrarMenuInicialCarros("Reservar um Carro:");

            var nomedocarro = Console.ReadLine();
            if (PesquisaCarroParaAlocacao(nomedocarro))
            {
                Console.Clear();
                MostrarSejaBemVindo();
                Console.WriteLine("Você deseja Reservar o Carro? para sim(1) para não(0)");

                AlocarCarro(nomedocarro, Console.ReadKey().KeyChar.ToString() == "1");

                MostrarListaDeCarros();

                Console.ReadKey();
                    

                

            }
        }
    }
}   
