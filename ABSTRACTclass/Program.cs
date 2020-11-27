using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSTRACTclass
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure f = new Rectangel(5, 6);

           Console.WriteLine( "AREA OF RECTANGLE : " + f.area() );

            f = new Circle(30);

            Console.WriteLine("AREA OF CIRCLE : " +f.area());

        }
    }

    abstract class Figure
    {
     public int height;
      public   int width;

        public int radius;
      public   const double pi = 3.14;

        public abstract double area();
    }


    class Rectangel : Figure
    {
     
        public Rectangel(int h,int w)
        {
            this.height = h;
            this.width = w;
        }
        public override double area()
        {
           return height * width;

        }

    }


    class Circle : Figure
    {

        public Circle(int r)
        {
            this.radius = r;
        }
        public override double area()
        {
            return 2 * pi * radius;

        }

    }


}
