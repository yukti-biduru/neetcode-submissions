public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
        {
            return false; 
        }

        char[] sarr = s.ToCharArray(); 
        char[] tarr = t.ToCharArray(); 
        Array.Sort(sarr); 
        Array.Sort(tarr); 

        return sarr.SequenceEqual(tarr); 
    }
    // Sort - O(nlogn)
    // Time Complexity - O(nlogn + mlogm)
    // Space Complexity - O(1) + O(n+m)
}
