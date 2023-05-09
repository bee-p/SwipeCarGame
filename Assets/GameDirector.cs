using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   // UI 사용에 필요

public class GameDirector : MonoBehaviour
{
    GameObject car;
    GameObject flag;
    GameObject distance;

    void Start()
    {
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("Distance");
    }

    void Update()
    {
        // 깃발에서 자동차까지의 거리 구하기
        float length = this.flag.transform.position.x - this.car.transform.position.x;

        if (length >= 0)
        {
            this.distance.GetComponent<Text>().text = "목표 지점까지 " + length.ToString("F2") + "m";
        }
        else
        {
            this.distance.GetComponent<Text>().text = "게임 오버!";
        }
    }
}
