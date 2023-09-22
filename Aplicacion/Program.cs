using Trabajo_numero_3.Libreria;

internal class Program
{
    private static void Main(string[] args)
    {
        Prestamo obj1 = new Prestamo();
        obj1.valorFuturo = 1564474;
        obj1.valorPresente = 1000000;
        obj1.tasaInteres = 3.8F;

        mostrarResultado(obj1);
        Pausa();
    }
    public static void mostrarResultado(Prestamo obj1)
    {
        Console.WriteLine(obj1.obtenerDatos());
    }

    public static void Pausa()
    {
        Console.WriteLine("Presione cualquier tecla para continuar ...");
        Console.ReadKey();
    }
}