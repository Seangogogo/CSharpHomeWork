using System;

namespace Calculator
{
    class Calculator
    {
        static void Main (string[] args)

        {
            bool endApp = false;
            // Display title as the C# console calculator app.
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            double result = double.NaN; // Default value is "not-a-number" which we use if an operation, such as division, could result in an error.

            //获得运算的数字及运算符
            Console.WriteLine("请输入数字A");
            double A = Convert.ToDouble(Console.ReadLine());
           
            Console.WriteLine("请输入运算符");
            string operate = Console.ReadLine();
            Console.WriteLine("请输入数字B");
            double B = Convert.ToDouble(Console.ReadLine());
            //将结果存储到变量D
            double D = 0;
            // Use a if statement to do the math.
            if (operate == "+")
            {
                D = A + B;
                Console.WriteLine("A+B=" + D);

            }
            else if (operate == "-")
            {
                D = A - B;
                Console.WriteLine("A-B=" + D);

            }
            else if (operate == "*")
            {
                D = A * B;
                Console.WriteLine("A*B=" + D);
            }
            else if (operate == "/")
            {
                D = A / B;
                // when it is a non-zero divisor.
                if (B == 0)
                    Console.WriteLine("不能除零操作！");
                else
                    Console.WriteLine("A/B=" + D);
            }
            else if (operate == "")
            {
                Console.WriteLine("The operator is null");
            }
            else
            {
                Console.WriteLine("The operator is illegal");
            }

                   
         }
            
     }
 }

  