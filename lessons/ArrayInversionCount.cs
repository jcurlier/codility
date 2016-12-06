using System;

// O(N*N) solution
class Solution 
{
    public int solution(int[] A) 
    {
        int count = 0;
        
        for (int p=0; p<A.Length-1; p++)
        {
            for (int q=p+1; q<A.Length; q++)
            {
                if (A[q] < A[p])
                {
                    count++;
                    if (count > 1000000000) return 1000000000;
                }
            }
        }
        
        return count;
    }
}