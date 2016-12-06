using System;

// test (1000000000, 1)
class Solution 
{
    /// <param name="N">number of chocolates in a circle numbered from 0 to N-1</param<
    /// <param name="M">chocolate to omit M-1</param>
    /// <returns>number of chocalate you eat</returns>
    public int solution(int N, int M) 
    {
        int chocolatesEaten = 0;
        bool[] hasWrapper = new bool[N];
        
        int current = 0;
        while (!hasWrapper[current])
        {
            chocolatesEaten++;
            hasWrapper[current] = true;
            
            current = (current + M) % N;
        }
        
        return chocolatesEaten;
    }
}


using System;

// test (1000000000, 1)
class Solution 
{
    /// <param name="N">number of chocolates in a circle numbered from 0 to N-1</param<
    /// <param name="M">chocolate to omit M-1</param>
    /// <returns>number of chocalate you eat</returns>
    public int solution(int N, int M) 
    {
        return N/(GCD(M,N));
    }

    public int GCD(int a, int b)
    {
        if(a % b == 0) 
            return b;
        else 
            return GCD(b, a % b);
    }
}

