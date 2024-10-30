using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    public class Calculos : IOperaciones

    {
        public double N1;
        public double N2;
        public double Radio;

        //Circulo solo lleva N1
        public double Circulo()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }

        public double Rectangulo()
        {
            return N1 * N2;
        }

        public double Kilometros()
        {
            return N1 + 0.001;
        }

        public double Millas()
        {
            return N1 * 0.006;
        }
        
        //volumen de un cubo
        public double Volumen()
        {
            return Math.Pow(N1, 3);
        }

        public void Imprimir()
        {
            Console.WriteLine();
            Console.WriteLine($"Area del Circulo: {Circulo()}");
            Console.WriteLine($"Area del Rectangulo: {Rectangulo()}");
            Console.WriteLine($"Kilometros: : {Kilometros()}");
            Console.WriteLine($"Millas: {Millas()}");
            Console.WriteLine($"Volumen del cubo: {Volumen()}");
        }
    }
}
