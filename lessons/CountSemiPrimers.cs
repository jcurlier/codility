using System;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

// Test
class Solution 
{
    /// <summary>
    /// A semiprime is a natural number that is the product of two 
    /// (not necessarily distinct) prime numbers.
    /// </summary
    /// <param name="N">integer range 1..50,000</param>
    /// <param name="P">array of lower end of the query (inclusve)</param>
    /// <param name="Q">array of higher end of the query (inclusve)</param>
    /// <returns></returns>
    public int[] solution(int N, int[] P, int[] Q) 
    {
        int[] result = new int[P.Length];
        
        bool[] semiprimes = calculateSemiprimes(N);     
        int[] countSemiprimes = new int[N+1];
        int count = 0;
        for (int i=4; i<=N; i++)
        {
            if (semiprimes[i]) count++; 
            countSemiprimes[i] = count;
        }
        
        // execute the queries
        for (int i=0; i<P.Length; i++)
        {
            result[i] = countSemiprimes[Q[i]] - countSemiprimes[P[i] - 1];
        }
        
        return result;
    }
    
    public bool[] calculatePrimes(int N) 
    {
        bool[] primes = new bool[N+1];
        for (int i=2; i<=N; i++) primes[i] = true;
        
        double s = Sqrt(N);
        
        int l = 2;
        while (l <= s)
        {
            if (primes[l])
            {
                int k = l * l;
                while (k <= N)
                {
                    primes[k] = false;
                    k = k + l;
                }
            }
            l++;
        }               
        
        return primes;
    }
    
    public bool[] calculateSemiprimes(int N) 
    {
        bool[] primes = calculatePrimes(N);
        //for (int i=2; i<=N; i++) if (primes[i]) WriteLine(i);
        
        bool[] semiprimes = new bool[N+1];
        for (int i=2; i<=N; i++)
        {
           if (primes[i])
           {
                for (int j=i; j<=N/i; j++)
                {
                    if (primes[j]) 
                    {
                        semiprimes[i*j]=true; 
                    }
                }
           }
        }
        
        //for (int i=4; i<=N; i++) if (semiprimes[i]) WriteLine(i);   
                
        return semiprimes;
    }
}