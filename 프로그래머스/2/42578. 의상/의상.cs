/*

확률 nCr?? -> r=1 고정 결국엔 n임.
각 종류별 경우의 수를 다 곱하기

각 종류별에서 나올 수 있는 경우는 하나를 선택하거나 하나도 선택안되거나
nC1 + nC0 = n+1C1

얼굴: 동그란 안경, 검정 선글라스, 하나도 선택안됨 -> 총 3 -> 3C1 = 3
상의: 파티, 선택안됨 -> 2
하의: 청, 선택안됨 -> 2
겉옷: 긴, 선택안됨 -> 2

3*2*2*2 = 24
단, 모두 선택안된 경우가 1개 존재하기 때문에 -1함.

총 23

*/

using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(string[,] clothes) {
        int answer = 1;

        //종류 별 개수 구하기
        var dict = new Dictionary<string, int>();
        
        for(int i = 0; i < clothes.GetLength(0); i++)
        {
            string key = clothes[i, 1];

            if(dict.ContainsKey(key))
                dict[key]++;
            else
                dict[key] = 1;
        }

        foreach(var current in dict)
        {
            answer *= (current.Value + 1);
        }
        // 모두 선택안된 경우 1 빼기
        return answer-1;
    }
}