// P and sold on day Q, where 0 ≤ P ≤ Q < N
// profilt = A[Q] - A[P] with A[Q}>=A[P] or loss
// [0..400,000] of [0..200,000]
using System;
using static System.Math;

class Solution 
{
    public int solution(int[] A) 
    {
        int currentMin = int.MaxValue;
        int currentMax = int.MinValue;
        int profit = 0;
        
        for (int i=0; i<A.Length; i++)
        {
            if (A[i] < currentMin) 
            {
                currentMin = A[i];
                currentMax = A[i];
            }
            if (A[i] > currentMax)
            {
                currentMax = A[i];
                profit = Max(profit, currentMax - currentMin);
            }
        }
        
        return profit;
    }
}