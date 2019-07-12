using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EXERCICIO_3
{
    class Program
    {
        static string[,] listaALunos;
        static void Main(string[] args)
        {
            BaseDadosAlunos();

            TelaInicial();
            Thread.Sleep(500);

            MostrarListaDeLivros();
            Thread.Sleep(500);


            TelaEncerramento();
            Thread.Sleep(500);

        }
        public static void MostrarListaDeLivros()
        {
            Console.WriteLine("Listagem de Alunos:");

            for (int i = 0; i < listaALunos.GetLength(0); i++)
            {
                Console.WriteLine($"Nome: {listaALunos[i, 0]}| Idade: {listaALunos[i, 1]} | Sexo: {listaALunos[i, 2]}");
            }
            //Console.ReadKey();
        }

        public static void BaseDadosAlunos()
        {
            listaALunos = new string[20, 3]
                {
                    {"Bruno      "      ,       "45"     ,     "Masculino     "},
                    {"Mirelli    "      ,       "53"     ,     "Feminino      "}, 
                    {"Mirelli    "      ,       "73"     ,     "Feminino      "},
                    {"Bruno      "      ,       "52"     ,     "Masculino     "},
                    {"Mirelli    "      ,       "64"     ,     "Feminino      "},
                    {"Mirelli    "      ,       "34"     ,     "Feminino      "},
                    {"Bruno      "      ,       "46"     ,     "Masculino     "},
                    {"Mirelli    "      ,       "23"     ,     "Feminino      "},
                    {"Mirelli    "      ,       "56"     ,     "Feminino      "},
                    {"Mirelli    "      ,       "81"     ,     "Feminino      "},
                    {"Mirelli    "      ,       "78"     ,     "Feminino      "},
                    {"Bruno      "      ,       "23"     ,     "Masculino     "},
                    {"Mirelli    "      ,       "35"     ,     "Feminino      "},
                    {"Mirelli    "      ,       "76"     ,     "Feminino      "},
                    {"Bruno      "      ,       "24"     ,     "Masculino     "},
                    {"Mirelli    "      ,       "56"     ,     "Feminino      "},
                    {"Mirelli    "      ,       "87"     ,     "Feminino      "},
                    {"Bruno      "      ,       "39"     ,     "Masculino     "},
                    {"Mirelli    "      ,       "23"     ,     "Feminino      "},
                    {"Bruno      "      ,       "56"     ,     "Masculino     "}
                };
        }
        public static void TelaInicial()
        {
            Console.WriteLine("Banco de dados - Lista de alunos");
            Console.WriteLine("                                ");
            Console.WriteLine("      ENTER PARA CONTINUAR   ");
            Console.WriteLine("________________________________");

            Console.ReadKey();
            
        }

        public static void TelaEncerramento()
        {
            Console.WriteLine("                                ");
            Console.WriteLine("      ENTER PARA ENCERRAR   ");
            Console.WriteLine("________________________________");

            Console.ReadKey();
            


        }
    }

}
