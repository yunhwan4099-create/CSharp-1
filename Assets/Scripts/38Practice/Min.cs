using UnityEngine;
using System.Linq;

namespace Practice
{
    public class Min : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //변수 선언 및 초기화
            int[] numbers = { -2, -5, -4, -7, -1 };

            //최소값을 저장하는 변수
            //최소값 초기화는 가장 큰값으로 초기화
            int minValue = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                //최소값과 배열의 값을 순서대로 크기 비교
                if (numbers[i] < minValue)
                {
                    minValue = numbers[i];  //두수를 비교하여 작으면 최소값에 저장 
                }
            }

            Debug.Log($"최소값은 {minValue}");

            int minimumValue = numbers.Min();
            Debug.Log($"Linq 최소값은 {minValue}");


        }
    }
}

/*
데이터 { -2, -5, -4, -7, -1 }
입력된 데이터중 최소값을 구하세요

[output]
최소값은 -7


// -2, -5, -4, -7, -1

minValue(최소값)  -2 => minValue = -2
-2(minValue)  -5    => minValue = -5
-5(minValue)  -4
-5(minValue)  -7    => minValue = -7
-7(minValue)  -1
-7(minValue)
*/