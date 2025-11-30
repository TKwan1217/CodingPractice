using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] answers) {
        List<int> answer = new List<int>();
        
        int[] player1 = new int[] {1, 2, 3, 4, 5};
        int[] player2 = new int[] {2, 1, 2, 3, 2, 4, 2, 5};
        int[] player3 = new int[] {3, 3, 1, 1, 2, 2, 4, 4, 5, 5};
        int score1 = 0;
        int score2 = 0;
        int score3 = 0;
        
        for (int i = 0; i < answers.Length; i++){
            if(answers[i] == player1[i%player1.Length]) 
                score1++;
            if(answers[i] == player2[i%player2.Length]) 
                score2++;
            if(answers[i] == player3[i%player3.Length]) 
                score3++;
        }
        
        int max_score = Math.Max(score1, Math.Max(score2, score3));
        
        if(max_score == score1) answer.Add(1);
        if(max_score == score2) answer.Add(2);
        if(max_score == score3) answer.Add(3);
        
        return answer.ToArray();
    }
}