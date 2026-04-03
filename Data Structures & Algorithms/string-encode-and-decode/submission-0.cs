public class Solution {

    public string Encode(IList<string> strs) {
        List<string> outStr = new();
        foreach(string str in strs){
            int count = str.Length;
            outStr.Add($"{count}#{str}");
        }
        return string.Join("", outStr);
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
