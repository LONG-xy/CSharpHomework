using System;
using System.Collections.Generic;

namespace PrimeNumber
{

    //一个数若可以进行因数分解，那么分解时得到的两个数一定是一个小于等于sqrt(num)，一个大于等于sqrt(n)，
    //据此，遍历到sqrt(num)即可，因为若sqrt(num)左侧找不到约数，那么右侧也一定找不到约数。

    class Program
    {   static bool IsPrime(int i)//判断一个数是否为质数
        {
            bool flag = true;
            for(int n=2;n<i;n++)
            {
                if (i % n == 0)
                { flag = false; break; }
                else
                    flag = true;
            }
            return flag;

        }

        static void GetPrimeFactor(int num)//求这个数的质数因子
        {
            int j = (int)Math.Sqrt(num);
        
                for (int i = 2; i < j; i++)//求这个数的因子
                {
                   
                    if (num % i == 0)
                    {
                        if (IsPrime(i) == true)//该因子是否为质数
                            Console.Write(i + " ");
                        else
                            continue;
                    }
                   
                }
            
        }
        static void Main(string[] args)
            {
                Console.WriteLine("请输入一个数");

                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("这个数的质因数是");
                GetPrimeFactor(num);
            }
        
    }
}
