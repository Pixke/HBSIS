using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LisytaSimples_Bi_dimencional

{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando nossa lista com mais de uma dimensão
            string[,] listaDeNome = new string[5, 2];

            //Aqui como estamos usando apenas uma referencia da nossa lista colocamos ref ao passar ela no metodo
            CarregaInformacoesEListaElasEmTela(listaDeNome);
            
            //Apos carregar as informações e mostrar em tela, fica no aguardo por um comando
            Console.ReadKey();

            //Indicamos que o usuario precisa informar um numero de identificação para pesquisar um registro.
            Console.WriteLine("Informe o ID do Registro para Pesquisar");
            //Aqui realizamos a pesquisa somente na chamada
            //Passamos a nossa lista novamente pois não iremos alterar, apenas pesquisar a informação.
            //Após a virgula temos o console. readline que espera o nosso identificador unico.
            PesquisandoInformacoesNaNossaLista(listaDeNome, Console.ReadLine());
            Console.ReadKey();

        }
        /// <summary>
        /// Metodo que carrega as informações dentro da nossa lista criada no metodo "MAIN"
        /// E mostra as iformações logo em seguida
        /// </summary>
        /// <param name="arrayBi">Nossa lista a ser carregada</param>
        public static void CarregaInformacoesEListaElasEmTela(string[,] arrayBi)
        {
            //Usando um laço simples para colocar valores mas no mesmo agora utilizando o
            //GetLength com o parametro "0" para indicar que queremos o tamanho da primeira coluna
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                //Carregando o que podemos chamar de ID, identificador do nosso registro unico
                arrayBi[i, 0] = i.ToString();
                //Aqui apenas adicionamos uma informação extra para deixar legal
                arrayBi[i, 1] = $"Bruno_{i}";
            }

            //Lembrando que GetLength é um metodo e usamos "(parametro)" com parametro ou as vezes sem 
            //para realizar a chamada do mesmo
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                //Formatamos uma string de maneira que os dados sejam apresentados 
                Console.WriteLine($"ID:{arrayBi[i, 0]} - Nome:{arrayBi[i, 1]}");
            }
        }
        /// <summary>
        /// Metodo que realiza a pesquisa pelo identificador unico de nossa coleção
        /// </summary>
        /// <param name="arrayBi">Nossa coleção de informações</param>
        /// <param name="pId">Nosso identificador unico</param>
        public static void PesquisandoInformacoesNaNossaLista(string[,] arrayBi, string pId)
        {
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                //Realizamos nossa comparação dos mesmo tipos
                if (arrayBi[i, 0] == pId)
                {//Mostramos as informações formatadas da nossa pesquisa
                    Console.WriteLine($"Informação escolhida: Id:{arrayBi[i, 0]} - Nome:{arrayBi[i, 1]}");
                    //Aqui saimos da nossa lista mas retornamos vazio "return;" pois estamos em um metodo
                    //vazio "void" que não espera retornar algo.
                    return;
                }
            }

            //Caso ele passe por esta linha identificamos que ele não encontrou resultados compativeis.
            Console.WriteLine("Infelizmente a busca pelo id não resultou em nenhuma informação.");
        }
    }
}
