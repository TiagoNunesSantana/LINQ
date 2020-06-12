using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lista = { 3, 9, 4, 6, 20, 10, 60, 90, 80, 50 };

            //LAMBDA = (entrada) => (expressao)
            //var listaFiltrada = lista.Where(a=>a>10).Select(a=>a);//depois que fizer o filtro dos valores maior que 10, mostre os valores
            var listaFiltrada = lista.Where(a => a > 10).OrderBy(a => a).Select(a => a);//colocando em ordem crescente

            foreach (var item in listaFiltrada)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
