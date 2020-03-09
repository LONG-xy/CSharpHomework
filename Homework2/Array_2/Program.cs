using System;

namespace Array_2
{
    class Program
    {
        static int Max(int[] array )
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
                else
                    continue;
            }
            return max;
        }
        static int Min(int[] array)
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
                else
                    continue;
            }
            return min;
        }
        static int Sum(int[] array)
        {
            int sum = 0;
            foreach (int element in array)
                sum += element;
            return sum;
        }
        
        
        static void Main( )
        {
            int[] array = {1,92,123,2,234,89,3,345,567 };
            Console.WriteLine("数组："+string.Join("  ", array));
            int a = Max(array);
            Console.WriteLine("该数组的最大值为{0}", a);
            int b = Min(array);
            Console.WriteLine("该数组的最小值为{0}", b);
            int c = Sum(array);
            Console.WriteLine("该数组的数值和为{0}", c);
            Console.WriteLine($"该数组的平均值为{c/(array.Length)}" );


        }
    }
}
