using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public long solution(int[] weights) {
        long answer = 0;
        
        Dictionary<int, int> counts = new Dictionary<int, int>();
        
        foreach(int n in weights){
            if(counts.ContainsKey(n))
                counts[n]++;
            else
                counts[n] = 1;
        }
        
        //counts = counts.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
        var keys = counts.Keys.OrderBy(k => k);
        
        foreach(int current in keys){
            //answer += current.Value * (current.Value-1) / 2;
            answer += Find(counts, current);
        }
        
        return answer;
    }
    
    // n * 3/2 || n*4/2 || n *4/3 찾기
    public long Find(Dictionary<int, int> dict, int basekey){
        long result = 0;
        long target = dict[basekey];
        
        if(target > 1)
            //nC2
            result += target * (target-1) / 2;
        
        // 2배 거리 인 짝 찾기
        long partner = (long)basekey * 2;
        if(partner > basekey && partner <= int.MaxValue && dict.ContainsKey((int)partner)){
            result += target*(long)dict[(int)partner];
        }
        
        // 1.5배 거리 짝 찾기
        // 정수가 아니면 찾을 필요없음
        if((basekey * 3) % 2 == 0){
            partner = (basekey*3) / 2;
            if(partner > basekey && partner <= int.MaxValue && dict.ContainsKey((int)partner))
                result += target*(long)dict[(int)partner];
        }
        
        if((basekey * 4) % 3 == 0){
            partner = (basekey*4) / 3;
            if(partner > basekey && partner <= int.MaxValue && dict.ContainsKey((int)partner))
                result += target*(long)dict[(int)partner];
        }
        
        return result;
    }
}