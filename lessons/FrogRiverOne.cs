using System;
using System.Collections.Generic;

class Solution 
{

    public int solution(int X, int[] A)
    {
        HashSet<int> river = new HashSet<int>();
        for (int i=1; i<=X; i++) river.Add(i);
        
        for (int t=0; t<A.Length; t++)
        {
            if (river.Contains(A[t])) river.Remove(A[t]);
            if (river.Count == 0) return t;
        }

        return -1;
    }
}