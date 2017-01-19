using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teh2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Anna pistemäärä > ");
            numero = int.Parse(Console.ReadLine());

            switch (numero)
            {
                case 0:
                case 1:
                    Console.WriteLine("Numerosi on 0.");
                    break;
                case 2:
                case 3:
                    Console.WriteLine("Numerosi on 1.");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("Numerosi on 2.");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Numerosi on 3.");
                    break;
                case 8:
                case 9:
                    Console.WriteLine("Numerosi on 4.");
                    break;
                case 10:
                case 11:
                case 12: Console.WriteLine("Numerosi on 5.");
                    break;
                default: Console.WriteLine("Anna pistemäärä 0-12 väliltä.");
                    break;
            }
            
        }
    }
}
