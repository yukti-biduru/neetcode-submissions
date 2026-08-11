public class Solution {

    public string Encode(IList<string> strs)
        {
            // loop through each string and add the length of the string with a pound sign 
            string s = "";
            foreach(string str in strs)
            {
                s += str.Length.ToString() + "#" + str;
            }
            return s;
        }

        public List<string> Decode(string s)
                {

            int i = 0;
            int j = 0;
            List<string> res = new List<string>();
            while (i < s.Length)
            {
                j = i;
                while (s[j] != '#')
                {
                    j += 1;
                }
                int length = int.Parse(s.Substring(i, j - i).ToString());
                res.Add(s.Substring(j + 1, length));
                i = j + 1 + length;
            }
            return res;
        }
}
