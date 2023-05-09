using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0;    // 자동차 속도
    Vector2 startPos;   // 시작 좌표

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))    // 마우스 좌클릭시
        {
            // 마우스를 클릭한 좌표
            this.startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            // 마우스 버튼에서 손가락을 떼었을 때 좌표
            Vector2 endPos = Input.mousePosition;
            float swipeLength = endPos.x - this.startPos.x; // 스와이프 길이

            // 스와이프 길이로 처음 속도 변경
            this.speed = swipeLength / 500.0f;

            // 효과음 재생
            GetComponent<AudioSource>().Play();
        }

        transform.Translate(this.speed, 0, 0);  // 이동
        this.speed *= 0.98f;                    // 감속

        if (Input.GetMouseButtonDown(1))    // 마우스 우클릭시
        {
            // 자동차 정지
            this.speed = 0;
        }
    }
}
