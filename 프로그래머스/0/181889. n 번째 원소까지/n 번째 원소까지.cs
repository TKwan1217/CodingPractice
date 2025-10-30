using System;

public class Solution {
    public int[] solution(int[] num_list, int n) {
        int[] answer = new int[n];
        int index = 0;
        
        for(int i = 0; i < n; i++){
            answer[index++] = num_list[i];
        }
        return answer;
    }
}