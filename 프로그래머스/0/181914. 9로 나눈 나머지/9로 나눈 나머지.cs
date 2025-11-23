using System;

public class Solution {
    public int solution(string number) {
        int answer = 0;
        
        char[] str = number.ToCharArray();
            
        for(int i = 0; i < str.Length; i++){
            answer += int.Parse(str[i].ToString());
        }
        
        answer %= 9;
        
        return answer;
    }
}