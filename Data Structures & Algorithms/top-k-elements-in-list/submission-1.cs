public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> myDict = new Dictionary<int, int>();;
        foreach(int num in nums){
            if(myDict.ContainsKey(num)) myDict[num]++;
            else myDict.Add(num, 1); 
        }

        int[] topKeys = myDict.OrderByDescending(entry => entry.Value).Select(entry => entry.Key).Take(k).ToArray() ;
        return(topKeys);
    } 
}
