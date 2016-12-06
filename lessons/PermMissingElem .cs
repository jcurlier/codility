using System;
using System.Linq;

class Solution 
{
    public int solution(int[] A) 
    {
        long n = A.Length;
        long rangeSum = (n+1)*(n+2)/2;
        long sum = A.Select(x => (long) x).Sum();
                  
        return (int) (rangeSum - sum);
    }
}

//
long n = 100;
int a[] = new int[n];

//XOR of all numbers from 1 to n
// n%4 == 0 ---> n
// n%4 == 1 ---> 1
// n%4 == 2 ---> n + 1
// n%4 == 3 ---> 0

long xor = (n % 4 == 0) ? n : (n % 4 == 1) ? 1 : (n % 4 == 2) ? n + 1 : 0;

for (long i = 1; i <= n; i++)
{
    xor = xor ^ a[i];
}
//Missing number
System.out.println(xor);


using System;

class Solution 
{
    public int solution(int[] A) 
    {
        int n = A.Length;
        int result = 0 ^ (n+1);
            
        for (int i=0; i<n; i++)
        {
            result ^= A[i];
            result ^= (i + 1);
        }
        
        return result;
    }
}