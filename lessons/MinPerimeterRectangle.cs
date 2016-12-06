using System;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

/// Test cases: 1,2,3,4,5,6, 999999991, 999999997, 9999999999, 1000000000
class Solution 
{
    /// <summary>Find mimimal perimeter of rectangle whose area equals N</summary
    /// <param name="N">area of the rectangle 1..1,000,000,000</param>
    /// <returns>minimal perimeter</returns>
    public int solution(int n) 
    {
        int perimeter = 0;
        
        double s = Sqrt(n);
        int i = (int) s;
        
        while (i>0)
        {
            if ((n % i) == 0)
            {
                perimeter = 2 * ((n / i) + i);    
                break;
            }
            i--;    
        }       
        
        return perimeter;
    }   
}