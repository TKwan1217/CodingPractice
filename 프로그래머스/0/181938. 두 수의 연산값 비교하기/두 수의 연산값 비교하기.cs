using System;

public class Solution {
    public int solution(int a, int b) {
        int result1 = Convert.ToInt32(a.ToString() + b.ToString());
        int result2 = 2 * a * b;
        
        int answer = result1 >= result2 ? result1 : result2;
        return answer;
    }
}