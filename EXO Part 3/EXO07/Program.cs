using System;
using System.Diagnostics;

namespace EXO7
{
    
    interface IPolygon { void calculateArea(int a, int b); }
    interface IColor { void getColor(); }
    
    class Rectangle : IPolygon, IColor {
        public void calculateArea(int a, int b) {
            int area = a * b;
            Console.Write("Area of Rectangle: " + area +" => ");
        }
        public void getColor() {
            Console.Write("Red Rectangle");
            
        }
    }
    
    class Program 
    {
        static void Main(string[] args)
        {
            //Code ici   
            // init class Rectangle
            // set value a et b dans calculateArea
            // chopper la couleur dans getColor
        }
    }
}


// Dev
// Manque 
// Result Area of Rectangle: 20000 => Red Rectangle 