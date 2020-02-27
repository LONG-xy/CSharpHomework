using System;

namespace assignment_3
{




public class Prime
{
    public static void Main()
    {
        int n = 100;
        bool[] b = new bool[n + 1];
        //初始化数组
        for (int i = 2; i <= n; i++)
            b[i] = true;

        for (int i = 2; i < n; i++)
        //把i的倍数划掉  
        {
            if (b[i])
                for (int j = i * 2; j <= n; j += i)
                    b[j] = false;

        }


        for (int i = 2; i <= n; i++)
        {//把还存在的数输出
            if (b[i])
                Console.Write(i + " ");
        }

    }
}
}
