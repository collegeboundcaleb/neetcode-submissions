public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        Dictionary<string, List<string>> anagramDict = new Dictionary<string, List<string>>();
        foreach(String str in strs){
            char[] charArrstr = str.ToArray();
            Array.Sort(charArrstr);
            string result = new string(charArrstr);

            if(!anagramDict.ContainsKey(result))
            {
                anagramDict.Add(result, new List<string>());
            }
            anagramDict[result].Add(str);
        }
        return new List<List<string>>(anagramDict.Values);
    }

}
