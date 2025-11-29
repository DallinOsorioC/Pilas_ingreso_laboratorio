using Pilas_colas_y_colas_dobles.Stack;
using Pilas_ingreso_laboratorio;

internal class Program
{
    private static void Main(string[] args)
    {
        LinkedStack<Ingreso> ingreso = new LinkedStack<Ingreso>();

        ingreso.Push(new Ingreso() { Idtrabajador = 101, ZonaIngresada = "Zona Química", HoraIngreso = "08:10" });
        ingreso.Push(new Ingreso() { Idtrabajador = 204, ZonaIngresada = "Zona Biológica", HoraIngreso = "08:15" });
        ingreso.Push(new Ingreso() { Idtrabajador = 101, ZonaIngresada = "Zona Esterilización", HoraIngreso = "08:20" });
        ingreso.Push(new Ingreso() { Idtrabajador = 309, ZonaIngresada = "Zona Química", HoraIngreso = "08:25" });

        ingreso.Pop();
       Console.WriteLine("Elementos de la pila:\n");
        //mostrar elementos de la pila
        while (!ingreso.IsEmpty())
        {
            Console.WriteLine(ingreso.Pop());
        }

        ingreso.Push(new Ingreso() { Idtrabajador = 150, ZonaIngresada = "Zona Laser", HoraIngreso = "08:30" });

        Console.WriteLine($"\nElemento en el tope:\n{ingreso.Peek()}");



    }
}