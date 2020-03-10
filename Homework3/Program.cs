//1. 编写面向对象程序实现长方形、正方形、三角形等形状的类。
//每个形状类都能计算面积、判断形状是否合法。 
    //请尝试合理使用接口/抽象类、属性来实现。
//2. 随机创建10个形状对象，计算这些对象的面积之和。 
//尝试使用简单工厂设计模式来创建对象。

    
using System;
using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace CSharpHomework3
{
    public interface Shape
    {
        double GetArea();

        bool Legal();
    }
    class IllegalParameter : Exception

    {

        public IllegalParameter(string message) : base(message)

        {



        }

    }
    class Triangle : Shape
    {
        public double a1 { get; set; }
        public double a2 { get; set; }
        public double a3 { get; set; }
        public Triangle(double a, double b, double c)

        {

            this.a1 = a;

            this.a2 = b;

            this.a3 = c;
            if (!Legal())

                throw new IllegalParameter("非法");
        }
        public Triangle() { }

        public bool Legal()
        {

            if (this.a1 > 0 && this.a2 > 0 && this.a3 > 0)

                return (this.a1 + this.a2 > this.a3 && this.a1 + this.a3 > this.a2 && this.a2 + this.a3 > this.a1) ? true : false;

            return false;
        }
        public double GetArea()
        { if (Legal())


            {
                return Math.Sqrt(((this.a1 + this.a2 + this.a3) / 2) * ((this.a1 + this.a2 + this.a3) / 2 - this.a1) * ((this.a1 + this.a2 + this.a3) / 2 - this.a2) * ((this.a1 + this.a2 + this.a3) / 2 - this.a3));
            }
            return -1;
        }


    }

    class Square : Shape
    {
        public double l { get; set; }
        public Square(double side)

        {

            this.l = l;

            if (!Legal())

                throw new IllegalParameter("非法");
        }

        public bool Legal()
        {



            return (this.l > 0) ? true : false;
        }
        public double GetArea()
        {
            return Legal() ? (l * l) : -1;
        }
    }

    class Rectangle : Shape
    {
        public double b1 { get; set; }
        public double b2 { get; set; }
        public Rectangle(double b1, double b2)

        {

            this.b1 = b1;

            this.b2 = b2;

            if (!Legal())

                throw new IllegalParameter("非法");

        }
        public bool Legal()
        {
            return (this.b1 > 0 && this.b2 > 0) ? true : false;



        }
        public double GetArea()
        {
            return Legal() ? (this.b1 * this.b2) : -1;
        }
    }

    class ShapeFactory
    {


        public Shape CreateShape(double type, double[] value)
        {
            Shape newShape = new Triangle();
            switch (type)
            {
                case 1:
                    newShape = new Triangle(value[0], value[1], value[2]);
                    break;



                case 2:
                    newShape = new Square(value[0]);

                    break;
                case 3:
                    newShape = new Rectangle(value[0], value[1]);

                    break;
                default:

                    break;
            }
            return newShape;
        }





    }


    class Program
    {
        public static void GenerateRandomParameters(int i, out double[] Para, Random rnd)

        {
            Triangle triangle = new Triangle();

            int j;

            switch (i)

            {

                case 3:

                    Para = new double[2];

                    for (j = 0; j <= 1; j++)

                    {

                        Para[j] = rnd.NextDouble() * rnd.Next(1, 1000);

                    }

                    break;

                case 2:

                    Para = new double[2];

                    Para[0] = rnd.NextDouble() * rnd.Next(1, 1000);

                    break;

                case 1:

                    Para = new double[3];

                    while (!triangle.Legal())

                    {

                        for (j = 0; j <= 2; j++)

                            Para[j] = rnd.NextDouble() * rnd.Next(1, 1000);

                        triangle.a1 = Para[0];

                        triangle.a2 = Para[1];

                        triangle.a3 = Para[2];

                    }

                    break;



                default:

                    Para = null;

                    break;

            }

        }
    
    public static void Input(string s, ShapeFactory MyFactory, Random rnd)

    {

        double[] Para = null;

        int r = rnd.Next(1, 5);

        GenerateRandomParameters(r, out Para, rnd);

        Shape Myshape = MyFactory.CreateShape(r, Para);

        Console.WriteLine($"随机生成了{Myshape.GetType()},其面积为{Myshape.GetArea()}");

    }

    static void Main(string[] args)

    {

        Random rnd = new Random();

        while (true)

        {

            ShapeFactory MyFactory = new ShapeFactory();

            Console.WriteLine("----------随机生成常见几何图形并求面积----------");

            Console.WriteLine("-------------请输入随机图形生成数量-------------");

            string s = Console.ReadLine();

            int Num = 0;

            if (int.TryParse(s, out Num))

                Num = int.Parse(s);

            else

            {

                Console.WriteLine("输入有误，按任意键重新输入");

                Console.ReadKey();

                Console.Clear();

                continue;

            }

            for (int i = 0; i <= Num; i++)

            { Input(s, MyFactory, rnd); }

            Console.WriteLine("-----------------按任意键继续------------------");

            Console.ReadKey();

            Console.Clear();

            }

        }
    }
}
    