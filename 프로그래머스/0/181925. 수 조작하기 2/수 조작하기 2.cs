using System;
using System.Text;

public class Solution {
    public string solution(int[] numLog) {
        StringBuilder answer = new StringBuilder();
        
        for(int i = 1; i < numLog.Length; i++){
            int diff = numLog[i] - numLog[i-1];
            if(diff == 1)
                answer.Append('w');
            else if(diff == -1)
                answer.Append('s');
            else if(diff == 10)
                answer.Append('d');
            else if(diff == -10)
               answer.Append('a');
        }
        
        return answer.ToString();
    }
}