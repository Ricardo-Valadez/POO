using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//LIBRERIA 
using Perimetros;

namespace ValadezLeal_U4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable para usar el menu
            String s1 = null;
            //Creacion de un ciclo do while
            do
            {
                //CAMPOS AUXILIARES
                int numlados;
                float Base, altura, lados, lado;
                //OPCIONES DEL MENU
                Console.WriteLine("Elige una opcion\n" +
                "\n1= Calcular Perimetro de un Rombo" +
                "\n2= Calcular Perimetro de un Romboide" +
                "\n3= Calcular Perimetro de un Poligono Regular" +
                "\n4= Salir del programa");

                s1 = Console.ReadLine();
                //Mediante un swich creamos un menu que puede realizar varias acciones 
                switch (s1)
                {
                    //CASE PARA EL PERIMETRO DEL ROMBO
                    case "1":
                        Console.Clear();
                        Console.Write("Ingrese el valor del lado del rombo: ");
                        lado = float.Parse(Console.ReadLine());
                        //CREACION DE OBJETOS DE LA CLASE DERIVADA
                        Rombo val1 = new Rombo(lado);
                        Console.WriteLine("...........................");
                        val1.DesplegarPerimetro();
                        Console.WriteLine("...........................");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    //CASE PARA EL PERIMETRO DEL ROMBOIDE
                    case "2":
                        Console.Clear();
                        Console.Write("Ingrese la base del romboide: ");
                        Base = float.Parse(Console.ReadLine());
                        Console.Write("Ingrese la altura del romboide: ");
                        altura = float.Parse(Console.ReadLine());
                        //CREACION DE OBJETOS DE LA CLASE DERIVADA
                        Romboide val2 = new Romboide(Base, altura);
                        Console.WriteLine("...........................");
                        val2.DesplegarPerimetro();
                        Console.WriteLine("...........................");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    //CASE PARA EL PERIMETRO DEL POLIGONO REGULAR
                    case "3":
                        Console.Clear();
                        Console.Write("Ingrese el valor del lado del Poligono Regular: ");
                        lados = float.Parse(Console.ReadLine());
                        Console.Write("Ingrese el numero del lados del Poligono Regular: ");
                        numlados = Int32.Parse(Console.ReadLine());
                        //CREACION DE OBJETOS DE LA CLASE DERIVADA
                        PoligonoRegular val3 = new PoligonoRegular(lados, numlados);
                        Console.WriteLine("...........................");
                        val3.DesplegarPerimetro();
                        Console.WriteLine("...........................");
                        Console.ReadKey();
                        Console.Clear();
                        break;


                    case "4":
                        Environment.Exit(0);
                        break;

                    //Case default si el valor no es ninguno de los que queremos
                    default:
                        Console.WriteLine("\nNo selecciono ninguna opcion");
                        Console.WriteLine("\nPresione <enter> para regresar al menu");
                        Console.WriteLine();
                        Console.Read();
                        Console.Clear();
                        Console.Read();
                        break;
                }
            } while (s1 != "4");
        }
    }
}
