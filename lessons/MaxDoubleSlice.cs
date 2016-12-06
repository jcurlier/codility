

using System;
using static System.Math;

class Solution 
{
    public int solution(int[] A) 
    {
        int N = A.Length;
        int[] K1 = new int[N]; // maximum sum contiguous subsequence ending at index i
        int[] K2 = new int[N]; // maximum sum contiguous subsequence starting with index i
        
        for(int i = 1; i < N-1; i++)
        {
            K1[i] = Max(K1[i-1] + A[i], 0);
        }
        
        for(int i = N-2; i > 0; i--)
        {
            K2[i] = Max(K2[i+1]+A[i], 0);
        }

        int max = 0;

        for(int i = 1; i < N-1; i++)
        {
            max = Max(max, K1[i-1]+K2[i+1]);
        }
        
        return max;
    }
}
