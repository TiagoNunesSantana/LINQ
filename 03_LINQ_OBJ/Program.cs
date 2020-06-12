using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_LINQ_OBJ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Usuario> lista = new List<Usuario>();
            lista.Add(new Usuario() { Nome = "Tiago", Email="tiago@gmail.com"});
            lista.Add(new Usuario() { Nome = "Nani", Email = "nani@hotmail.com" });
            lista.Add(new Usuario() { Nome = "Alice", Email = "alice@ig.com" });
            lista.Add(new Usuario() { Nome = "Pai", Email = "pai@gmail.com" });
            lista.Add(new Usuario() { Nome = "Mãe", Email = "mae@gmail.com" });

            var ListaFiltrada = lista.Where(a => a.Email.Contains("@gmail.com")).OrderBy(a=>a.Nome).Select(a => a);

            foreach (var item in ListaFiltrada)
            {
                Console.WriteLine(item.Nome + " - " + item.Email);
            }

            Console.ReadKey();
        }
    }
}
