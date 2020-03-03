using System;

namespace project1
{
  class Project
    { 
   
    public static void Main()
    {
            double radius = 2.5;
            double weight = 3;
            double height = 4.8;
            double length = 5.6;
            Circle circle = new Circle(radius);
            double answer = circle.Area(radius);
            Console.WriteLine(answer);
            Rectangle rectangle = new Rectangle(weight,height);
             double b=rectangle.area(weight,height);
            Console.WriteLine(b);
            Square square = new Square(length);
            double c= square.Area(length);
            Console.WriteLine(c);

        }
    interface Calculate
    {
        double Area();
        bool IsIeagle();
    }
    public class Circle : Calculate
    {
        protected double radius;
        public bool IsIeagle(double radius)
            {
                return (radius <= 0) ? true:false ;
               
            }

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double Area(double radius)
        {
                if (!IsIeagle(radius))
                    return -1;
                else
                {
                    Console.WriteLine("圆的面积是：");
                    return Math.Pow(radius, Math.PI);
                }
        }

        public double Area()
        {
            throw new NotImplementedException();
        }

            double Calculate.Area()
            {
                throw new NotImplementedException();
            }

            bool Calculate.IsIeagle()
            {
                throw new NotImplementedException();
            }
        }

    public class Rectangle : Calculate
    {
        protected double width;
        protected double height;
            public bool IsIeagle(double width,double height)
            {
                return (width <= 0 &&height <=0) ? true : false;

            }
            public Rectangle(double width, double height)
            {
                this.width = width;
                this.height = height;
            }
        public double area(double width, double height)
        {
                if (!IsIeagle(width,height))
                    return -1;
                else
                {
                    Console.WriteLine("长方形的面积是：");
                    return width * height;
                }
        }

        public double Area()
        {
            throw new NotImplementedException();
        }

            double Calculate.Area()
            {
                throw new NotImplementedException();
            }

            bool Calculate.IsIeagle()
            {
                throw new NotImplementedException();
            }
        }
    public class Square : Calculate
    {
        private double length;

        public Square(double length)
        {
            this.length = length;
        }
            public bool IsIeagle(double length)
            {
                return (length <=0) ? true : false;

            }
            public  double Area(double length)
            {
                if (!IsIeagle(length))
                    return -1;
                else
                {
                    Console.WriteLine("正方形的面积是：");
                    return Math.Pow(length, 2);
                }
        }

            public double Area()
            {
                throw new NotImplementedException();
            }

            public bool IsIeagle()
            {
                throw new NotImplementedException();
            }
        }
    }

}

