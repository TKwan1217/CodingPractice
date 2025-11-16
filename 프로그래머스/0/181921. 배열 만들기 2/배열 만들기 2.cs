using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int l, int r) {
        List<int> answer = new List<int>();
        
        for(int i = l; i <= r; i++){
            string s = i.ToString();
            bool valid = true;
            
            foreach(char c in s){
                if(c != '0' && c != '5'){
                    valid = false;
                    break;
                }
            }
            
            if(valid)
                answer.Add(i);
        }
        
        if(answer.Count == 0)
            answer.Add(-1);
        
        return answer.ToArray();
    }
}