using System;

namespace Exo_Slide_07_CelsiusFar
{
    class Program
    {
        static void Main(string[] args)
        {
            Celsius c = new Celsius();
            c.Temperature = 18;
            Fahrenheit cTransforme = c.ToFahrenheit();
            Console.WriteLine(cTransforme.Temperature);

            Fahrenheit f = new Fahrenheit();
            f.Temperature = 64.4;
            Celsius c2 = cTransforme.ToCelsius();
            Console.WriteLine(c2.Temperature);
        }
    }

    public struct Celsius
    {
        public double Temperature;

        public Fahrenheit ToFahrenheit()
        {
            Fahrenheit f = new Fahrenheit();
            f.Temperature = ((Temperature * 9) / 5) + 32;
            return f;
        }
    }

    public struct Fahrenheit
    {
        public double Temperature;

        public Celsius ToCelsius()
        {
            Celsius c = new Celsius();
            c.Temperature = ((Temperature - 32) * 5) / 9;
            return c;
        }
    }
}
