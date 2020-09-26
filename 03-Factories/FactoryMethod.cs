using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _03_Factories
{
    public enum CoordinateSystem
    {
        Cartesien,
        Polar
    }

    

    public class Point
    {
        //Facotry Method

        private double x, y;

        private Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        


        public static class Factory
        {
            public static Point NewCartesianPoint(double x, double y)
            {
                return new Point(x, y);
            }

            public static Point NewPolarPoint(double rho, double theta)
            {
                return new Point(rho * Math.Cos(theta), rho * Math.Sin(theta));
            }
        }

    }

    public class Demo3
    {
        public static void Main2(string[] args)
        {
            var point = Point.Factory.NewPolarPoint(1.0, Math.PI / 2);

            

        }
    }
}
