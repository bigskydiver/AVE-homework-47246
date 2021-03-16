using System;

namespace PontoLib{
    public class Point {
        static double x;
        static double y;
        public Point(double X ,double Y){
            x = X;
            y = Y;
        }
        double getModule(){
            return Math.Sqrt(x*x + y*y);
        }
    }
}