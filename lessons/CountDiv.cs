using System;

class Solution 
{
    public int solution(int A, int B, int K) 
    {
        int lower = (A % K == 0) ? A : A + K - (A % K);
        int upper = (B % K == 0) ? B : B - (B % K);
        
        if (lower > B && upper < A) return 0;
        if (upper < A) return 1;
        if (lower > B) return 1;
        
        return (upper - lower) / K + 1; 
    }
}