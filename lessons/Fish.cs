using System;
using System.Collections.Generic;

class Solution 
{
    public int solution(int[] A, int[] B) 
    {
        int N = A.Length;
        int count = 0;
        
        Stack<int> downStack = new Stack<int>();
        
        for (int i=0; i<N; i++)
        {
            // going downstream
            if (B[i] == 1) 
            {
                downStack.Push(A[i]);   
            }
            // going upstream
            else
            {
                // free to go
                if (downStack.Count == 0)
                {
                    count++;
                }
                // meet somebody
                else
                {
                    while (downStack.Count > 0)
                    {
                        int down = downStack.Pop();
                        // down eats fish
                        if (down > A[i])
                        {
                            downStack.Push(down);
                            break;
                        }
                    }
                    // eats all stack, free to go
                    if (downStack.Count == 0) count++;
                }
            }
        }

        count = count + downStack.Count;
        
        return count;
    }
}