using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution 
{
    public int solution(int[] A) 
    {
        int n = A.Length;
        int result = 0;
        
        Array.Sort(A);
 
        for (int p=0; p<n-2; p++)
        {
            int r=p+2;
            
            for (int q=p+1; q<n-1; q++) // no need to reset r when incrementing q as we know it is going to be true for first one
            {
                while (r<n && A[p]+A[q]>A[r]) // other are valid as this ordered
                {
                    r++;
                }
                result += r-q-1;
            }
        }
        
        return result;
    }
}

//// TOO SLOW

using System;

class Solution 
{
    public int solution(int[] A) 
    {
        int count = 0;
        
        if (A.Length >= 3) 
        {
            Array.Sort(A);

            int p = 0;
            int q = p + 1;
            int r = p + 2;
                
            while (p < A.Length - 2)
            {
                if (A[p] + A[q] > A[r]) 
                {
                    //Console.WriteLine($"{p} {q} {r}");
                    count++;
                    r++;
                }
                else if (q < A.Length - 2)
                {
                    q++;
                    r = q + 1;
                }
                else
                {
                    p++;
                    q = p + 1;
                    r = p + 2;
                }
                
                if (r == A.Length)
                {
                    q++;
                    r = q + 1;
                }
                if (q == A.Length-1)
                {
                    p++;    
                    q = p + 1;      
                    r = p + 2;
                }
            }
            
        }
        
        return count;
    }
}