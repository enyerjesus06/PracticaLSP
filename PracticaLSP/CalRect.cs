using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ejercicio de violación del LSP.
//namespace PracticaLSP
//{
//    class FiguraGeometrica
//    {
//        public double Base { get; set; }
//        public double Altura { get; set; }

//        public virtual double CalcularArea()
//        {
//            return Base * Altura;
//        }
//    }

//    class Rectangulo : FiguraGeometrica
//    {
//        public override double CalcularArea()
//        {
//            return Base * Altura;
//        }
//    }

//    class Cuadrado : FiguraGeometrica
//    {
//        public override double CalcularArea()
//        {
//            // Aquí se viola el principio LSP, ya que se fuerza a usar la lógica de rectángulo
//            return Base * Altura; // Esto está incorrecto para un cuadrado, debería ser Base * Base o Altura * Altura
//        }
//    }




//Ejercicio de refactorización para cumplir con LSP.

abstract class FiguraGeometrica
{
    public abstract double CalcularArea();
}

class Rectangulo : FiguraGeometrica
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public override double CalcularArea()
    {
        return Base * Altura;
    }
}

class Cuadrado : FiguraGeometrica
{
    public double Lado { get; set; }

    public override double CalcularArea()
    {
        return Lado * Lado;
    }
}



