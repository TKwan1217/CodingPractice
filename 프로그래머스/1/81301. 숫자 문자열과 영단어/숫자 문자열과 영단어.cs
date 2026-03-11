using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        
        string[] NumArray = new string[] {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
        
        for(int i = 0; i < NumArray.Length; i++){
            s = s.Replace(NumArray[i], i.ToString());
        }
        answer = int.Parse(s);
        return answer;
    }
}