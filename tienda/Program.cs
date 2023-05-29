using System;
using tienda.Entities;
using Tienda.Service;

namespace Tienda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Usuario user = new Usuario();
            user.Pedir();
            user.Imprimidir();
        }
    }
}
