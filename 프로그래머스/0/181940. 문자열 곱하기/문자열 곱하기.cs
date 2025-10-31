using System.Text;

public class Solution {
    public string solution(string my_string, int k) {
        StringBuilder answer = new StringBuilder();
        
        for (int i = 0; i < k; i++){
            answer.Append(my_string);
        }
        
        return answer.ToString();
    }
}