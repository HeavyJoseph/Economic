using Economic.Core.Repositories;
using System;

namespace Economic.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            EntidadesRepository rep = new EntidadesRepository();

            Console.WriteLine(rep.Find(x => x.Id == 1).Apellido);
            
            Console.ReadKey();
        }
    }
}
