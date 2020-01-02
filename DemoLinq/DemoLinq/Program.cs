using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoLinq
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<string> cidades = new List<string>();

            cidades.Add("São Paulo");
            cidades.Add("São Judas");
            cidades.Add("Rio de Janeiro");
            cidades.Add("Florianópolis");
            cidades.Add("Videira");
            
            //retornando um item
            Console.WriteLine(BuscarPrimeiroComForeach(cidades, "São Paulo"));
            //Console.WriteLine(BuscarPrimeiroComLinq(cidades, "São Paulo"));
            //Console.WriteLine(BuscarPrimeiroComLinqLambda(cidades, "São Paulo"));
            
            //retornando muitos itens
            BuscarPrimeiroComLinq(cidades, "Sã").ForEach(x => Console.WriteLine(x));
            BuscarPrimeiroComLinqLambda(cidades, "Sã").ForEach(x => Console.WriteLine(x));
            Console.ReadKey();
        }

       
        public static string BuscarPrimeiroComForeach(List<string> lista, string termo)
        {
            foreach (string item in lista)
            {
                if (item.Equals(termo))
                    return item;
            }
            return null;
        }
        
        //retornando um item
       
        /*public static string BuscarPrimeiroComLinq(List<string> lista, string termo)
        {
            return (from item in lista where item.Equals(termo) select item).First();
        }*/
        
        //retornando muitos itens
        
        public static List<string> BuscarPrimeiroComLinq(List<string> lista, string termo)
        {
            return (from item in lista where item.Contains(termo) select item).ToList();
        }
        
        //retornando um item

        /*public static string BuscarPrimeiroComLinqLambda(List<string> lista, string termo)
        {
            return lista.First(x => x.Equals(termo));
        }*/
        
        //retornando muitos itens
        
        public static List<string> BuscarPrimeiroComLinqLambda(List<string> lista, string termo)
        {
            return lista.Where(x => x.Contains(termo)).ToList();
        }
        
    }
}