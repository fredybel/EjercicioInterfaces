
using EjercicioInterfaces;

Calculos calculos = new Calculos();
int opcion;

Console.WriteLine("****************************************");
Console.WriteLine("*                  MENU                  *");
Console.WriteLine("* 1.      Area de un circulo             *");
Console.WriteLine("* 2.      Area de un rectangulo          *");
Console.WriteLine("* 3.      Metros a Kilometros            *");
Console.WriteLine("* 4.      Metros a Millas                *");
Console.WriteLine("* 5.      Volumen de un cubo             *");
Console.WriteLine("****************************************");
Console.WriteLine("Escoja la opción:");
opcion = Convert.ToInt32(Console.ReadLine());


Console.WriteLine();
switch (opcion)
{
    case 1:
        Console.WriteLine("Escriba el radio del circulo: ");
        calculos.Radio = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();
        calculos.Imprimir();
        break;
}
