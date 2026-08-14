public class Solution {

    public string Encode(IList<string> strs) {
        string encodedStr = "";
        for(int i = 0; i < strs.Count; i++){
            encodedStr += strs[i] + 'é';
        }
        
        return encodedStr;
    }

    public List<string> Decode(string s) {
        List<string> decodedList = s.Split('é').ToList();
        decodedList.RemoveAt(decodedList.Count - 1);
        return decodedList;
   }
}
