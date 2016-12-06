using System;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

/// Test cases: 
class Solution 
{
    /// <summary></summary
    /// <param name="A">array of N numbers, sorted in non-decreasing order</param>
    /// <returns>absolute distinct count, the number of distinct absolute values among the elements.</return>
    public int solution(int[] A)
    {
        int count = 0;
        int indexFirstPositive = A.Length;
        
        for (int i=0; i<A.Length; i++)
        {
            if (A[i]>=0) 
            {
                indexFirstPositive = i; 
                break;
            }
        }
            
        int currentNegativeIndex = indexFirstPositive - 1;
        int currentPositiveIndex = indexFirstPositive;
        int previousNegativeValue = 0;
        int previousPositiveValue = -1;
        
        while (currentNegativeIndex >= 0 || currentPositiveIndex < A.Length)
        {
            if (currentNegativeIndex < 0)
            {
                if (previousPositiveValue != A[currentPositiveIndex]) count++;
                previousPositiveValue = A[currentPositiveIndex];
                currentPositiveIndex++;
            }
            else if (currentPositiveIndex == A.Length)
            {
                if (previousNegativeValue != A[currentNegativeIndex]) count++;
                previousNegativeValue = A[currentNegativeIndex];
                currentNegativeIndex--;
            }
            else if (-A[currentNegativeIndex] > A[currentPositiveIndex]) 
            {
                if (previousPositiveValue != A[currentPositiveIndex]) count++;
                previousPositiveValue = A[currentPositiveIndex];
                currentPositiveIndex++;
            } 
            else if (-A[currentNegativeIndex] == A[currentPositiveIndex]) 
            {
                currentNegativeIndex--;
            }
            else if (-A[currentNegativeIndex] < A[currentPositiveIndex]) 
            {
                if (previousNegativeValue != A[currentNegativeIndex]) count++;
                previousNegativeValue = A[currentNegativeIndex];
                currentNegativeIndex--;
            }
        }
        
        return count;
    }
}