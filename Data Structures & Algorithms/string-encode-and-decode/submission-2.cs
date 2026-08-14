public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();
        foreach(string s in strs){
            sb.Append(s.Length).Append('#').Append(s);
        }
        
        return sb.ToString();
    }

public List<string> Decode(string s) {
        List<string> decodedList = new List<string>();
        int i = 0; // The main pointer reading through the string
        
        while (i < s.Length) {
            int j = i;
            
            while (s[j] != '#') {
                j++;
            }
            
            int length = int.Parse(s.Substring(i, j - i));
            
            i = j + 1;
            
            decodedList.Add(s.Substring(i, length));
            
            i += length;
        }
        
        return decodedList;
    }
}
