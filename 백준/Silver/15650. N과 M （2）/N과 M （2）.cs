using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static int n, m;
    static string s;
    static int[] arr = new int[10];
    static bool[] vis = new bool[10];

    public static void Main()
    {
        string[] str = Console.ReadLine().Split(' ');
        n = int.Parse(str[0]);
        m = int.Parse(str[1]);

        Func(0);
    }

    static void Func(int k)
    {
        for (int i = 1; i <= n; i++)
        {
            // 뽑은 숫자의 방문 유무를 저장
            if (!vis[i])
            {
                vis[i] = true;
                arr[k] = i;
                Func(k + 1);
                vis[i] = false;
            }
        }

        if (k == m)
        {
            // 카운트가 M만큼 된다면 출력 
            for (int i = 0; i < m; i++)
            {
                if(i ==0)
                    s += arr[i] + " ";
                if (i > 0 && arr[i] > arr[i-1])
                {
                    s += arr[i] + " ";
                }
                else
                {
                    continue;
                }
            }
            if(s.Length >= m*2 -1)
            {
                Console.WriteLine(s);
                
            }
            s = "";
            return;
        }
    }
}