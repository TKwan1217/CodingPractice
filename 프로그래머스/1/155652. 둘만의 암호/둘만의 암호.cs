using System;

public class Solution {
    public string solution(string s, string skip, int index) {
        string answer = "";
        int s_Length = s.Length;
        int skip_Length = skip.Length;
        
        for(int i = 0; i < s_Length; i++){
            // a = 0 , z =25로 하기위해 a를 뺌
            int s_num = (char)(s[i] - 'a');
            int index_num = s_num;
            
            for(int j = 1; j <= index; j++){
                index_num++;
                // z를 넘어가는 경우가 있으므로 나머지로 초기화
                // z + 20(최대 인덱스) = 45 > 45 % 26 > 19 > S
                index_num %= 26;
                
                //더한 숫자가 skip문자열에 포함되는 지 확인
                //true면 index_num 계속 추가
                while(skip.Contains((char)(index_num + 'a'))){
                    index_num++;
                    index_num %= 26;
                }
            }
            
            answer += (char)(index_num + 'a');
        }
        
        
        return answer;
    }
}