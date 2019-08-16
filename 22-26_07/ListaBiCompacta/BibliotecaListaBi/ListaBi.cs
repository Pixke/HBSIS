using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiCompacta.BibliotecaListaBi
{
    class ListaBi
    {
        string[,] listaBi;

        public ListaBi()
        {
            listaBi = new string[5, 2];
        }

        public void CarregaListaBi()
        {
            for (int i = 0; i < listaBi.GetLength (0); i++)
            {
                listaBi[i, 0] = i.ToString();
                listaBi[i, 0] = $"Bruno_{i}";

                Console.WriteLine($"Id: {i} Nome: Bruno_{i}");
            }
        }

        public void PesquisaLista (string idPesquisa)
        {
            for (int i = 0; i < listaBi.GetLength (0); i++)
            {
                Console.WriteLine("Resultado Encontrado Com Sucesso!");
                Console.WriteLine($"Você Pesquisou Pelo Registro: {listaBi[i, 1]}");

                return;


            }
        }

        Console.WriteLine("Nenhum Registro Encontrado");
    }
}
