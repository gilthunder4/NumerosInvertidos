using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosInvertidos
{
    class Program
    {
        static void Main(string[] args)
        {
             int aux, dec, uni,num;
             Console.WriteLine("Ingrese un numero de dos cifras: ");
             num = Int16.Parse(Console.ReadLine());
             //decimal = al numero ingresado / 10  EJ: 25/10 = 2
             dec = num / 10;
             //unidad = al numero ingresado % 10 EJ: 25/10 = 5
             uni = num % 10;
             //aux = valos de la unidad x 10 + el valor decimal
             //EJ: 5 * 10 = 50 + 2 = 52 invertido de 25
             aux = (uni * 10) + dec;
            Console.WriteLine("El numero invertido es: {0}",aux);
            Console.WriteLine("Pulse una tecla");
            Console.ReadLine();
            
        }
    }
}
