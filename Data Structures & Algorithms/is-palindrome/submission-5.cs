public class Solution {
    public bool IsPalindrome(string s) {
        int pointerLeft = 0;
        int pointerRight = s.Length - 1;
        bool isPalindrome = true;

        while(pointerLeft < pointerRight ){
            while (pointerLeft < pointerRight && !char.IsLetterOrDigit(s[pointerLeft])) { pointerLeft++; }
            while (pointerLeft < pointerRight && !char.IsLetterOrDigit(s[pointerRight])) { pointerRight--; }

            if(!(char.ToLower(s[pointerLeft]) == char.ToLower(s[pointerRight]))) return false;

            pointerLeft ++;
            pointerRight --;
        }
        return true;
    }
}
