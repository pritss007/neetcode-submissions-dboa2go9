public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length){
            return false;
        }
        List<char> splitChar = t.ToList();

        foreach(char cht in s.ToCharArray()){
            if(splitChar.Contains(cht)){
                splitChar.Remove(cht);
                continue;
            }
            else{
                return false;
            }
        }
        return true;
    }
}