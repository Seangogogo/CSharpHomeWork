using System;

namespace CSharpHomeWork2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = {33,91,82,45,12,46,86};


            

            int max = num[0];
            int min = num[0];
            int sum = 0;
            float average = 0;

            for (int i = 0; i < num.Length; i++)

            {
                

                if (max < num[i])

                    max = num[i];

                if (min > num[i])

                    min = num[i];

                sum += num[i];

            }

            average = (float)sum / num.Length;

            Console.WriteLine("最大值：" + max + "\n最小值：" + min + "\n所有数组元素的和：" + sum + "\n平均值：" + average);
        }
    }
}
