/*
- 문자 순서대로 검사
1. 열린 괄호가 나오는 경우 stack 배열에 닫힌 괄호 집어넣기
2. 닫힌 괄호가 나온 경우 stack에 맨 뒤 배열에 있는 지 확인
    2-1. 맨 뒤 배열하고 다른 경우 X
    2-2. 같을 경우 stack에서 삭제 후 계속 검사
3. 모든 문자 검사했으면 O (answer++)
*/

using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        int s_length = s.Length;
        string rotation;
        //딕셔너리로 괄호끼리 맵핑
        var bracket = new Dictionary<char, char>
        {
            {'(', ')'},
            {'{', '}'},
            {'[', ']'}
        };
        
        if( s_length > 1 ) {            
            //문자열 길이만큼 회전
            for(int i = 0; i < s_length; i++){
                //스택 배열
                var stack = new List<char>();

                //모두 검사했는 지 확인하는 변수
                bool IsCompleted = true;

                //skip, take 이용하여 문자열 회전
                rotation = new string(s.Skip(i).Concat(s.Take(i)).ToArray());

                for(int j = 0; j < rotation.Length; j++){
                    char c = rotation[j];

                    //현재 문자열이 열린 문자열
                    if(bracket.ContainsKey(c)){
                        //마지막 문자열이 열려있으면 실패
                        if( j == rotation.Length - 1 )
                            IsCompleted = false;
                        else
                            stack.Add(bracket[c]);
                    }

                    //현재 문자열이 닫힌 문자열
                    else{
                        if( c == stack.LastOrDefault() )
                            stack.RemoveAt(stack.Count - 1);
                        else{
                            IsCompleted = false;
                            break;
                        }
                    }
                }

                //모두 검사 완료 && stack이 비어져있으면 성공
                if( IsCompleted && stack.Count == 0 )
                    answer++;

            }
        }
        
        return answer;
    }
}