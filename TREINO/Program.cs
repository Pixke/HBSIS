using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TREINO
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*DEFINE UMA VARIAVEL*/
            string primeiroAmigo = "Billlllllllll";
            Console.WriteLine(primeiroAmigo);
            

            /*DEFINE UMA VARIAVEL*/
            string segundoAmigo = "Carlos";
            Console.WriteLine(segundoAmigo);
            

            /*ESCREVE UTILIZANDO DUAS OU MAIS VARIAVEIS*/
            Console.WriteLine($"Olá, tenho dois amigos, o {primeiroAmigo} e o {segundoAmigo}");


            /*CONTA OS CARACTERES EXISTENTES NA VARIAVEL*/
            Console.WriteLine($"O nome {primeiroAmigo} tem {primeiroAmigo.Length} letras.");
            
            Console.WriteLine($"O nome  {segundoAmigo} tem {segundoAmigo.Length} letras.");


            /*----------------------------------------------------------------*/

            Console.WriteLine("                               ");
            
            Console.WriteLine("                               ");
            
            Console.WriteLine("                               ");



            /*----------------------------------------------------------------*/

            /*ESPAÇADORES*/
            string greeting = "      Hello World!       ";
            Console.WriteLine($"[{greeting}]");

            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");

            Console.WriteLine("                               ");
            
            Console.WriteLine("                               ");
            
            Console.WriteLine("                               ");



            /*----------------------------------------------------------------*/

            /*ESCREVE UTILIZANDO DUAS OU MAIS VARIAVEIS*/
            string olamundo = "ola mundo!";
            Console.WriteLine(olamundo);
            
            olamundo = olamundo.Replace("ola", "congratulações");
            Console.WriteLine(olamundo);

            Console.WriteLine("                               ");

            /*ALTERA TEXTO PARA MINUSCULAS OU MAIUSCULAS*/

            Console.WriteLine(olamundo.ToUpper());
            
            Console.WriteLine(olamundo.ToLower());
            
            Console.WriteLine("                               ");

            /*ESCREVE UTILIZANDO DUAS OU MAIS VARIAVEIS NA MESMA LINHA "DEFINE ESPAÇOS" */
            Console.WriteLine(olamundo.ToUpper()+"  "+olamundo.ToUpper());


            /*----------------------------------------------------------------*/

            /*ANALIZA VARIAVEL (VERDADEIRO OU FALSO) */
            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));


            /*entrada de dados, retorna quantos alunos tem maior de 18 anos*/

            int qtde = 0;
            int idade = 0;
            Console.WriteLine("Exercício 2 - Verifica maior idade");
            int i = 0;
            while (i < 5)
            {
                i = i + 1;
                Console.WriteLine("Informe a idade");

                idade = Convert.ToInt32(Console.ReadLine());
                if (idade >= 18)
                {
                    qtde = qtde + 1;
                }
            }
            Console.WriteLine("Existem " + qtde + " pessoas com mais de 18 anos");
            Console.ReadKey();
        }
    }
}
