using System;

public class Solution {
    public int[] solution(int numer1, int denom1, int numer2, int denom2) {
        int[] answer = new int[2];
        
        int gcd = GCD(denom1, denom2);
        int lcm = denom1 * denom2 / gcd;
        
        int num1 = numer1 * (lcm / denom1) + numer2 * (lcm/denom2);
        int num2 = lcm;
        
        int gcd2 = GCD(num1, num2);
        
        answer[0] = num1 / gcd2;
        answer[1] = num2 / gcd2;
        
        return answer;
    }
    
    private int GCD(int a, int b){
        while(b != 0){
            int temp = a % b;
            a = b;
            b = temp;
        }
        return a;
    }
}