using System;
using System.Linq;

class Solution 
{
    public int solution(int[] A) 
    {
        int sum = A.Sum();
        int min = int.MaxValue;
        int first = 0, second = 0;
        
        for (int i=0; i<A.Length-1; i++)
        {
            first = first + A[i];
            second = sum - first;
            //Console.WriteLine($"{first} {second} = {first - second}");
            min = Math.Min(min, Math.Abs(first - second));
        }
        
        return min;
    }
}
