﻿//1、为示例中的泛型链表类添加类似于List<T> 类的ForEach(Action<T> action)方法。
//通过调用这个方法打印链表元素，求最大值、最小值和求和（使用lambda表达式实现）。


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApplication
{
    
    // 链表节点
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
       
       
    }
 

    //泛型链表类
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head
        {
            get => head;
        }

        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
        public void ForEach(Action<T> action)
       {
                Node<T> t = this.head;
                while (t != null)
                {
                    action(t.Data);
                    t = t.Next;
                }
         }
    
       

    }
 
    class Program
    {
        
        static void Main(string[] args)
        {
           
            // 整型List
            GenericList<int> intlist = new GenericList<int>();
            for (int x = 0; x < 10; x++)
            {
                intlist.Add(x);
            }

            //逐个打印
            intlist.ForEach(m => Console.WriteLine(m));
             //最大
            int max = int.MinValue;
            intlist.ForEach(m => { if (max < m) max = m; });
            Console.WriteLine($"最大值: {max}");
            //最小
            int min = int.MaxValue;
            intlist.ForEach(m => { if (min > m) min = m; });
            Console.WriteLine($"最小值: {min}");
            //总和
            int sum = 0;
            intlist.ForEach(m => {  sum += m; });
            Console.WriteLine($"总和: {sum}");
      
            for (Node<int> node = intlist.Head;
                  node != null; node = node.Next)
            {
                Console.WriteLine(node.Data);
            }

            // 字符串型List
            GenericList<string> strList = new GenericList<string>();
            for (int x = 0; x < 10; x++)
            {
                strList.Add("str" + x);
            }
            for (Node<string> node = strList.Head;
                    node != null; node = node.Next)
            {
                Console.WriteLine(node.Data);
            }

         


        }

    }
}