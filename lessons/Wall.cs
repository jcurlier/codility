// [2, 5, 1, 4, 6, 7, 9, 10, 1] > 8

using System;
using System.Collections.Generic;

class Solution 
{
    public int solution(int[] H) 
    {
        int count = 0;
        
        Stack<int> previousHeights = new Stack<int>();
        int i = 0;
        int height = 0;
        
        while (i < H.Length)
        {
            height = H[i];
            
            //Console.WriteLine($"i: {i}");
            //Console.WriteLine($"Height: {height}");
            
            int previousHeight = (previousHeights.Count > 0) ? previousHeights.Peek() : 0;
            //Console.WriteLine($"PreviousHeight: {previousHeight}");
            
            if (height > previousHeight)
            {
                previousHeights.Push(height);   
                i++;
            }
            else if (height == previousHeight)
            {
                i++;
            }
            else
            {
                previousHeights.Pop();
                count++;
            }

            //Console.WriteLine($"PreviousHeights count: {previousHeights.Count}");            
            //Console.WriteLine($"Count: {count}");
            //Console.WriteLine("");
        }
        
        count = count + previousHeights.Count;
        
        return count;
    }
}