using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace compañia_electrica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de kWh consumidos en el mes: ");
            string consumotxt = Console.ReadLine();

            float consumo = float.Parse(consumotxt);

            float costo = 0f;

            if (consumo <= 100)
            {
                costo = consumo * 0.1f;
            }
            else if (consumo <= 300)
            {
                costo = 100 * 0.1f + (consumo - 100) * 0.2f;
            }
            else
            {
                costo = 100 * 0.1f + 200 * 0.2f + (consumo - 300) * 0.3f;
            }

            Console.WriteLine("Su factura es de: $" + costo);
            Console.ReadKey();
        }
    }
}