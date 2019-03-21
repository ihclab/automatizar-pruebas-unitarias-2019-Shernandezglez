using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PruebasUnidad
{
    class Program
    {
        static void Main(string[] args)
        {
            String ln;

            try
            {
                StreamReader sr =
                new StreamReader("C:/Users/ASKII.DESKTOP-D39ELPS/Documents/gitStuff/automatizar-pruebas-unitarias-2019-Shernandezglez/CasosPrueba.txt");

                ln = sr.ReadLine();

                
                

                while (ln != null)
                {
                    Console.WriteLine(ln);
                    ln = sr.ReadLine();
                    
                }
                Console.WriteLine(" ");
                
                
                Console.ReadLine();
            } catch (Exception e)

            {
                Console.WriteLine("Exception: " + e.Message);
            }
            Console.WriteLine("Executing finally block.");


            


        }
    }
}
