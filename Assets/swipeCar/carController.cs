using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carController : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 0;

    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))        //* 左クリック
        {
            this.speed = 0.2f;                  //* 初速度
        }

        transform.Translate(this.speed, 0, 0);  //* 移動
        this.speed *= 0.98f;                    //* 減速
    }
}
