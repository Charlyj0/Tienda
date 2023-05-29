
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda.Service;

namespace tienda.Entities
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }

        public void Pedir()
        {

            Console.WriteLine("-------TIENDITA 'HYRULE'--------");
            Console.WriteLine("Escriba su nombre");
            this.Nombre = Console.ReadLine();
            Console.WriteLine("Digite su numero de telefono personal");
            Telefono = Console.ReadLine();
            Console.WriteLine("Escriba su correo electronico");
            Correo = Console.ReadLine();

            Console.Clear();
            Articulos art = new Articulos();
            art.Vendido();
        }

        public void Imprimidir()
        {
            Console.WriteLine("Datos de usuario");
            Console.WriteLine("Usuario:" + this.Nombre);
            Console.WriteLine("Telefono:" + Telefono);
            Console.WriteLine("Correo:" + Correo);
        }
    }
}
