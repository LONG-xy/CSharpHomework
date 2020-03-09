using System;

namespace Assignment1
{
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

    public class GenericList<T> 
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList(){
            tail=head=null;
        }

        public Node<T> Head {
            get => head;
        }

        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if(tail == null){
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
        public void ForEach(Action<T> action)
        { //定义ForEach方法
            for (Node<T> node = head; node!=null; node=node.Next)
            {
                action(node.Data);
                node = node.Next;
            }
               
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>();
            for(int i=1;i<10;i++)
            {
                list.Add(i);
            }

            list.ForEach(i => Console.WriteLine(i));

            int max = list.Head.Data;
            list.ForEach(i => max = (i > max ? i : max));//该lumbda表达式可以访问局部变量max
            Console.WriteLine("$max:{max}");

            int min=list.Head.Data;
            list.ForEach(i => min = (i < min ? i : min));
            Console.WriteLine("$min:{min}");

            int sum = 0;
            list.ForEach(i => sum += i);
            Console.WriteLine("$sum:{sum}");      
        }
    }
}
