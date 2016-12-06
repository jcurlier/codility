using System;
using System.Collections.Generic;

class Solution 
{
    public int[] solution(int N, int[] A) 
    {
        int[] result = new int[N]; 
        
        Dictionary<int,int> addOps = new Dictionary<int,int>();
        int max = 0;
        int adder = 0;
     
        for (int i=0; i<A.Length; i++)
        {
            if (A[i] == N + 1)  // special code to set all to current max
            {
                addOps.Clear();
                adder = adder + max; // keep what we need to add all values at the end
                max = 0;
            }
            else
            {
                if (addOps.ContainsKey(A[i]-1))
                {
                    addOps[A[i]-1] = addOps[A[i]-1] + 1;
                }
                else
                {
                    addOps[A[i]-1] = 1;
                }

                if (addOps[A[i]-1] > max) max = addOps[A[i]-1];
            }    
        }    
        
        for (int i=0; i<N; i++)
        {
            result[i] = adder;
            if (addOps.ContainsKey(i))
            {
                result[i] = result[i] + addOps[i];
            }
        }
        
        return result;
    }
}

===================================================================


using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution 
{
    public int[] solution(int N, int[] A) 
    {
        int[] result = new int[N]; 

        HashSet<int> addOps = new HashSet<int>();
        int max = 0;
        int adder = 0;
     
        for (int i=0; i<A.Length; i++)
        {
            if (A[i] == N + 1)  // special code to set all to current max
            {
                result = new int[N];
                adder = adder + max; // keep what we need to add all values at the end
                max = 0;
            }
            else
            {
                result[A[i]-1]++;
                if (result[A[i]-1] > max) max = result[A[i]-1];
            }    
        }    
        
        for (int i=0; i<N; i++)
        {
            result[i] = result[i] + adder;
        }
        
        return result;
    }
}




================================


class Solution 
{
    public int[] solution(int N, int[] A) 
    {
        int[] result = new int[N]; 
        int max = 0;
     
        for (int i=0; i<A.Length; i++)
        {
            if (A[i] == N + 1)  // special code ro set all to current max
            {
                for (int j=0; j<N; j++) result[j] = max;
                
            }
            else
            {
                result[A[i]-1]++;
                if (result[A[i]-1] > max) max = result[A[i]-1];
            }    
        }    
        
        return result;
    }
}

================

using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution 
{
    public int[] solution(int N, int[] A) 
    {
        int[] counters = new int[N];
        
        int min = int.MinValue;
        int tmin = 0;
        
        int length = A.Length;
        
        for(int i = 0; i < length; i++) 
        {
            int index = A[i] - 1;
            if (index == N) 
            {
                min = tmin;
            } 
            else 
            {
                if (counters[index] < min) 
                {
                    counters[index] = min;
                }
                
                counters[index]++;
                
                if (tmin < counters[index]) 
                {
                    tmin = counters[index];
                }
            }
        }
        
        for(int i = 0; i<N; i++) 
        {            
            if (counters[i] < min) 
            {
                counters[i] = min;
            }
        }
        
        return counters;
    }
}