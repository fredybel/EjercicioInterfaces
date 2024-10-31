
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
    case 1: //Area del circulo
        Console.WriteLine("Calcular área de un circulo");
        Console.WriteLine("Escriba el radio del circulo: ");
        calculos.Radio = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();
        calculos.Imprimir();
        break;


    case 2:  //Area del rectangulo
        Console.WriteLine("Calcular area de un rectángulo");
        Console.WriteLine("Ingrese el primer lado.");
        calculos.N1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Esciba el segundo lado.");
        calculos.N2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();
        calculos.Imprimir();
        break;

        case 3: // Longitud en KM
        Console.WriteLine("Convertir de metros a kms... ");
        Console.WriteLine("Ingrese la cantidad en metros");
        calculos.Metros = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine() ;
        calculos.Imprimir() ;
        break;

        case 4:     
        Console.WriteLine("Cconvertir de metros a millas...");
        Console.WriteLine("Ingrese la cantidad en metros");
        calculos.Metros = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();
        calculos.Imprimir();
        break;

        case 5:
        Console.WriteLine("Calcular volumen de un cubo");
        Console.WriteLine("Ingrese un solo lado del cubo");
        calculos.N1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();
        calculos.Imprimir();
        break;

}
