using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Program
    {
        static string[,] BaseDeLivros;

        static void Main(string[] args)
        {
            MostrarSejaBemVindo();

            if (MenuInicial() == 1)
            {
                Console.Clear();

                CarregaBaseDeDados();
                MostrarSejaBemVindo();

                Console.WriteLine("Menu - Locação de Livros");
                Console.WriteLine("Digite o Nome do Livro para Alocado");

                var nomedolivro = Console.ReadLine();
                if (PesquisaLivroParaLocacao(nomedolivro))
                {
                    Console.Clear();
                    Console.WriteLine("Você deseja alocar o Livro Para Sim (1) Para Não (0)");  
                    if (Console.ReadKey().KeyChar.ToString() == "1")
                    {
                        AlocarLivro(nomedolivro);
                        Console.WriteLine("Livros Alocados Com Sucesso:");
                        
                    }
                    Console.Clear();
                    Console.WriteLine("Listagem de Livros\r\n");

                        for (int i = 0; i < BaseDeLivros.GetLength(0); i++)
                            {
                                Console.WriteLine($"Nome Do Livro: {BaseDeLivros[i,0]} Disponivel: {BaseDeLivros[i,1]}");
                            }
                }
            }
            {
                int qtde = 0;
                int idade = 0;
                Console.WriteLine("Exercício 2 - Verifica maior idade");
                int i = 0;
                while (i < 10)
                {
                    i = i + 1;
                    Console.Write("Informe a idade da pessoa: ");
                    idade = Convert.ToInt32(Console.ReadLine());
                    if (idade >= 18)
                    {
                        qtde = qtde + 1;
                    }
                }
                Console.WriteLine("Existem " + qtde + " pessoas com mais de 18 anos");
                Console.ReadKey();
            }
            Console.ReadKey();
        }

    /// <summary>
    /// Mostra o Menu de Boas vindas.
    /// </summary>
    public static void MostrarSejaBemVindo()

    {
        Console.WriteLine(" _______________ ");
        Console.WriteLine(" Seja bem vindo ");
        Console.WriteLine(" _______________ ");
        Console.WriteLine(" Design By Piske ");
        Console.WriteLine(" _______________ ");
    }
    /// <summary>
    /// Metodo que mostra o menu inicial com as opções para escolha.
    /// </summary>
    /// <returns></returns>
    public static int MenuInicial()
    {
        Console.WriteLine("\r\n MENU INICIAL");
        Console.WriteLine("O que Você Quer Fazer? ");
        Console.WriteLine("1 - Alugar um livro ");
        Console.WriteLine("2 - Sair do sistema ");
        Console.WriteLine("3 - Cadastro ");
        Console.WriteLine("Digite o numero desejado ");

        int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

        return opcao;
    }
    /// <summary>
    /// Metodo que carrega a base de dados dentro do sistema.
    /// </summary>
    public static void CarregaBaseDeDados()
    {
        BaseDeLivros = new string[2, 2]
        {
                { "o pequeno", "sim"},
                { "o grande", "não"}

        };
    }
    /// <summary>
    /// Metodo que retorna se um livro pode ser alocado.
    /// </summary>
    /// <param name="nomeLivro">Nome do livro a ser pesquisado</param>
    /// <returns>Retorna verdadeiro caso o livro estiver livre para alocação</returns>
    /// <returns>Retorna verdadeiro caso o livro estiver livre para alocação</returns>
    public static bool PesquisaLivroParaLocacao(string nomeLivro)
    {
        for (int i = 0; i < BaseDeLivros.GetLength(0); i++)
        {
            if (nomeLivro == BaseDeLivros[i, 0])
            {
                Console.WriteLine($"O Livro:{nomeLivro}" +
                    $" pode ser alocado?: {BaseDeLivros[i, 1]}");
            }
            return BaseDeLivros[i, 1] == "sim";
        }
        return false;
    }

    /// <summary>
    /// Metodo que aloca o livro como parametro passado.
    /// </summary>
    /// <param name="nomedolivro">Nome do livro a ser alocado</param>
    public static void AlocarLivro(string nomedolivro)
    {
        for (int i = 0; i < BaseDeLivros.GetLength(0); i++)
        {
            if (nomedolivro == BaseDeLivros[i, 0])
                BaseDeLivros[i, 1] = "nâo";
        }
    }
}

}
