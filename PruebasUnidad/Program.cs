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
            string ln;
            string[] parts = null;
            int[] en = null;
            double s = 0;
            string[] ins = null;
            
            try
            {
                StreamReader sr =
                    //utiliza la direccion de donde se encuentra el archivo para leerlo
                new StreamReader("C:/Users/ASKII.DESKTOP-D39ELPS/Documents/gitStuff/automatizar-pruebas-unitarias-2019-Shernandezglez/CasosPrueba.txt");

                ln = sr.ReadLine();

                //imprime la linea de texto mientras aun haya contenido para leer
                while (ln != null)
                {
                    Console.WriteLine(ln);
                    parts = ln.Split(':');
                    Console.WriteLine(" ");
                    for (int i = 0; i <= parts.Length-1; i++)
                    {
                        Console.WriteLine(parts[i]);

                    }
                    Console.WriteLine(" ");

                    ins = new string[2];



                    ins[0] = parts[2];
                    ins[1] = parts[3];
                    string c = ins[0];
                    string c2 = ins[1];
                    
                    s = double.Parse(c2);
                    ins = new string[c.Length];
                    ins = c.Split(' ');
                    
                    
                    en = new int[ins.Length];
                    
                    for(int i = 0; i <= ins.Length-1; i++)
                    {
                        en[i] = int.Parse(ins[i]);
                        
                    }

                    ln = sr.ReadLine();
                    
                }
                
                sr.Close();
                Console.ReadLine();
            } catch (Exception e)

            {
                Console.WriteLine("Exception: " + e.Message);
            }
            Console.WriteLine("Executing finally block.");


            
            

        }
    }
}
