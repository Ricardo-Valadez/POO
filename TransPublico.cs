using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValadezLeal_U3
{
    class Program
    {
        //CLASE BASE 
        public class TransportePublico
        {
            //CAMPOS DE LA CLASE BASE
            public string Marca,Modelo;
            public int Año;

            //CONSTRUCTOR DE LA CLASE BASE 
            public TransportePublico(string Marca,string Modelo,int Año)
            {
                this.Marca = Marca;
                this.Modelo = Modelo;
                this.Año = Año;
            }
            //METODO QUE VAMOS A HEREDAR 
            public void ImprimirTransporte()
            {
                Console.WriteLine("Marca del transporte " + Marca);
                Console.WriteLine("Modelo " + Modelo );
                Console.WriteLine("Año " + Año);
            }
            //DESTRUCTOR
            ~TransportePublico()
            {
                Console.WriteLine("MEMORIA LIBERADA CLASE BASE TRANSPORTE PUBLICO ");
            }
        }
        //CLASE DERIVADA DE LA CLASE TRANSPORTE PUBLICO
        public class Camion : TransportePublico
        {
            //CAMPOS EXCLUSIVOS DE LA CLASE DERIVADA
            string NombreChofer;
            int NumeroPasajeros;

            //CONSTRUCTOR CON LOS CAMPOS DE LA CLASE BASE Y PROPIOS
            public Camion(string Marca,string Modelo, int Año, string NombreChofer, int NumeroPasajeros) : base(Marca, Modelo, Año)
            {
                this.Marca = Marca;
                this.Modelo = Modelo;
                this.Año = Año;

                this.NombreChofer = NombreChofer;
                this.NumeroPasajeros = NumeroPasajeros;
            }
            //REUTILIZAR EL METODO PARA DESPLEGAR LA INFORMACION 
            new public void ImprimirTransporte()
            {
                Console.Clear();
                Console.WriteLine("..................DATOS DEL CAMION..................");
                base.ImprimirTransporte();
                Console.WriteLine("Nombre del chofer " + NombreChofer);
                Console.WriteLine("Numero de pasajeros " + NumeroPasajeros);

            }
            //DESTRUCTOR
            ~Camion()
            {
                Console.WriteLine("MEMORIA LIBERADA OBJETO CAMION " + NombreChofer);
            }
        }
        //CLASE DERIVADA DE LA CLASE TRANSPORTE PUBLICO
        public class Taxi : TransportePublico
        {
            //CAMPOS EXCLUSIVOS DE LA CLASE DERIVADA
            string NombreConductor;
            int NumeroLicencia;
           
            //CONSTRUCTOR CON LOS CAMPOS DE LA CLASE BASE Y PROPIOS
            public Taxi(string Marca, string Modelo, int Año, string NombreConductor, int NumeroLicencia) : base(Marca, Modelo, Año)
            {
                this.Marca = Marca;
                this.Modelo = Modelo;
                this.Año = Año;

                this.NombreConductor = NombreConductor;
                this.NumeroLicencia = NumeroLicencia;
            }
            //REUTILIZAR EL METODO PARA DESPLEGAR LA INFORMACION 
            new public void ImprimirTransporte()
            {
                Console.WriteLine("..................DATOS DEL TAXI..................");
                base.ImprimirTransporte();
                Console.WriteLine("Nombre del conductor " + NombreConductor);
                Console.WriteLine("Numero de licencia " + NumeroLicencia);

            }
            //DESTRUCTOR
            ~Taxi()
            {
                Console.WriteLine("MEMORIA LIBERADA OBJETO TAXI " + NombreConductor);
            }
        }
        //CLASE DERIVADA DE LA CLASE TRANSPORTE PUBLICO
        public class Metro : TransportePublico
        {
            //CAMPOS EXCLUSIVOS DE LA CLASE DERIVADA
            string NombreMaquinista;
            int NumeroVagones;

            //CONSTRUCTOR CON LOS CAMPOS DE LA CLASE BASE Y PROPIOS
            public Metro(string Marca, string Modelo, int Año, string NombreMaquinista, int NumeroVagones) : base(Marca, Modelo, Año)
            {
                this.Marca = Marca;
                this.Modelo = Modelo;
                this.Año = Año;

                this.NombreMaquinista = NombreMaquinista;
                this.NumeroVagones = NumeroVagones;
            }
            //REUTILIZAR EL METODO PARA DESPLEGAR LA INFORMACION 
            new public void ImprimirTransporte()
            {
                Console.WriteLine("..................DATOS DEL METRO..................");
                base.ImprimirTransporte();
                Console.WriteLine("Nombre del maquinista " + NombreMaquinista);
                Console.WriteLine("Numero de vagones " + NumeroVagones);
                Console.WriteLine("...................................................");
            }
            //DESTRUCTOR
            ~Metro()
            {
                Console.WriteLine("MEMORIA LIBERADA OBJETO METRO " + NombreMaquinista);
            }
            

        }
        static void Main(string[] args)
        {
            //VARIABLES AUXILIARES DE CADA CLASE
            string Marca, Modelo, NombreChofer, NombreConductor, NombreMaquinista;
            int Año, NumeroPasajeros, NumeroLicencia, NumeroVagones;
            //AGREGAMOS LA VARIABLES DE CADA OBJETO
            Console.Write("INGRESE LA MARCA DEL TRANSPORTE: ");
            Marca = Console.ReadLine();
            Console.Write("INGRESE EL MODELO: ");
            Modelo = Console.ReadLine();
            Console.Write("INGRESE EL Año: ");
            Año = Int32.Parse(Console.ReadLine());

            Console.Write("INGRESE NOMBRE DEL CHOFER DEL CAMION: ");
            NombreChofer = Console.ReadLine();
            Console.Write("INGRESE NUMERO DE PASAJEROS: ");
            NumeroPasajeros = Int32.Parse(Console.ReadLine());

            Console.Write("INGRESE NOMBRE DEL CONDUCTOR DEL TAXI: ");
            NombreConductor = Console.ReadLine();
            Console.Write("INGRESE NUMERO DE LICENCIA: ");
            NumeroLicencia = Int32.Parse(Console.ReadLine());

            Console.Write("INGRESE NOMBRE DEL MAQUINISTA DEL METRO: ");
            NombreMaquinista = Console.ReadLine();
            Console.Write("INGRESE NUMERO DE VAGONES: ");
            NumeroVagones = Int32.Parse(Console.ReadLine());
            
            
            //CREACION DE LOS OBJETOS PARA EJECUTAR SUS METODOS DE DESPLIEGUE
            TransportePublico CB = new TransportePublico(Marca,Modelo,Año);
            Camion val1 = new Camion(CB.Marca, CB.Modelo, CB.Año,NombreChofer,NumeroPasajeros);
            val1.ImprimirTransporte();
            Taxi val2 = new Taxi(CB.Marca, CB.Modelo, CB.Año, NombreConductor, NumeroLicencia);
            val2.ImprimirTransporte();
            Metro val3 = new Metro(CB.Marca, CB.Modelo, CB.Año, NombreMaquinista, NumeroVagones);
            val3.ImprimirTransporte();

            Console.WriteLine("Presione cualquier tecla para salir del programa");

            Console.Read();
        }
    }
}
