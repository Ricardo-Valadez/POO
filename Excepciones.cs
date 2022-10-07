using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Libreria necesaria
using System.IO;

namespace ValadezLeal_U6
{
    class Program
    {
        //Clase alumnos
        public class Alumnos
        {
            //Flujos binarios
            BinaryWriter BW = null; //declaración flujo de escritura
            BinaryReader BR = null; //declaración flujo de lectura

            //Campos de la clase
            int NumeroControl;
            string Nombre, Carrera;
            byte Semestre;
            string Materia;
            float Calificacion1, Calificacion2, Calificacion3, Promedio;


            //Método Crear archivo
            public void CrearArchivo(string Archivo)
            {
                //Campo para repetir
                char Rep;

                try
                {
                    BW = new BinaryWriter(new FileStream(Archivo, FileMode.Create, FileAccess.Write));

                    do
                    {
                        Console.Clear();
                        //datos del alumno
                        Console.WriteLine("Datos Alumno");
                        Console.Write("Número de Control: ");
                        NumeroControl = Int32.Parse(Console.ReadLine());
                        Console.Write("Nombre: ");
                        Nombre = Console.ReadLine();
                        Console.Write("Carrera:");
                        Carrera = Console.ReadLine();
                        Console.Write("Semestre: ");
                        Semestre = Byte.Parse(Console.ReadLine());
                        Console.Write("Materia: ");
                        Materia = Console.ReadLine();
                        Console.Write("Primera Calificacion: ");
                        Calificacion1 = Single.Parse(Console.ReadLine());
                        Console.Write("Segunda Calificacion: ");
                        Calificacion2 = Single.Parse(Console.ReadLine());
                        Console.Write("Tercera Calificacion: ");
                        Calificacion3 = Single.Parse(Console.ReadLine());
                        Promedio = (Calificacion1 + Calificacion2 + Calificacion3) / 3;

                        //Envio de datos al disco 
                        BW.Write(NumeroControl);
                        BW.Write(Nombre);
                        BW.Write(Carrera);
                        BW.Write(Semestre);
                        BW.Write(Materia);
                        BW.Write(Calificacion1);
                        BW.Write(Calificacion2);
                        BW.Write(Calificacion3);
                        BW.Write(Promedio);
                        Console.WriteLine("\nQuiere crear otro registro (s/n)? ");
                        Rep = Char.Parse(Console.ReadLine());

                    } while (Rep == 's');
                }
                catch (FormatException x)
                {
                    Console.WriteLine("\nMensaje del error : " + x.Message);
                    Console.WriteLine("Ruta del error: " + x.StackTrace);
                    Console.WriteLine("Presione enter para continuar...");
                    Console.ReadKey();
                }
                catch (ArgumentException x)
                {
                    Console.WriteLine("Mensaje del Error: " + x.Message);
                    Console.WriteLine("Ruta del Error: " + x.StackTrace);
                }

                finally
                {
                    if (BW != null)
                        BW.Close();
                    Console.WriteLine("\nEl finally siempre se ejecuta...");
                    Console.WriteLine("\nPresione <enter> para continuar");
                    Console.ReadKey();
                }
            }

            //Método Leer archivo
            public void MostrarArchivo(string Archivo)
            {
                try
                {
                    if (File.Exists(Archivo))
                    {
                        Console.Clear();
                        BR = new BinaryReader(new FileStream(Archivo, FileMode.Open, FileAccess.Read));

                        do
                        {
                            //Lectura de datos
                            NumeroControl = BR.ReadInt32();
                            Nombre = BR.ReadString();
                            Carrera = BR.ReadString();
                            Semestre = BR.ReadByte();
                            Materia = BR.ReadString();
                            Calificacion1 = BR.ReadSingle();
                            Calificacion2 = BR.ReadSingle();
                            Calificacion3 = BR.ReadSingle();
                            Promedio = BR.ReadSingle();

                            //Impresión de datos
                            Console.WriteLine("..........Alumno........");
                            Console.WriteLine("Número de Control: " + NumeroControl);
                            Console.WriteLine("Nombre: " + Nombre);
                            Console.WriteLine("Carrera: " + Carrera);
                            Console.WriteLine("Semestre: " + Semestre);
                            Console.WriteLine("Materia: " + Materia);
                            Console.WriteLine("Calificación Primera Unidad: " + Calificacion1);
                            Console.WriteLine("Calificación Segunda Unidad: " + Calificacion2);
                            Console.WriteLine("Calificación Tercera Unidad: " + Calificacion3);
                            Console.WriteLine("Promedio Final:" + Promedio);
                            Console.WriteLine("...........................");

                        } while (true);
                    }
                    else
                    {
                        Console.WriteLine("\nEl arhcivo " + Archivo + " No Existe");
                        Console.WriteLine("Presione <enter> para continuar");
                        Console.ReadKey();
                    }
                }
                catch (FormatException x)
                {
                    Console.WriteLine("\nMensaje del error : " + x.Message);
                    Console.WriteLine("Ruta del error: " + x.StackTrace);
                    Console.WriteLine("Presione enter para continuar...");
                    Console.ReadKey();
                }
                catch (ArgumentException x)
                {
                    Console.WriteLine("Mensaje del Error: " + x.Message);
                    Console.WriteLine("Ruta del Error: " + x.StackTrace);
                }

                finally
                {
                    if (BR != null)
                        BR.Close();
                    Console.WriteLine("\nEl finally siempre se ejecuta...");
                    Console.WriteLine("\nPresione <enter> para continuar");
                    Console.ReadKey();
                }

            }

            ~Alumnos()
            {
                Console.WriteLine("MEMORIA LIBERADA DE LA CLASE ALUMNOS");

            }
        }


        static void Main(string[] args)
        {  

            char s1;
            string Archivo;

            Alumnos Al = new Alumnos();

            do
            {
                Console.Clear();
                Console.WriteLine("MENU Archivos" +
                    "\n........................................");
                Console.Write("Elige una opcion\n" +
                "\na) Crear archivo" +
                "\nb) Leer archivo" +
                "\nc) Salir del programa" +
                "\nOpcion que deseas: ");
                s1 = Char.Parse(Console.ReadLine());

                switch (s1)
                {
                    case 'a':
                        {
                            //bloque de escritura
                            try
                            {
                                //captura nombre archivo
                                Console.Clear();
                                Console.WriteLine("INGRESE EL NOMBRE DEL ARCHIVO A CREAR (NO OLVIDES EL .txt)");
                                Console.Write("Nombre : ");
                                Archivo = Console.ReadLine();

                                //verifica si existe el archivo
                                char resp = 's';
                                if (File.Exists(Archivo))
                                {
                                    Console.Write("\nEl Archivo Existe!!, Deseas Sobreescribirlo (s/n)? ");
                                    resp = Char.Parse(Console.ReadLine());
                                }
                                if ((resp == 's') || (resp == 'S'))
                                    Al.CrearArchivo(Archivo);
                            }
                            catch (IOException e)
                            {
                                Console.WriteLine("\nError : " + e.Message);
                                Console.WriteLine("\nRuta : " + e.StackTrace);
                            }
                        }
                        break;
                    case 'b':
                        {
                            //bloque de lectura
                            try
                            {
                                //captura nombre archivo
                                Console.Clear();
                                Console.WriteLine("INGRESE EL NOMBRE DEL ARCHIVO A LEER  (NO OLVIDES EL .txt)");
                                Console.Write("Nombre : ");
                                Archivo = Console.ReadLine();
                                Al.MostrarArchivo(Archivo);
                            }
                            catch (IOException e)
                            {
                                Console.WriteLine("\nError : " + e.Message);
                                Console.WriteLine("\nRuta : " + e.StackTrace);
                            }
                        }
                        break;
                    case 'c':
                        {
                            Console.WriteLine("Presione <Enter> para cerrar el programa");
                            Console.ReadKey();
                        }
                        break;

                    default:
                        {
                            Console.WriteLine("\nNo selecciono ninguna opcion");
                            Console.WriteLine("\nPresione <enter> para regresar al menu");
                            Console.WriteLine();
                            Console.Read();
                            Console.Clear();
                            Console.Read();
                        }
                        break;
                }
            } while (s1 != 'c');

        }
    }
}
