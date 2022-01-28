using System;

namespace teste2
{
    class Lucas
    {
        static void Main(string[] args)
        {
            double pi, raio, volume;
            pi = 3.14159;

            raio = Convert.ToDouble(Console.ReadLine());

            volume = 4.0 / 3 * pi * Math.Pow(raio, 3);

            Console.WriteLine("VOLUME = " + string.Format("{0:0.000}", volume));
        }
    }
}