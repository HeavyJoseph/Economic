using Economic.Core.Repositories;
using System;

namespace Economic.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            EntidadesTipoRepository rep = new EntidadesTipoRepository();

            Console.WriteLine(rep.Find(x => x.Id == 1).Descripcion);
            
            Console.ReadKey();
        }
    }
}
