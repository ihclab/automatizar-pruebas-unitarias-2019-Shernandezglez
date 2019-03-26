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
            double x = 0;
            string[] ins = null;
            double aa = 0;


            try
            {
                StreamReader sr =
                    //utiliza la direccion de donde se encuentra el archivo para leerlo
                new StreamReader("C:/Users/ASKII.DESKTOP-D39ELPS/Documents/gitStuff/automatizar-pruebas-unitarias-2019-Shernandezglez/CasosPrueba.txt");

                

                //imprime la linea de texto mientras aun haya contenido para leer
                while ((ln = sr.ReadLine()) != null)
                {
                    Console.WriteLine(ln);
                  
                    parts = ln.Split(':');
                    Console.WriteLine(" ");
                    
                    for (int i = 0; i <= parts.Length-1; i++)
                    {
                        Console.WriteLine(parts[i]);

                    }
                    
                    Console.WriteLine(" ");
                    try
                    {
                        ins = new string[2];

                        if (parts[2] == "NULL")
                        {
                            Console.WriteLine("Entradas nulas");
                        }
                        Console.WriteLine(" ");
                        ins[0] = parts[2];
                        ins[1] = parts[3];
                        string c = ins[0];
                        string c2 = ins[1];
                         aa = double.Parse(c2);

                        ins = new string[c.Length];
                        ins = c.Split(' ');


                        en = new int[ins.Length];

                        for (int i = 0; i <= ins.Length - 1; i++)
                        {
                            en[i] = int.Parse(ins[i]);
                            
                        }
                        
                       

                        x = Medias.mediaAritmetica(en);
                        x = Math.Round(x, 4);
                        //int cn = 0;

                        if (x == aa)
                        {
                            Console.WriteLine("exito");
                            //int ex = cn + 1;
                            
                        }
                        else
                        {
                            Console.WriteLine("fallo");
                           
                        }

                        

                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("Exception: " + e.Message);
                    }
                    
                }



               

                sr.Close();

               
                Console.ReadLine();
            }
            catch (Exception e)

            {
                Console.WriteLine("Exception: " + e.Message);
            }
            Console.WriteLine("Executing finally block.");


            
            

        }
    }
}
