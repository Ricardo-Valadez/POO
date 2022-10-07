using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValadezLeal_U5
{
    class Program
    {

        static void Main(string[] args)
        {
            //VARIBLE PARA EL MENU
            char s1;
            //CREACION DEL CICLO DO WHILE
            do
            {
                Console.WriteLine("MENU Logaritmos " +
                    "\n--------------------------");
                Console.WriteLine("Elige una opcion\n" +
                "\na) Calcular Logaritmos" +
                "\nb) Salir del programa");
                Console.Write("Opcion : ");


                s1 = char.Parse(Console.ReadLine());
                //MEDIANTE UN SWITCH LOGRAMOS HACER UN MENU CON VARIAS OPCIONES
                switch (s1)
                {
                    //CASE PARA LA OPERACION DE LOGARITMO
                    case 'a':
                        try
                        {
                            //VARIABLES NECESARIAS PARA LOGRAR LA OPERACION
                            int Base;
                            double LogaritmoN, Base10;
                            Console.Clear();
                            Console.Write("Ingrese el valor de base : ");
                            Base = Int32.Parse(Console.ReadLine());
                            //OPERACIONES
                            LogaritmoN = (int)(Math.Log(Base));
                            Base10 = (int)(Math.Log10(Base));

                            //EXCEPCION PARA UN NUMERO MAS GRANDE
                            if (Base > 500000)
                            {
                                throw new ArgumentOutOfRangeException();
                            }
                            //Exepción PARA EL VALOR IGUAL A CERO
                            else if (Base == 0)
                            {
                                throw new NullReferenceException("NO PUEDE SER IGUAL A 0");
                            }
                            //EXCEPCION PARA UN NUMERO NEGATIVO
                            else if (Base < 0)
                            {
                                throw new InvalidOperationException("NO PUEDE SER UN NUMERO NEGATIVO");
                            }
                            //YA QUE LOS REQUERIMIENTO SON CUMPLIDOS SE DESPLIEGA EL RESULTADO
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Datos del logaritmo");
                                Console.WriteLine("Valor de la base: " + Base);
                                Console.WriteLine("Logaritmo Natural: " + +LogaritmoN);
                                Console.WriteLine("Logaritmo Base: " +Base10 );
                                Console.Write("Presione <ENTER> para continuar...");
                                Console.ReadKey();
                            }


                        }
                        //EXCEPCION ArgumentOutOfRangeException
                        catch (ArgumentOutOfRangeException ax)
                        {
                            Console.WriteLine("\nMensaje del Error: " + ax.Message);
                            Console.WriteLine("\nRuta del Error: " + ax.StackTrace);
                            Console.Write("\nPresione <enter> para continuar...");
                            Console.ReadKey();
                        }
                        // EXCEPCION FormatException
                        catch (FormatException fx)
                        {
                            Console.WriteLine("\nMensaje del Error: " + fx.Message);
                            Console.WriteLine("\nRuta del Error: " + fx.StackTrace);
                            Console.Write("\nPresione <enter> para continuar...");
                            Console.ReadKey();
                        }
                        //EXCEPCION NullReferenceException
                        catch (NullReferenceException s)
                        {
                            Console.WriteLine("\nMensaje del Error: " + s.Message);
                            Console.WriteLine("\nRuta del Error: " + s.StackTrace);
                            Console.Write("\npresione <enter> para continuar...");
                            Console.ReadKey();
                        }
                        //EXCEPCION InvalidOperationException
                        catch (InvalidOperationException f)
                        {
                            Console.WriteLine("\nMensaje del Error: " + f.Message);
                            Console.WriteLine("\nRuta del Error: " + f.StackTrace);
                            Console.Write("\npresione <enter> para continuar...");
                            Console.ReadKey();
                        }
                        //EL FINALLY SIEMPRE SE EJECUTA
                        finally
                        {
                            Console.WriteLine("\nEl finally siempre se ejecuta.");
                            Console.WriteLine("\npresione <enter> para continuar...");
                            Console.ReadKey();
                        }
                        Console.Clear();
                        break;
                    //CASE PARA CERRAR EL PROGRAMA
                    case 'b':
                        break;
                    //CASE DEFAULT
                    default:
                        Console.WriteLine("\nNo selecciono ninguna opcion");
                        Console.WriteLine("\nPresione <enter> para regresar al menu");
                        Console.WriteLine();
                        Console.Read();
                        Console.Clear();
                        Console.Read();
                        break;
                }

                // PARA CERRAR EL CICLO SE ELIJE LA OPCION "b"
            } while (s1 != 'b');
        }
    }
}
