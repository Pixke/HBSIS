using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDeArquivosDoWindows;

namespace NovaBibliotecaDoWindows
{
    class Program
    {
        static void Main(string[] args)
        {
            var arquivos = new GetFiles();
            var meusDocumentos = arquivos.RetornaArquivosDoMeuDocumentos();

            for (int i = 0; i < meusDocumentos.Length; i++)
            {
                Console.WriteLine(meusDocumentos[i]);
            }
            Console.ReadKey();

            var arquivos2 = new GetFiles();
            var documentosImage = arquivos.RetornaArquivosImagesFiles();

            for (int i = 0; i < documentosImage.Length; i++)
            {
                Console.WriteLine(documentosImage[i]);
            }
            Console.ReadKey();

            var arquivos3 = new GetFiles();
            var documentosGit = arquivos.RetornaArquivosGit();

            for (int i = 0; i < documentosGit.Length; i++)
            {
                Console.WriteLine(documentosGit[i]);
            }
            Console.ReadKey();
        }
        
    }
}
