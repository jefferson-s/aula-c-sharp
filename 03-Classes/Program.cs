﻿using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Ponto p1 = new Ponto (10, 20);
            Ponto p2 = new Ponto3D (10, 20,30);
            Ponto3D.calcular();

        }
    }
}
