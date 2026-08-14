public class Solution {
    public bool IsPalindrome(string s) {
        string combinedString = s.Replace(" ", "").ToUpper();
        string potentialPalindrome = Regex.Replace(combinedString, "[^a-zA-Z0-9]", "");
        bool isPalindrome = true;

        for(int i = 0; i < potentialPalindrome.Length; i++){
            Console.WriteLine(potentialPalindrome[i] + " " + potentialPalindrome[potentialPalindrome.Length - i - 1]);
            if(potentialPalindrome[i] != potentialPalindrome[potentialPalindrome.Length - i - 1])
                isPalindrome = false;
        }
        return isPalindrome;
    }
}
