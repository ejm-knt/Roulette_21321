using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CarController : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 0;
    Vector2 startPos;
    AudioSource audioSource;

    void Start()
    {
        Application.targetFrameRate = 60;
            // 初期位置の取得（のつもり）
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            this.startPos = Input.mousePosition;
        }
        else if(Input.GetMouseButtonUp(0))
        {
            Vector2 endPos = Input.mousePosition;
            float swipeLength = endPos.x - this.startPos.x;

            this.speed = swipeLength / 500.0f;

            audioSource.Play();
        }

        // if (Input.GetMouseButton(2))        //* 左クリック
        // {
        //     this.speed = 0.2f;                  //* 初速度
        // }

        transform.Translate(this.speed, 0, 0);  //* 移動
        this.speed *= 0.98f;                    //* 減速
    }

}