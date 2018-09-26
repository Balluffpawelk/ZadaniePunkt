using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadaniePunkt
{
    class Punkt
    {
        public static int Licznik { get; private set; }

        public int X { get; private set; }// właściwość 1
        

        public int Y { get; private set; }// właściwość 2
       
        public static Punkt operator +(Punkt p1, Punkt p2)
        {
            int x = p1.X + p2.X;
            int y = p1.Y + p2.Y;
            Punkt result = new Punkt(x, y);
            //Punkt result = new Punkt(p1.X + p2.X, p1.Y + p2.Y);
            return result;

        }

        public static Punkt operator -(Punkt p1, Punkt p2)
        {
            int x = p1.X - p2.X;
            int y = p1.Y - p2.Y;
            Punkt result = new Punkt(x, y);
            //Punkt result = new Punkt(p1.X + p2.X, p1.Y + p2.Y);
            return result;

        }

        public static Punkt operator *(Punkt p1, int a)
        {
            int x = p1.X* a;
            int y = p1.Y *a;
            Punkt result = new Punkt(x, y);
            //Punkt result = new Punkt(p1.X + p2.X, p1.Y + p2.Y);
            return result;

        }

        public static Punkt operator *(int a, Punkt p1)
        {
            return p1*a;

        }

        public Punkt(int wspx, int wspy) //konstruktor
        {
            X = wspx;
            Y = wspy;
            Licznik++;
            //Console.WriteLine("Licznik: {0}", Licznik);
        }

        public void Prawo(int ileP) //metoda 1
        {
            X += ileP;

        }

        public void Lewo(int ileL) //metoda 2
        {
            X -= ileL;

        }

        public void Gora(int ileG) //metoda 3
        {
            Y += ileG;

        }

        public void Dol(int ileD) //metoda 4
        {
            Y -= ileD;

        }

        public override string ToString()
        {
            return $"X:{X};Y:{Y}";
        }

        public virtual void Wyswietl()
        {
            //Console.WriteLine( $"X:{X};Y:{Y}");
            Console.WriteLine("Współrzędna X: {0}",X);
            Console.WriteLine("Współrzędna Y: {0}",Y);


        }

    }
}
