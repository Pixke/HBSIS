using Listar_Meus_Carros.Classe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listar_Meus_Carros
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] baseDeDados = new string[2, 5];
            Console.WriteLine("Lista Dos Meus Carros Preferidos");

            MostraMenuInicial();




            List<Carro> listaAdd = new List<Carro>();

            for (int i = 0; i < 1; i++)
            {
                listaAdd.Add(new Carro()
                {
                    Modelo = RetornaValores("Modelo"),
                    Ano = int.Parse(RetornaValores("Ano")),
                    CavalosPotencia = int.Parse(RetornaValores("Cavalos de Potência")),
                    Placa = (RetornaValores("Placa"))
                });
            }

            foreach     (Carro item in listaAdd)
                Console.WriteLine($"Nome: {item.Modelo} Ano: {item.Ano} CV: {item.CavalosPotencia} Placa: {item.Placa}");

            Console.ReadKey();

        }

        public static string RetornaValores(string nome)
        {//informo e retorno o valor conforme a solicitação do campo
            Console.WriteLine($"Informe Valores Para o Campo:   {nome}");
            return Console.ReadLine();

        }

        public static string MostraMenuInicial()
        {


            Console.WriteLine("       Menu inicial   ");
            Console.WriteLine("                         ");
            Console.WriteLine("1 - Inserir Carro a Lista");
            Console.WriteLine("2 - Editar Carro da Lista");
            Console.WriteLine("3 - Editar Carro da Lista");
            Console.WriteLine("4 - Editar Carro da Lista");
            Console.WriteLine("5 - Encerrar Sistema");
            Console.WriteLine("                         ");

            Console.WriteLine("Digite o Numero da Opção Desejada e Tecle Enter");



        }
    }
}
