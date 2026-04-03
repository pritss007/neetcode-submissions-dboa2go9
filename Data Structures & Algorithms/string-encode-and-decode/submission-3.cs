public class Solution {

    public string Encode(IList<string> strs) {
        string outStr = string.Empty;
       foreach (string s in strs) 
        {
            outStr += s.Length + "#" + s;
        }
        return outStr;
    }

    public List<string> Decode(string s) {
        List<string> result = new();

        int i=0;
        while(i < s.Length){
            int j = i;
            
            while (s[j] != '#')
                j++;

            int length = int.Parse(s.Substring(i, j-i));

            string word = s.Substring(j+1, length);
            result.Add(word);

            i = j+1 + length;
        }
        return result;
   }
}
