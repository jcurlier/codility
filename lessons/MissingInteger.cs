using System;
using System.Collections.Generic;

class Solution 
{
    public int solution(int[] A) 
    {
        HashSet<int> set = new HashSet<int>();
        for (int i=0; i<A.Length; i++)
        {
            if (A[i] > 0) set.Add(A[i]);
        }
        
        for (int i=1; i <= int.MaxValue; i++)
        {
            if (!set.Contains(i)) 
            {
                return i;
            }
        }
        
        return 0;
    }
}

==============

using System;
using System.Linq;

class Solution 
{
    public int solution(int[] A) 
    {
        int result = 1;
        
        int[] B = A.Where(x => x > 0).GroupBy(x => x).Select(g => g.First()).OrderBy(x => x).ToArray();

        if (B.Length > 0 && B.Length == B[B.Length-1]) 
        {
            result = B.Length + 1;
        }
        else
        {
            for (int i=1; i<=B.Length; i++)
            {
                if (B[i-1] != i) 
                {
                    result = i;
                    break;
                }                
            }
        }
        
        return result;        
    }
}







===========

public int solution(int[] A)
{
int Max = A.Max();
if (Max <= 0)
return 1;

var ba = new BitArray(A.Max());

foreach (int a in A)
if(a > 0)
ba.Set(a - 1, true);

int Index = ba.Length;
for (int i = 0; i < ba.Length; i++)
if (!ba.Get(i))
{
Index = i+1;
break;
}

if (Index == ba.Length)
return ba.Length + 1;

return Index;
}

    HashSet<integer> set = new HashSet<>();
    for (int i=0; i<A.length; i++)
      if A[i] > 0 set.Add(A[i]);

    for int i=1l MAX VALUE; i++
       if !set.Contains   return i


    return 1;   