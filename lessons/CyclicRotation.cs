using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");
//  ([3, 8, 9, 7, 6], 3)
//  ([3, 8, 9, 7, 6], 0)
class Solution 
{
    public int[] solution(int[] A, int K) 
    {
        int N = A.Length;
        int[] B = new int[N];
        
        for (int i=0; i<N; i++)
        {
            int index = (N + i - K%N) % N;
            B[i] = A[index];
        }
        
        return B;
    }
}