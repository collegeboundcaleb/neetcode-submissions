public class Solution {
    public bool IsAnagram(string s, string t) {

        string inputS = s;
        char[] charactersS = inputS.ToCharArray();
        Array.Sort(charactersS);
        string resultS = new string(charactersS); // Output: "act"

        string inputT = t;
        char[] charactersT = inputT.ToCharArray();
        Array.Sort(charactersT);
        string resultT = new string(charactersT); // Output: "act"

        if(resultT == resultS){
            return true;
        }
        else{
            return false;
        }
    }
}
