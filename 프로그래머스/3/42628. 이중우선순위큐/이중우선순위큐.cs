using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Linq;


public class Solution {
    public int[] solution(string[] operations) {
        int[] answer = new int[2] {0, 0};
        List<int> qp = new List<int>();
        
        foreach(var item in operations)
        {
            string[] edge = item.Split();
            int v = int.Parse(edge[1]);
            switch(edge[0])
            {
                case "I":
                    qp.Add(v);
                    break;

                case "D":
                    if(qp.Count == 0)
                    {
                        continue;
                    }
                    switch(v)
                    {
                        case 1:
                            qp.Remove(qp.Max());
                            break;

                        case -1:
                            qp.Remove(qp.Min());
                            break;
                    }
                    break;
            }
        }

        if(qp.Count != 0)
        {
            answer[0] = qp.Max();
            answer[1] = qp.Min();
        }

        return answer;
    }
}