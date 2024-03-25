using System;

public class Solution {
    public int[] solution(string[] keyinput, int[] board) 
    {
        //keyinput = 입력한 키보드 값
        //board = 멥의 크기
        //x, y, -x,  -y
        int[] map = new int[4] {0, 0, 0, 0};
        for (int i = 0; i < board.Length; i++)
        {
            
            map[i] = board[i]/2;
            map[i+2] = board[i]/2 * -1;
            
        }
        int[] answer = new int[2] {0, 0};
        
        for(int i=0; i<keyinput.Length; i++)
        {
            switch(keyinput[i])
            {
                case "left":
                    if(answer[0] <= map[2])
                    {
                        break;
                    }
                    else
                    {
                        answer[0]--;
                        break;
                    }
                case "right":
                    if(answer[0] >= map[0])
                    {
                        break;
                    }
                    else
                    {
                        answer[0]++;
                        break;
                    }
                
                case "up":
                    if(answer[1] >=map[1])
                    {
                        break;
                    }
                    else
                    {
                        answer[1]++;
                        break;
                    }
                case "down":
                    if(answer[1] <= map[3])
                    {
                        break;
                    }
                    else
                    {
                        answer[1]--;
                        break;
                    }
            }
        }

        return answer;
    
    }
}