using System;

public class Solution {
    public long solution(long n) {
        // 자리수 계산
        long a = 1;
        int len = 0;

        while (n / a > 0) {
            a *= 10;
            len++;
        }

        // 각 자리 숫자 분리
        int[] arr = new int[len];
        a /= 10; // a를 가장 큰 자리수(예: n=12345 → a=10000)로 맞춤
        long temp = n;

        for (int i = 0; i < len; i++) {
            arr[i] = (int)(temp / a);   // 맨 앞자리 추출
            temp %= a;                  // 나머지로 다음 자리 준비
            a /= 10;                    // 자리수 한 단계 낮춤
        }

        for (int i = 0; i < len - 1; i++) {
            for (int j = i + 1; j < len; j++) {
                if (arr[i] < arr[j]) {
                    int tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;
                }
            }
        }

        long result = 0;
        for (int i = 0; i < len; i++) {
            result = result * 10 + arr[i];
        }

        return result;
    }
}