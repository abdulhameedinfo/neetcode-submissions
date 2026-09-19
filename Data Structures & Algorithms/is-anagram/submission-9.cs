public class Solution {
    public bool IsAnagram(string s, string t) {
      if (s.Length != t.Length)
            return false;

        var counts = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            counts[s[i]] = counts.GetValueOrDefault(s[i]) + 1;
            counts[t[i]] = counts.GetValueOrDefault(t[i]) - 1;
        }

        foreach (var count in counts.Values)
        {
            if (count != 0)
                return false;
        }

        return true;
    }
}
