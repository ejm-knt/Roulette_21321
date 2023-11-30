using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    // Start is called before the first frame update
    float rotSpeed = 0; //* 回転速度

    void Start()
    {
        //! FPSを60に固定
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        //! マウスが押されたら回転速度を設定
        if(Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10;
        }

        //! 回転速度分、ルーレットを回転させる
        transform.Rotate(0, 0, this.rotSpeed);
    }
}
