using System;
using ShapeWorld.Domain.Models;

namespace ShapeWorld.Client
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            PlayWithShape();
        }

        private static void PlayWithShape(){
           //someShape.NumberOfEdges = 10;
           //someShape.SetEdges(23);
           Square someSquare = new Square();
           //Rectangle someRectangle = new Rectangle();
           Shape someShape = new Rectangle();
           someSquare.Length = 5;

           Console.WriteLine(someShape.NumberOfEdges);
           Console.WriteLine(someSquare.NumberOfEdges);
           //System.Console.WriteLine(someRectangle.NumberOfEdges);
           System.Console.WriteLine(someSquare.Area());
           System.Console.WriteLine(someShape.Volume());
        }
    }
}
