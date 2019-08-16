using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace NovaLista_CarrosNovos_E_Usados
{
    class Program
    {
        static void Main(string[] args)
        {

            string[,] listaDeNome = new string[1, 3];

            int IdParaLista = 0;

            InsereRegistro(ref listaDeNome, ref IdParaLista);

            Console.ReadKey();

            InsereRegistro(ref listaDeNome, ref IdParaLista);

            Console.ReadKey();
        }

        public static void InsereRegistro(ref string[,] listaDeNome, ref int IdParaLista)
        {

            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {
                if (listaDeNome[i, 0] != null)
                continue;

                Console.WriteLine("\r\nInforme o Nome do Veículo:");
                var nome = Console.ReadLine();
                Console.WriteLine("\r\nInforme o Estado Do veículo (Novo Ou Usado):");
                var estado = Console.ReadLine();

                listaDeNome[i, 0] = (IdParaLista++).ToString();

                listaDeNome[i, 1] = nome;

                listaDeNome[i, 2] = estado;


                Console.WriteLine("Deseja Adicionar um novo Veículo a Lista? sim (1) ou não (0)");

                var continuar = Console.ReadKey().KeyChar.ToString();

                if (continuar == "0")
                    break;

                AumentaTamanhoLista(ref listaDeNome);
            }

            Console.WriteLine("Veículo adicionado com sucesso: Verifique as alterações.");


            for (int i = 0; i < listaDeNome.GetLength(0); i++)

                Console.WriteLine(string.Format("ID Veículo {0} - Veículo: {1}" +
                    " - Estado: {2}", listaDeNome[i, 0], listaDeNome[i, 1], listaDeNome[i, 2]));
        }

        public static void AumentaTamanhoLista(ref string[,] ListaDeNome)
        {

            var limiteDaLista = true;

            for (int i = 0; i < ListaDeNome.GetLength(0); i++)
            {

                if (ListaDeNome[i, 0] == null)
                    limiteDaLista = false;
            }


            if (limiteDaLista)
            {

                var listaCopia = ListaDeNome;

                ListaDeNome = new string[ListaDeNome.GetLength(0) + 1, 3];

                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {
                    ListaDeNome[i, 0] = listaCopia[i, 0];
                    ListaDeNome[i, 1] = listaCopia[i, 1];
                    ListaDeNome[i, 2] = listaCopia[i, 2];
                }
                Console.WriteLine("Adicionado um novo Registro");
            }

        }
    }
}