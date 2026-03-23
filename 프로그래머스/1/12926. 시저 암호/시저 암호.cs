public class Solution {
    public string solution(string s, int n) {
        string answer = "";
        
        foreach(char c in s){
            int temp = c;
            //공백인 경우
            if(c == ' '){
                answer += ' ';
            }
            //대문자인 경우
            //A=65 ~ Z=90
            else if(65 <= c && c <= 90){
                temp += n;
                if(temp > 90){
                    temp = 64 + (temp % 90);
                }
                answer += (char)temp;
            }
            //소문자인 경우
            //a=97 ~ z=122
            else{
                temp += n;
                if(temp > 122){
                    temp = 96 + (temp % 122);
                }
                answer += (char)temp;
            }
        }
        
        return answer;
    }
}