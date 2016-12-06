//http://www.geeksforgeeks.org/find-the-two-numbers-with-odd-occurences-in-an-unsorted-array/
//http://www.geeksforgeeks.org/find-the-number-occurring-odd-number-of-times/

using System;

class Solution 
{
    public int solution(int[] A) 
    {
        int result = 0; 
        for (int i=0; i < A.Length; i++)
            result = result ^ A[i];
            
        return result;
    }
}