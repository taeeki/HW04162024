using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    public abstract class Figure
    {
        public abstract double Perimetr(); //периметр
        public abstract string Area();//площадь
        public abstract string NameFigure();//инфо о фигуе


    }
    public class Triangle : Figure
    {
        private int sideA, sideB, sideC;
        public Triangle(int a, int b, int c)
        {
            sideA = a;
            sideB = b;
            sideC = c;
        }
        public override double Perimetr()
        {
            return (sideA + sideB + sideC);
        }

        public override string Area() //1/2*a*h
        {
            double semPer = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(semPer * (semPer - sideA) * (semPer - sideB) * (semPer - sideC)).ToString();
        }
        public override string NameFigure()
        {
            return "Треугольник";
        }
    }


    public class Recbangle : Figure
    {
        private double width, height;
        public Recbangle(double ReWidth, double ReHeight)
        {
            width = ReWidth;
            height = ReHeight;
        }

        public override double Perimetr()
        {
            return ((width + height) * 2); //(a+b)*2
        }

        public override string Area()
        {
            return (width * height).ToString();//a*b
        }

        public override string NameFigure()
        {
            return "Прямоугольник";
        }
    }

    public class Circle : Figure
    {
        private double rad;
        public Circle(double Rad)
        {
            rad = Rad;
        }
        public override double Perimetr()
        {
            return ((Math.PI * rad) * 2);//2Pi*R
        }

        public override string Area()
        {
            return (Math.PI * rad * rad).ToString();
        }
        public override string NameFigure()
        {
            return "Круг";
        }
    }
}