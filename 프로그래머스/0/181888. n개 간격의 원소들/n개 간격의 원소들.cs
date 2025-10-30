using System;

public class Solution {
    public int[] solution(int[] num_list, int n) {
        int count = (int)Math.Ceiling((double)num_list.Length / n);
        int[] answer = new int[count];
        
        int index = 0;
        for (int i = 0; i < num_list.Length; i += n) {
            answer[index++] = num_list[i];
        }

        return answer;
    }
}