// http://www.catonmat.net/blog/low-level-bit-hacks-you-absolutely-must-know/


using System;
using System.Collections;

class Solution 
{
    public int solution(int[] A) 
    {
        int n = A.Length;
        BitArray bits = new BitArray(n+1); // create an array from index from 0..n but don't use 0
        
        for (int i=0; i<n; i++)
        {
            if (A[i] > n) return 0;
            if (bits[A[i]]) return 0;
            bits[A[i]] = true;
        }

        for (int i=1; i<=n; i++)
        {
            if (!bits[i]) return 0;
        }
        
        return 1;
        
    }
}