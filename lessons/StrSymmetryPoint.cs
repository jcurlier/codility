using System;

/// Tests
/// 'a'         -> 0
/// 'aa'        -> -1
/// 'ab'        -> -1
/// 'abc'       -> 0
/// 'aba'       -> 1
/// 'racecar'   -> 3
class Solution 
{
    /// <summary>
    /// Returns index such taht string to the left of that character 
    /// is a reversal of the part of the string to its right
    /// </summary
    /// <param name="S"></param>
    /// <returns>index (counting from 0)</returns>
    public int solution(string S) 
    {
        int length = S.Length;
        if (length % 2 == 0) return -1;
        
        int index = (length-1) / 2;
        string left = S.Substring(0, index + 1);
        string right = S.Substring(index);
        
        char[] arr = right.ToCharArray();
        Array.Reverse(arr);
	    string reverseRight =  new string(arr);
        
        if (left == reverseRight) return index;
        
        return -1;
    }
}