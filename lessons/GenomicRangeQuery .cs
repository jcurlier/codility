using System;

class Solution 
{

    public int[] solution(string S, int[] P, int[] Q) 
    {
        char[] chars = S.ToCharArray();
        
        int[,] countPrefix = new int[4,chars.Length];
        
        int[] result = new int[P.Length];
        
        for (int i=0; i<chars.Length; i++)
        {
            if (i>0) 
            {
                countPrefix[0,i]=countPrefix[0,i-1];
                countPrefix[1,i]=countPrefix[1,i-1];    
                countPrefix[2,i]=countPrefix[2,i-1];
            }
            
            switch (chars[i])
    	    {
	            case 'A':
	                if (i==0) countPrefix[0,0]=1;
	                else countPrefix[0,i]++;
	                break;
	            case 'C':
	                if (i==0) countPrefix[1,0]=1;
	                else countPrefix[1,i]++;
	                break;
	            case 'G':
	                if (i==0) countPrefix[2,0]=1;
	                else countPrefix[2,i]++;
	                break;
    	    }
        }
        
        for (int i=0; i<P.Length; i++)
        {
            int lower = P[i];
            int upper = Q[i];
            int tmin = 0;
            
            if (chars[lower]=='A') tmin= 1;
            else if (chars[lower]=='C') tmin= 2;
            else if (chars[lower]=='G') tmin = 3;
            else tmin = 4;
            
            if (countPrefix[0,lower] != countPrefix[0,upper])
                result[i] = 1;
            else if (countPrefix[1,lower] != countPrefix[1,upper])
                result[i] = Math.Min(tmin,2);
            else if (countPrefix[2,lower] != countPrefix[2,upper])
                result[i] = Math.Min(tmin,3);
            else
                result[i] = tmin;
        }
        
        return result;
    }
}

================================

using System;

class Solution 
{

    public int[] solution(string S, int[] P, int[] Q) 
    {
        int q = P.Length;
        int[] result = new int[q];
        
        for (int i=0; i<q; i++)
        {
            int lower = P[i];
            int upper = Q[i];
            int length = upper - lower + 1;
            
            string sub = S.Substring(lower, length);
            
            if (sub.IndexOf('A') != -1) 
                result[i] = 1;
            else if (sub.IndexOf('C') != -1) 
                result[i] = 2;
            else if (sub.IndexOf('G') != -1) 
                result[i] = 3;
            else
                result[i] = 4;
            
        }
        
        return result;
    }
}


===============================

using System;

class Solution 
{

    public int[] solution(string S, int[] P, int[] Q) 
    {
        int q = P.Length;
        int[] A = Array.ConvertAll(S.ToCharArray(), new Converter<char, int>(Parse));
        
        
        int[] result = new int[q];
        
        for (int i=0; i<q; i++)
        {
            int lower = P[i];
            int upper = Q[i];
            
            int min = A[lower];
            for (int j=lower+1; j<=upper; j++)
            {
                if (A[j] < min) min = A[j];
            }
            result[i] = min;
            
        }
        
        return result;
    }
    
    public static int Parse(char c)
    {
        if (c == 'A') return 1;
        if (c == 'C') return 2;        
        if (c == 'G') return 3;        
        
        return 4;        
    }
}