﻿using System;

namespace _02.areacirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            double radio, area;

            Console.WriteLine("Program que calcula el area de un circulo");

            Console.WriteLine("Dame el radio > ");
            radio = double.Parse(Console.ReadLine());
             

            area = Math.PI * Math.Pow(radio,2);

            Console.WriteLine($"El area del ciruclo es {area}");
            Console.ReadLine();

        }
    }
}
