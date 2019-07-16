using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjetoFinalConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] baseDeDados = new string[2, 5];
            int IndiceBaseDeDados = 0;
            Console.WriteLine("BEM VINDO A BIBLIOTECA HBSIS");
            Console.WriteLine("                            ");
            Thread.Sleep(1000);
            Console.WriteLine("Aguarde... Carregando Base de Dados");
            Thread.Sleep(4000);
            var escolhaInicial = ApresentaMenuInicial();
            while (true)
            {
                switch (escolhaInicial)
                {
                    case "1": { InseriValoresNaLista(ref baseDeDados, ref IndiceBaseDeDados); } break;
                    case "2": { RemoverInformacoes(ref baseDeDados); } break;
                    case "3": { MostrarInformacoes(baseDeDados); } break;
                    case "4": { MostrarInformacoes(baseDeDados, "true"); } break;
                    case "5":
                        {
                            return;
                        }
                }
                escolhaInicial = ApresentaMenuInicial();
            }
        }
        public static string ApresentaMenuInicial()
        {
            Console.Clear();
            Console.WriteLine("       ~> MENU PRINCIPAL <~    ");
            Console.WriteLine("                               ");
            Console.WriteLine("1 - Adicionar Livro no Registro");
            Console.WriteLine("2 - Remover Livro do Registro.");
            Console.WriteLine("3 - Listar Livros Cadastrados.");
            Console.WriteLine("4 - Listar os Livros Excluídos do Registro.");
            Console.WriteLine("5 - Sair do sistema.");
            Console.WriteLine("                     ");
            Console.WriteLine("Escolha uma das Opções e Tecle Enter:");
            return Console.ReadLine();
        }
        public static void InseriValoresNaLista(ref string[,] baseDeDados, ref int
            indiceBase)
        {
            Console.WriteLine("--Adicionando Livro no Registro--");
            Console.WriteLine("Informe o Nome do Livro:");
            var nome = Console.ReadLine();
            Console.WriteLine("Informe o Autor do Livro");
            var idade = Console.ReadLine();
            AumentaTamanhoLista(ref baseDeDados);
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 0] != null)
                    continue;
                baseDeDados[i, 0] = (indiceBase++).ToString();
                baseDeDados[i, 1] = nome;
                baseDeDados[i, 2] = idade;
                baseDeDados[i, 3] = "true";
                baseDeDados[i, 4] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                break;
            }
            Console.WriteLine("Livro Cadastrado com Sucesso!");
            Console.WriteLine("Para Voltar ao Menu Principal, Tecle Enter.");
            Console.ReadKey();

        }
        public static void MostrarInformacoes(string[,] baseDeDados, string mostrarRegistroNAtivos = "false")
        {
            Console.WriteLine("Apresentação dos Livros Existentes no Registro.");
            if (mostrarRegistroNAtivos == "true")
                Console.WriteLine("Livros Apagados do Registro.");
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 3] != mostrarRegistroNAtivos)
                    Console.WriteLine($"ID {baseDeDados[i, 0]} " +
                          $"- Título do Livro: {baseDeDados[i, 1]} " +
                          $"- Autor: {baseDeDados[i, 2]}" +
                          $"- Data Alteração: {baseDeDados[i, 4]}");
            }
            Console.WriteLine("Lista Atualizada!");
            Console.WriteLine("Para Voltar ao Menu Principal, Pressione Qualquer Tecla");
            Console.ReadKey();
        }
        public static void RemoverInformacoes(ref string[,] baseDeDados)
        {
            Console.WriteLine("Remover Livro do Registro");
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {

                if (baseDeDados[i, 3] != "false")
                    Console.WriteLine($"ID:{baseDeDados[i, 0]}" +
                        $"- Título do Livro:{baseDeDados[i, 1]} " +
                    $"- Autor:{baseDeDados[i, 2]}");
            }
            Console.WriteLine("Digite o ID do Livro Para Apagar do Registro:");
            var id = Console.ReadLine();
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 0] != null && baseDeDados[i, 0] == id)
                {  //Agora trocamos este valor para um identificador string "false"
                    baseDeDados[i, 3] = "false";
                    //Aqui indicamos a data que foi alterado esse registro.
                    baseDeDados[i, 4] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                }
            }
            Console.WriteLine("Processo Concluído.");
            Console.WriteLine("Para Voltar ao Menu Principal, Pressione Qualquer Tecla");
            Console.ReadKey();
        }
        public static void AumentaTamanhoLista(ref string[,] baseDeDados)
        {
            var limiteDaLista = true;
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 0] == null)
                    limiteDaLista = false;
            }
            if (limiteDaLista)
            {
                var listaCopia = baseDeDados;
                baseDeDados = new string[baseDeDados.GetLength(0) + 5, 5];
                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {
                    baseDeDados[i, 0] = listaCopia[i, 0];
                    baseDeDados[i, 1] = listaCopia[i, 1];
                    baseDeDados[i, 2] = listaCopia[i, 2];
                    baseDeDados[i, 3] = listaCopia[i, 3];
                    baseDeDados[i, 4] = listaCopia[i, 4];
                }
                Console.WriteLine("O Tamanho do Registro Foi Atualizado");
            }
        }
    }
}
