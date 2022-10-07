using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValadezLeal_R1
{
    class Arreglos
    {
        //METODO PARA HACER EL ARREGLO
        public static int[] Arreglo()
        {
            int[] arreglo = new int[10];

            Random random = new Random();
            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = random.Next(10, 99);
            }
            return arreglo;
        }
        //METODO PARA DESPLEGAR EL ARREGLO
        public static void DesplegarA(int[] arreglo)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(arreglo[i]);
            }
        }
        //METODO QUE IDENTIFICA Y DESPLIEGA EL NUMERO MENOR
        public static void Menor(int[] arreglo)
        {
            int menor = arreglo[0];
            for (int i = 0; i < 10; i++)
            {
                if (arreglo[i] < menor)
                {
                    menor = arreglo[i];
                }
            }
            Console.WriteLine("Numero Menor:  " + menor);
        }

        //METODO QUE IDENTIFICA Y DESPLIEGA EL NUMERO MAYOR
        public static void Mayor(int[] arreglo)
        {
            int mayor = arreglo[0];
            for (int i = 0; i < 10; i++)
            {
                if (arreglo[i] > mayor)
                {
                    mayor = arreglo[i];
                }
            }
            Console.WriteLine("Numero Mayor " + mayor);
        }
        static void Main(string[] args)
        {
            //VARIABLE AUXILIARES
            int[] valor = new int[10];
            char s1;
            do
            {
                Console.Clear();
                Console.Write("MENU ARREGLOS NUMEROS ALETORIOS" + "\na)GENERAR Y DESPLEGAR ARREGLO" +
                "\nb)DETERMINAR Y DESPLEGAR NUMERO MENOR" +
                "\nc)DETERMINAR Y DESPLEGAR NUMERO MAYOR" +
                "\nd)Salir del programa" +
                "\nOpcion: ");

                s1 = char.Parse(Console.ReadLine());

                switch (s1)
                {
                    case 'a':
                        Console.Clear();
                        Console.WriteLine("Arreglo");
                        valor = Arreglo();
                        DesplegarA(valor);
                        Console.WriteLine("Presione enter para regresar al menu");
                        Console.ReadKey();
                        break;

                    case 'b':
                        Console.Clear();
                        Console.WriteLine("Numero Menor");
                        Menor(valor);
                        Console.WriteLine("Presione enter para regresar al menu");
                        Console.ReadKey();
                        break;

                    case 'c':
                        Console.Clear();
                        Console.WriteLine("Numero Mayor");
                        Mayor(valor);
                        Console.WriteLine("Presione enter para regresar al menu");
                        Console.ReadKey();
                        break;

                    case 'd':

                        Console.WriteLine("PRESIONE <ENTER> PARA SALIR DEL PROGRAMA");
                        Console.ReadKey(); break;

                    default:
                        Console.WriteLine("\nNo selecciono ninguna opcion");
                        Console.WriteLine("\nPresione <enter> para regresar al menu");
                        Console.WriteLine();
                        Console.Read();
                        Console.Clear();
                        Console.Read(); break;
                }
            }
            while (s1 != 'd');
        }
    }
}
