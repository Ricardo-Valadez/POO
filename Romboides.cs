using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perimetros
{
    //CLASE DERIVADA 
    public class Rombo
    {
        //CAMPOS DE LA CLASE DERIVADA
        float lado;
        //CONTRUCTOR CON PARAMETRO
        public Rombo(float lado)
        {
            this.lado = lado;
        }
        //METODO PARA CALCULAR EL PERIMETRO
        public double CalcularPerimetro()
        {
            return 4 * lado;
        }
        //METODO PARA DESPLEGAR LA INFORMACION DEL OBJETO
        public void DesplegarPerimetro()
        {
            Console.WriteLine("DATOS DEL ROMBO");
            Console.WriteLine("LADO DEL ROMBO: " + this.lado);
            Console.WriteLine("PERIMETRO DEL ROMBO: " + CalcularPerimetro());
        }
        //DESTRUCTOR
        ~Rombo()
        {
            Console.WriteLine("MEMORIA OBJETO CLASE DERIVADA ROMBO LIBERADA");
        }
    }
    //CLASE DERIVADA 
    public class Romboide
    {
        //CAMPOS DE LA CLASE DERIVADA
        float Base,altura;
        //CONTRUCTOR CON PARAMETRO
        public Romboide(float Base,float altura)
        {
            this.Base = Base;
            this.altura = altura;
        }
        //METODO PARA CALCULAR EL PERIMETRO
        public double CalcularPerimetro()
        {
            return (2 * Base) + (2 * altura);
        }
        //METODO PARA DESPLEGAR LA INFORMACION DEL OBJETO
        public void DesplegarPerimetro()
        {
            Console.WriteLine("DATOS DEL ROMBOIDE");
            Console.WriteLine("BASE DEL ROMBOIDE: " + this.Base);
            Console.WriteLine("ALTURA DEL ROMBOIDE: " + this.altura);
            Console.WriteLine("PERIMETRO DEL ROMBOIDE: " + CalcularPerimetro());
        }
        //DESTRUCTOR
        ~Romboide()
        {
            Console.WriteLine("MEMORIA OBJETO CLASE DERIVADA ROMBOIDE LIBERADA");
        }
    }
    //CLASE DERIVADA 
    public class PoligonoRegular
    {
        //CAMPOS DE LA CLASE DERIVADA
        float lados;
        int numlados;
        //CONTRUCTOR CON PARAMETRO
        public PoligonoRegular(float lados, int numlados)
        {
            this.lados = lados ;
            this.numlados = numlados;
        }
        //METODO PARA CALCULAR EL PERIMETRO
        public double CalcularPerimetro()
        {
            return lados*numlados;
        }
        //METODO PARA DESPLEGAR LA INFORMACION DEL OBJETO
        public void DesplegarPerimetro()
        {
            Console.WriteLine("DATOS DEL POLIGONO REGULAR");
            Console.WriteLine("LADOS DEL POLIGONO REGULAR: " + this.lados);
            Console.WriteLine("NUMERO DE LADOS DEL POLIGONO REGULAR: " + this.numlados);
            Console.WriteLine("PERIMETRO DEL POLIGONO REGULAR: " + CalcularPerimetro());
        }
        //DESTRUCTOR
        ~PoligonoRegular()
        {
            Console.WriteLine("MEMORIA OBJETO CLASE DERIVADA POLIGONO REGULAR LIBERADA");
        }
    }


}
