using System;

public class Solution {
    public int solution(string ineq, string eq, int n, int m) {
        if(ineq == "<" && eq == "=")
            return n <= m ? 1 : 0;
        else if(ineq == ">" && eq == "=")
            return n >= m ? 1 : 0;
        else if(ineq == ">" && eq == "!")
            return n > m ? 1 : 0;
        else if(ineq == "<" && eq == "!")
            return n < m ? 1 : 0;
        else 
            return 0;
    }
}