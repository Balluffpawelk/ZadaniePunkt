using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadaniePunkt
{
    class Punkt3D:Punkt
    {
        public int Z { get; private set; }// właściwość 1

        public Punkt3D(int x, int y, int z):base(x,y)
        {
            Z = z;
            
        }

        public override void Wyswietl()
        {
            base.Wyswietl();
            Console.WriteLine($"Współrzędna Z: {Z}");
        }

        ////public override void Wyswietl()
        //{

        //    Console.WriteLine("Współrzędna X: {0}", X);
        //    Console.WriteLine("Współrzędna Y: {0}", Y);
        //    Console.WriteLine("Współrzędna Z: {0}", Z);

        //}



    }







}
