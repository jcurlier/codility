using System;
using static System.Console;
using static System.Math;

// 0 ≤ P ≤ Q < N,
// [-10] -10
//  [-2, 1]  -1
class Solution 
{
    /// <param name="A">Size 1..1,000,000 of integers in the range -1,000,000 to +1,000,000</param>
    /// <return>Maximum sum of any slice of A</return>
    public int solution(int[] A) 
    {
        int max = int.MinValue;
        int localMax = 0;
        
        for (int i=0; i<A.Length; i++)
        {
            localMax = Max(A[i], localMax + A[i]);
            max = Max(max, localMax);
        }
        
        return max;
    }
}

// slice can be empty and its sum equals 0
class Solution 
{
    public int solution(int[] A) 
    {
        int max = o;
        int localMax = 0;
        
        for (int i=0; i<A.Length; i++)
        {
            localMax = Max(0, localMax + A[i]);
            max = Max(max, localMax);
        }
        
        return max;
    }
}