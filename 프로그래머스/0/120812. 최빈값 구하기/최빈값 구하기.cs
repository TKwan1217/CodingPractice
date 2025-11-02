using System;

public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        
        int max_num = 0;
        for(int i = 0; i < array.Length; i++){
            if(max_num < array[i])
                max_num = array[i];
        }
        
        int[] count = new int[max_num+1];
        for(int i = 0; i < array.Length; i++){
            count[array[i]]++;
        }
        
        int max = 0;
        for(int i = 0; i < count.Length; i++){
            if(max < count[i]){
                max = count[i];
                answer = i;
            }
        }
        
        int num = 0;
        for(int i = 0; i < count.Length; i++){
            if(max == count[i])
                num++;
        }
        
        return num > 1 ? -1:answer;
    }
}