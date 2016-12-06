using System;

class Solution 
{
    /// <summary></summary
    /// <param name="M">All integers in array A are less than or equal to M, 0..100,000.</param>
    /// <param name="A">array of N non negative integers less than or equal to M of size 1..100,000.</param>
    /// <returns>number disctinct slices, greater than 1,000,000,000 returns 1,000,000,000</returns>
    public int solution(int M, int[] A) 
    {
        int result = 0;

        int N = A.Length;
        int[] counters = new int[M+1];

        int head = 0;
        int tail = 0;

        while (tail < N) 
        {
            // find the most right end of the array for each tail
            while (head < N && counters[A[head]] != 2) 
            {
                counters[A[head]]++;
                if (counters[A[head]] == 2)
                    break;
                head++;
            }
            result += head - tail;

            if (result > 1000000000) return 1000000000;

            // set the counter of the element before tail to be 0
            counters[A[tail]] = 0;
            tail++;
        }
        
        return result;
    }
}





(100000, [1, 1])

// SLOW

using System;
using System.Collections.Generic;

class Solution 
{
    /// <summary></summary
    /// <param name="M">All integers in array A are less than or equal to M, 0..100,000.</param>
    /// <param name="A">array of N non negative integers less than or equal to M of size 1..100,000.</param>
    /// <returns>number disctinct slices, greater than 1,000,000,000 returns 1,000,000,000</returns>
    public int solution(int M, int[] A) 
    {
        int N = A.Length;
        int count = 0;
        HashSet<int> set = new HashSet<int>();
        
        for (int i=0; i<N; i++)
        {
            int j=i;
            while (j<N && !set.Contains(A[j]))
            {
                count++;
                set.Add(A[j]);
                j++;    
            }
            if (count > 1000000000) return 1000000000;
            set.Clear();    
        }
        
        return count;
    }
}