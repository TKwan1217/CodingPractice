using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        for(int i = 2; i <= n; i++){
            bool IsPrime = true;
            int nr = (int)Math.Sqrt(i);

            for(int j = 2; j <= nr; j++){
                if(i % j == 0){
                    IsPrime = false;
                    break;
                }
            }
            
            if(IsPrime)
                answer++;
            
        }
        
        return answer;
    }
}