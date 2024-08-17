//Ejercicio de violación del LSP.

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            FiguraGeometrica figura1 = new Rectangulo() { Base = 5, Altura = 10 };
//            Console.WriteLine($"Área del rectángulo: {figura1.CalcularArea()}"); // Correcto

//            FiguraGeometrica figura2 = new Cuadrado() { Base = 5, Altura = 10 };
//            Console.WriteLine($"Área del cuadrado (con violación LSP): {figura2.CalcularArea()}"); // Incorrecto
//        }
//    }

//}






//Ejercicio de refactorización para cumplir con LSP.
class Program
{
    static void Main(string[] args)
    {
        FiguraGeometrica figura1 = new Rectangulo() { Base = 5, Altura = 10 };
        Console.WriteLine($"Área del rectángulo: {figura1.CalcularArea()}"); // Correcto

        FiguraGeometrica figura2 = new Cuadrado() { Lado = 5 };
        Console.WriteLine($"Área del cuadrado (con LSP): {figura2.CalcularArea()}"); // Correcto
    }
}
