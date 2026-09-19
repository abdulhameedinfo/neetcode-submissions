public class Solution {
    public bool IsAnagram(string s, string t) {
        var sChars = s.ToCharArray();
        var tChars = t.ToCharArray();

        var sDict = new Dictionary<char, int>();
        var tDict = new Dictionary<char, int>();

        for(var i = 0; i < sChars.Length; i++)
        {
            var count = sDict.GetValueOrDefault(sChars[i], 0);
            sDict[sChars[i]] = count == 0 ? 1 : count + 1;
        }
        
        for(var i = 0; i < tChars.Length; i++)
        {
            var count = tDict.GetValueOrDefault(tChars[i], 0);
            tDict[tChars[i]] = count == 0 ? 1 : count + 1;
        }

        if(sDict.Count != tDict.Count)
        {
            return false;
        }

        // Compare
        for(var i = 0; i < sDict.Count(); i++)
        {
            var key = sDict.ElementAt(i).Key;
            
            if(!tDict.ContainsKey(key))
            {
                return false;
            }
            
            if(sDict[key] != tDict[key])
            {
                return false;
            }
        }

        return true;
    }
}
