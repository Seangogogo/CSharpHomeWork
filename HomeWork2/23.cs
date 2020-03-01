using System;

namespace CSharpHomework2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int []a = new int[101];

            a[0] = a[1] = 1;

            a[2] = 0;

            int k = 2, tt = 0;

            while (tt < 101)

            {

                for (int i = 1; i < a.Length; i++) //将不是素数的数筛出

                {

                    if (i % k == 0 && i != k)

                        a[i] = 1;//不符合要求的全部置为1

                }



                for (int i = 1; i < a.Length; i++) //将筛选后的第一个数当做新的筛子

                {

                    if (i > k && a[i] == 0)

                    {

                        k = i;

                        break;

                    }

                }

                tt++;

            }



            for (int i = 1; i < a.Length; i++)

                if (a[i] == 0) Console.WriteLine( i);

        }





    }
}

   



   