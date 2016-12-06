// [4, 4, 2, 5, 3, 4, 4, 4] -> 3

using System;

class Solution 
{
    public int solution(int[] A) 
    {
        int elementSize = 0;
        int elementInt = 0;
        
        for (int i=0; i<A.Length; i++)
        {
            if (elementSize == 0)
            {
                elementInt = A[i]; 
                elementSize++;
            }
            else if (A[i] == elementInt)
            {
                elementSize++;
            }
            else if (A[i] != elementInt)
            {
                elementSize--;
            }
        }
        
        if (elementSize == 0) return 0;
        
        int total = 0;
        for (int i=0; i<A.Length; i++)
        {
            if (A[i] == elementInt)
            {
                total++;                    
            }
        }
        
        if (2 * total <= A.Length) return 0;
        
        int equiCount = 0;
        int count = 0;
        for (int i=0; i<A.Length; i++)
        {
            if (A[i] == elementInt)
            {
                count++;
            }
            
            //Console.WriteLine($"{i}:..{count}..{(total - count)}");
            
            if (2 * count > (i + 1) &&
                    2 * (total - count) > A.Length - (i + 1))
            {
                //Console.WriteLine($"{i}:{count}");
                equiCount++;
            }
        }
        
        return equiCount;
    }
}