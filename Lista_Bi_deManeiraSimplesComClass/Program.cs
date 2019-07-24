using Lista_Bi_deManeiraSimplesComClass.Mostrar;
using Lista_Bi_deManeiraSimplesComClass.Carrega;
using System;

namespace Lista_Bi_deManeiraSimplesComClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aqui iniciamos nosso objeto em memoria
            var carregaLista = new CarregarLista();
            //aqui chamamos o nosso metodo para carregar a lista
            carregaLista.CarregaInformacoesEListaElasEmTela();
            //carregamos novamente mas agora a classe mostrar lista 
            //aonde colocamos todas os metodos que serão direcionados para mostrar
            //a listagem de informaçoes na tela do console
            var mostrarLista = new MostrarLista();
            //aqui chamamos o metodo novamente
            mostrarLista.PesquisandoInformacoesNaNossaLista(carregaLista.ListaNome,"0");

            Console.ReadKey();
        }
    }
}
