using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace PruebasUnidad
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] parts = null;
            int[] en = null;
            string[] ins = null;


            string ln;
            string otp =DateTime.Now.ToString() + "\r\n";
     
            int t = 0;
            int tf = 0;
            double aa = 0;

            Medias mds;
            Stopwatch zw = new Stopwatch();

            try
            {
                StreamReader sr =
                    //utiliza la direccion de donde se encuentra el archivo para leerlo
                new StreamReader("C:/Users/ASKII.DESKTOP-D39ELPS/Documents/gitStuff/automatizar-pruebas-unitarias-2019-Shernandezglez/CasosPrueba.txt");

                

                //imprime la linea de texto mientras aun haya contenido para leer
                while ((ln = sr.ReadLine()) != null)
                {

                    zw.Start();
                    parts = ln.Split(':');
                    Console.WriteLine(ln);
                    otp += ln + ":";
                  
                    //Console.WriteLine(" ");
                    
                    //for (int i = 0; i <= parts.Length-1; i++)
                    //{
                    //    Console.WriteLine(parts[i]);

                    //}
                    
                 
                    try
                    {
                        ins = new string[2];

                        if (parts[2] == "NULL")
                        {
                            Console.WriteLine("Entradas nulas");
                        }
              

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


                        if (parts[1] == "mediaAritmetica")
                        {
                            double x = 0;
                            x = Medias.mediaAritmetica(en);
                            x = Math.Round(x, 4);
                            otp += " " + "Calculo: " + x;

                            if (x == aa)
                            {
                                Console.WriteLine("Exito", Console.ForegroundColor = ConsoleColor.Green);
                                Console.ResetColor();
                                otp += " " + "Resultado: " + " Exito";                               
                                t += 1;
                            }

                            else
                            {
                                Console.WriteLine("Fallo" , Console.ForegroundColor = ConsoleColor.Red);
                                Console.ResetColor();
                                otp += " " + "Resultado: " + " Fallo";
                                tf += 1;
                            }
                            
                        }

                        else if (parts[1] == "mediaGeometrica")
                        {
                            double x = 0;
                            mds = new Medias();

                            x = mds.mediaGeometrica(en);
                            x = Math.Round(x, 4);
                            otp += " " + "Calculo: " + x;
                            if (x == aa)
                            {

                                Console.WriteLine("Exito" , Console.ForegroundColor = ConsoleColor.Green);
                                Console.ResetColor();
                                otp += " " + "Resultado: " + " Exito";
                                t += 1;
                            }

                            else
                            {
                                Console.WriteLine("Fallo" , Console.ForegroundColor = ConsoleColor.Red);
                                Console.ResetColor();
                                otp += " " + "Resultado: " + " Fallo";
                                tf += 1;
                            }

                            
                        }
                        else if (parts[1] == "mediaArmonica")
                        {
                            double x = 0;


                            x = Medias.mediaArmonica(en);
                            x = Math.Round(x, 4);
                            otp += " " + "Calculo: " + x;
                            if (x == aa)
                            {

                                Console.WriteLine("Exito" , Console.ForegroundColor = ConsoleColor.Green);
                                Console.ResetColor();
                                otp += " " + "Resultado: " + " Exito";
                                t += 1;
                            }

                            else
                            {
                                Console.WriteLine("Fallo", Console.ForegroundColor = ConsoleColor.Red);
                                Console.ResetColor();
                                otp += " " + "Resultado: " + " Fallo";
                                tf += 1;
                            }

                            
                        }




                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Fallo", Console.ForegroundColor = ConsoleColor.Red);
                        Console.ResetColor();
                        Console.WriteLine("Excepcion de salida");
                        otp += " " + "Resultado: " + " Excepcion";
                        tf += 1;
                       
                        
                    }
                    zw.Stop();
                    Console.WriteLine("Tiempo: " + zw.Elapsed);
                    Console.WriteLine("--------------------------------------------------------------");
                    otp += " " + "Tiempo de ejecucion: " + zw.Elapsed + "\r\n";
                    zw.Reset();
                    
                }

                Console.WriteLine("Fin de la prueba" + "\n" + "-----------------------------------------------------------");
                Console.WriteLine("Exitos: " + t.ToString() + "\n" + "Fallos: " + tf.ToString());

               

                sr.Close();

               
                Console.ReadLine();

                
            }
            catch (Exception e)

            {
                Console.WriteLine("Exception: " + e.Message);
            }

            Console.WriteLine("Executing finally block.");

            using (StreamWriter swt = new StreamWriter("C:/Users/ASKII.DESKTOP-D39ELPS/Documents/gitStuff/Pruebas.txt"))
            {
                swt.WriteLine(otp);
            }




        }


    }
}
