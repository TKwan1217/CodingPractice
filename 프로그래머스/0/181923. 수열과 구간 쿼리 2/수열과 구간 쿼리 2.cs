using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        int len = queries.GetLength(0);
        int[] answer = new int[len];
        
        for(int i = 0; i < len; i++){
            int s = queries[i, 0];
            int e = queries[i, 1];
            int k = queries[i, 2];
            
            int min = int.MaxValue;
            bool find = false;
            
            for(int j = s; j <= e; j++){
                if(arr[j] > k && arr[j] < min){
                    min = arr[j];
                    find = true;
                }
            }
            
            answer[i] = find ? min : -1;
        }
        return answer;
    }
}