using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tienda.Entities;
using Tienda.Entities;

namespace Tienda.Service
{
    public class Articulos
    {
        public int Resp;
        public int Cant, sum, sum2=0;
        public int fin;
        public void Vendido()
        {
            Inventario inve = new Inventario();
            do
            {

            Console.WriteLine("-----------------------PRODUCTOS EN VENTA------------------------");
            Console.WriteLine("|1) Iphone 11 ...............$"+inve.Iphone+"                               |        MONTO ACTUAL:" + sum2);
            Console.WriteLine("|2) TLOZ Edicion D coleecion......$"+inve.Zelda_c+"                          |");
            Console.WriteLine("|3) NSO Edicion Tears of the kingdom...........$"+inve.nintendo_Oled+"             |");
            Console.WriteLine("|4) Xbox series X.............$"+inve.xbox+"                              |");
            Console.WriteLine("|5) Lata de atún dolores..........$"+inve.atun+"                          |");
            Console.WriteLine("-----------------------------------------------------------------");

            Console.WriteLine("¿Que articulos desea comprar?");
            Resp = int.Parse(Console.ReadLine());


                switch (Resp)       
                {
                    case 1:
                        Console.WriteLine("--------------Articulo 'Iphone 11'--------------");
                        Console.WriteLine("Cuantos desea comprar?");
                        Cant = int.Parse(Console.ReadLine());
                        sum = inve.Iphone * Cant;
                        Console.WriteLine("El total es " + sum);
                        break;
                    case 2:
                        Console.WriteLine("--------------Articulo 'TLOZ Edicion D coleecion'--------------");
                        Console.WriteLine("Cuantos desea comprar?");
                        Cant = int.Parse(Console.ReadLine());
                        sum = inve.Zelda_c * Cant;
                        Console.WriteLine("El total es " + sum);
                        break;

                    case 3:
                        Console.WriteLine("--------------Articulo 'NSO Edicion Tears of the kingdom'--------------");
                        Console.WriteLine("Cuantos desea comprar?");
                        Cant = int.Parse(Console.ReadLine());
                        sum = inve.nintendo_Oled * Cant;
                        Console.WriteLine("El total es " + sum);
                        break;

                    case 4:
                        Console.WriteLine("--------------Articulo 'Xbox series X'--------------");
                        Console.WriteLine("Cuantos desea comprar?");
                        Cant = int.Parse(Console.ReadLine());
                        sum = inve.xbox * Cant;
                        Console.WriteLine("El total es " + sum);
                        break;

                    case 5:
                        Console.WriteLine("--------------Articulo 'Lata de atún dolores'--------------");
                        Console.WriteLine("Cuantos desea comprar?");
                        Cant = int.Parse(Console.ReadLine());
                        sum =   inve.atun * Cant;
                        Console.WriteLine("El total es " + sum);
                        break;

                    default:
                        Console.WriteLine("Articulo desconocido");
                        break;
                }
                sum2 = sum2 + sum;
                Console.WriteLine("¿Desea seguir comprando? 1)continuar - 2)salir");
                fin = int.Parse(Console.ReadLine());
                Console.Clear();
            } while (fin != 2);
            Console.WriteLine("---------------------------------------------------");
            
            Descuentos buenf = new Descuentos();
            buenf.promos(sum2);


        }
    }
}
 