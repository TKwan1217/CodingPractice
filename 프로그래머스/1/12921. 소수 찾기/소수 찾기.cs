using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        //배열 칸과 실제 for문 i 맞추기 위해 n+1
        bool[] prime = new bool[n+1];
        
        for(int i = 2; i <= n; i++){
            prime[i] = true;
        }
        
        //Ex) 16 = 1*16, 2*8 , 4*4, 8*2, 16*1
        //Ex) 5 = 1*5, root5 * root5, 5*1 
        //가운데 제곱근까지만 구하면 대칭되는 지 확인 가능
        //제곱근 + 에라토스테네스의 체 알고리즘
        //에라토스테네스의 체 알고리즘 > i 부터 제곱근 까지 Loop > 현재 i의 배수들을 소수에서 제거
        for(int i = 2; i <= Math.Sqrt(n); i++){
            if(prime[i]){
                int j = 2;
                while(i * j <= n){
                    prime[i*j] = false;
                    j++;
                }
            }
        }
        
        for(int i = 2; i <= n; i++){
            if(prime[i])
                answer++;
        }
        
        return answer;
    }
}