using System;

public class Solution {
    public int[] solution(int[] numbers) {
        int[] answer = numbers;
        
        for(int i = 0; i<answer.Length; i++){
            answer[i] *= 2;
        }
        
        return answer;
    }
}