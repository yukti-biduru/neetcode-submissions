public class Solution {

    public string Encode(IList<string> strs) {
        string res = ""; 
        foreach(string str in strs)
        {
            res += str.Length + "#" + str;
        }
        return res;
    }

    public List<string> Decode(string s) {
        List<string> res = new List<string>(); 
        int index = 0;
        while (index != s.Length)
        {
            int j = index; 
            var slen = "";
            while (s[j] != '#')
            {
                slen += s[j];
                j+=1;
            }
            var length = int.Parse(slen);
            string subs = s.Substring(index + slen.Length+1, length);
            res.Add(subs);
            index = length+1+j;
        }
        return res;
   }
}
