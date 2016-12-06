using System;
// using System.Collections.Generic;
// Console.WriteLine("this is a debug message");
// [] > 0
// [1] > 0
// [2] > 0
// [1,1] > 0
// [5,8,10] > 1
// [1,5,8,10] > 1
// [1,5,8,10,15] > 1
class Solution 
{
    public int solution(int[] A) 
    {
        if (A.Length >= 3) 
        {
            Array.Sort(A);
            
            for (int i=2; i<A.Length; i++)
            {
                long P = (long) A[i-2];
                long Q = (long) A[i-1];
                long R = (long) A[i];
                
                if (P+Q>R && Q+R>P && R+P>Q) return 1;
            }
            
        }
        
        return 0;
    }
}