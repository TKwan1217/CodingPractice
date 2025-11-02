using System;

public class Solution {
    public int[] solution(int n) {
        int[] answer = new int[n % 2 == 0? n/2 : n/2+1];
        
        for(int i = 0; i < answer.Length; i++){
            answer[i] = 1 + i*2;
        }
        
        return answer;
    }
}