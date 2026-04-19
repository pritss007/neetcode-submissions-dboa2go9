public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s1.Length > s2.Length)
        return false;

    int[] s1Count = new int[26];
    int[] windowCount = new int[26];

    // build first window
    for (int i = 0; i < s1.Length; i++)
    {
        s1Count[s1[i] - 'a']++;
        windowCount[s2[i] - 'a']++;
    }

    if (Matches(s1Count, windowCount))
        return true;

    // slide window
    for (int i = s1.Length; i < s2.Length; i++)
    {
        windowCount[s2[i] - 'a']++;                 // add new char
        windowCount[s2[i - s1.Length] - 'a']--;     // remove old char

        if (Matches(s1Count, windowCount))
            return true;
    }

    return false;
    }
    private bool Matches(int[] a, int[] b)
{
    for (int i = 0; i < 26; i++)
    {
        if (a[i] != b[i])
            return false;
    }

    return true;
}
}
