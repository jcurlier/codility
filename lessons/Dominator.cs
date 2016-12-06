using System;
using System.Collections.Generic;

/// Test Cases:
/// []        >-1
/// [1]       >0
/// [1,2]     >-1
/// [1,2,1]   > 0
/// [1,1,1,2] > 0
/// [1,1,1,2,2,2,2,1,1,1] > 0
/// [1,1,1,1,2,2,2,2,1] > 0
class Solution 
{
    /// <param name="A">[0..100,000] integers -Int.MaxValue to Int.MaxValue</param>
    public int solution(int[] A) 
    {
        int elementSize = 0;
        int elementInt = 0;
        
        for (int i=0; i<A.Length; i++)
        {
            if (elementSize == 0)
            {
                elementInt = A[i]; 
                elementSize++;
            }
            else if (A[i] == elementInt)
            {
                elementSize++;
            }
            else if (A[i] != elementInt)
            {
                elementSize--;
            }
        }
        
        int index = -1;
        if (elementSize > 0) 
        {
            int count = 0;
            for (int i=0; i<A.Length; i++)
            {
                if (A[i] == elementInt)
                {
                    if (index == -1) index = i;
                    count++;                    
                }
            }
            
            if (2 * count <= A.Length) index = -1;
        }
        
        return index;
    }
}