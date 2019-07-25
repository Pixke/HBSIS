using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletim
{
    public class BaseAlunos
    {

        string[,] arrayAluno = new string[2, 5];
        Aluno aluno = new Aluno();

        public void inserir()
        {
            for (int i = 0; i < arrayAluno.GetLength(0); i++)
            {
                arrayAluno[i, 0] = i.ToString();
                Console.WriteLine("Digite o Nome do Aluno");
                var nomeAluno = Console.ReadLine();

                arrayAluno[i, 1] = nomeAluno;

                var media = insereNotas();

                arrayAluno[i, 2] = media.ToString();

                var frequencia = calcFrequencia();
                arrayAluno[i, 3] = media.ToString();


                string situacao = aluno.Situacao(media, frequencia);
                arrayAluno[i, 4] = situacao;

            }

            Console.ReadKey();
        }

        public int insereNotas()
        {
            Console.WriteLine("Digite a 1° Nota");
            int Nota1 = Int32.Parse(Console.ReadLine());


            Console.WriteLine("Digite a 2° Nota");
            int Nota2 = Int32.Parse(Console.ReadLine());


            Console.WriteLine("Digite a 3° Nota");
            int Nota3 = Int32.Parse(Console.ReadLine());

            var media = aluno.CalcularMedia(Nota1, Nota2, Nota3);
            return media;
        }

        public int calcFrequencia()
        {
            Console.WriteLine("Digite o Número de Aulas:");
            int TotalAulas = Int32.Parse(Console.ReadLine());


            Console.WriteLine("Digite o Número de Faltas:");
            int TotalFaltas = Int32.Parse(Console.ReadLine());


            int frequencia = aluno.CalculaFreqencia(TotalAulas, TotalFaltas);
            return frequencia;
        }

        public void listar()
        {
            for (int i = 0; i < arrayAluno.GetLength(0); i++)
            {
                Console.WriteLine($"Id.. {arrayAluno[i, 0]}");
                Console.WriteLine($"Nome.. {arrayAluno[i, 1]}");
                Console.WriteLine($"Media.. {arrayAluno[i, 2]}");
                Console.WriteLine($"Frequencia.. {arrayAluno[i, 3]}");
                Console.WriteLine($"Situação.. {arrayAluno[i, 4]}");
            }
            Console.ReadKey();
        }

        public void excluir(int pid)
        {
            for (int i = 0; i < arrayAluno.GetLength(0); i++)
            {
                if (arrayAluno[i, 0] == pid.ToString())
                {
                    arrayAluno[i, 1] = "";
                    arrayAluno[i, 2] = "";
                    arrayAluno[i, 3] = "";
                    arrayAluno[i, 4] = "";
                    break;
                }
            }
        }

        public void alterar(int pid)
        {
            for (int i = 0; i < arrayAluno.GetLength(0); i++)
            {
                if (arrayAluno[i, 0] == pid.ToString())
                {
                    var media = insereNotas();
                    arrayAluno[i, 2] = media.ToString(); //media
                    var frequencia = Convert.ToInt32(arrayAluno[i, 3]);
                    arrayAluno[i, 4] = aluno.Situacao (media, frequencia);//situação
                    break;
                }
            }
        }

    }
}