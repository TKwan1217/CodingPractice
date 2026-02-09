using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string[] solution(string[] players, string[] callings) {
        Dictionary<string, int> player_dict = new Dictionary<string, int>();
        
        for(int i = 0; i < players.Length; i++){
            player_dict[players[i]] = i;
        }
        
        for(int i = 0; i < callings.Length; i++){
            
            //현재 불린 사람 순위 앞으로 당기기
            string current_call = callings[i];
            int key = player_dict[current_call];
            player_dict[current_call] = key - 1;
            
            //앞에 순위 사람 뒤로 보내기
            string pushed = players[key-1];
            player_dict[pushed] = key;
            
            //players 배열 순서 바꿔주기
            string temp = players[key];
            players[key] = players[key-1];
            players[key-1] = temp;
        }
        //다시 배열로 변환
        string[] answer = player_dict
            .OrderBy(x => x.Value)
            .Select(x => x.Key)
            .ToArray();
        
        return answer;
    }
}