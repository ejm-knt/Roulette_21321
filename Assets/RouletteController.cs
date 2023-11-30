using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    // Start is called before the first frame update
    float rotSpeed = 0; //* 回転速度

    // inspectorに表示させることで変数の変更を簡易的に行うことが出来る
    // public float addRotSpeed;

    // [SerializeField] を付けると、publicにしなくてもinspectorに表示させることが可能
    [SerializeField] float addRotSpeed;

    void Start()
    {
        //! FPSを60に固定
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        //! マウスが押されたら回転速度を設定
        //? Input.@@@ で 〇〇を入力すると となる。今回はMouseBottonDown(マウスを押した瞬間)
        //? ちなみに、MBotton(マウスを押してる間)、MBDown(マウスを押した瞬間)、MBUp(マウスを離した瞬間)
        //? ちなみのちなみに、MBD(0) の 0 は左クリックのナンバリングを指す。
        if(Input.GetMouseButton(0))
        {
            this.rotSpeed = addRotSpeed;
        }
        //! 遊びで追加。GMBでかつif-else書くと、押してる時に回って、離すと止まるようになる。
        // else
        // {
        //     this.rotSpeed = 0;
        // }

        //! 回転速度分、ルーレットを回転させる
        transform.Rotate(0, 0, this.rotSpeed);

        //! ルーレットを減速させる
        this.rotSpeed *= 0.96f;
    }
}
