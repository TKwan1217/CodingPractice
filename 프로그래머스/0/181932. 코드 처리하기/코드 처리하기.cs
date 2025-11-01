using System;
using System.Linq;

public class Solution {
    public string solution(string code) {
        string ret = "";
        int mode = 0;
        for(int idx = 0; idx < code.Length; idx++){
            if(mode == 0){
                if(code[idx] == '1')
                    mode = 1;
                else if(idx % 2 == 0)
                    ret += code[idx];
            }
            else{
                if(code[idx] == '1')
                    mode = 0;
                else if(idx % 2 == 1)
                    ret += code[idx];
            }
        }
        return ret == "" ? "EMPTY" : ret;
    }
}