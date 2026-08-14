public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        foreach(char bracket in s){
            if(bracket == '(' || 
            bracket =='{' || 
            bracket =='['){
                stack.Push(bracket);
            }
            else{
                if(stack.Count == 0){
                    return false;
                }
                char onTop = stack.Pop();
                switch (bracket){
                    case(')'):
                        if(onTop != '(') return false;
                        break;
                    case('}'):
                        if(onTop != '{') return false;
                        break;
                    case(']'):
                        if(onTop != '[') return false;     
                        break;
                }
            }
        }
        if(stack.Count != 0) return false;
        return true;
    }
}
