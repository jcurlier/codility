using System;
using System.Collections.Generic;

class Solution 
{
    public int solution(int[] A) 
    {
        int count = 0;
        
        HashSet<int> set = new HashSet<int>();
        
        for (int i=0; i<A.Length; i++)
        {
            if (!set.Contains(A[i]))
            {
                set.Add(A[i]);
                count++;
            }
        }
        
        return count;
    }
}