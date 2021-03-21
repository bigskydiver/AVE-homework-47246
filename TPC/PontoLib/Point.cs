using System;

namespace PontoLib 
{
    public class Point
    {

        static double pointX;
        static double pointY;

        public Point(double x, double y){
            pointX = x;
            pointY = y;
        }

        public double getModule()
        {
            return Math.Sqrt(pointX*pointX + pointY*pointY);
        }
    }
}