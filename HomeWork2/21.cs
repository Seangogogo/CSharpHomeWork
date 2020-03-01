using System;



namespace prime

{

    public class PFS

    {

        static void Main (string[] args)

        {
            Console.WriteLine("请输入一个正整数：");
            int data;
            data = Convert.ToInt32(Console.ReadLine());
            
            


            while (data % 2 == 0)

            {

                Console.Write(2 + " ");

                data /= 2;

            }

            for (int i = 3; i <= Math.Sqrt(data); i += 2)

            {

                while (data % i == 0)

                {

                    Console.Write(i + " ");

                    data /= i;

                }

            }

             if (data > 2)
                Console.Write(data);

        }
        

       

        
           

          

            




    }

}