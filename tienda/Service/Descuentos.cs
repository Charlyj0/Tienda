using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Service
{
    internal class Descuentos
    {
        public double descu=0;
        public int meses;
        public int cant;
        public double promos(int sum2)
        {
            if (sum2 < 5000)
            {
                Console.WriteLine("El precio total es de $" + sum2);
                Console.WriteLine("-----------------------------------");
            }
            if (sum2 >= 5000 && sum2<8000)
            {
                Console.WriteLine("------Descuento aplicable del 10%------");
                descu = sum2 * .10;
                descu = sum2 - descu; 
                Console.WriteLine("Tu total a pagar es de $" + descu);
                Console.WriteLine("-----------------------------------");
            }
            else if(sum2>=8000 && sum2 < 10000)
            {
                Console.WriteLine("------Descuento aplicable------");
                descu = sum2 / 3;
                Console.WriteLine("Pagaras $" + descu + " cada mes por 3 meses");
                Console.WriteLine("-----------------------------------");
            }
            if (sum2 > 10000)
            {
                Console.WriteLine("------Descuento aplicable------");
                Console.WriteLine("Desea pasar sus articulos a 1) 6 meses ó 2) 12 meses");
                meses = int.Parse(Console.ReadLine());

                do
                {
                    switch (meses)
                    {
                        case 1:
                            descu = sum2 / 6;
                            Console.WriteLine("Pagaras $" + descu + " cada mes por 6 meses");
                            break;
                        case 2:
                            descu = sum2 / 12;
                            Console.WriteLine("Pagaras $" + descu+ " cada mes por 12 meses");
                            break;
                        default:
                            Console.WriteLine("Opcion no valida");
                            break;
                    }
                } while (meses != 1 && meses != 2);
                Console.WriteLine("-----------------------------------");
            }
            return descu;
        }
    }
}
