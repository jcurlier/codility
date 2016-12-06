using System;

class Solution 
{
    public int solution(int[] A) 
    {
        int numberOfPairs = 0;
        int numberOfZeros = 0;
        
        for (int i=0; i<A.Length; i++)
        {
            if (A[i] == 0)
            {
                numberOfZeros++;
            }
            if (A[i] == 1)
            {
                numberOfPairs = numberOfPairs + numberOfZeros;
                if (numberOfPairs > 1000000000) return -1;
            }
        }
        
        return numberOfPairs;
    }
}