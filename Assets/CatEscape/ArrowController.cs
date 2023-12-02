using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    void Update()
    {
        // フレームごとに等速で落下させる
        transform.Translate(0,-0.1f,0);

        // 画面外に出たらオブジェクトを破棄する
        if(transform.position.y < -5.0f){
            Destroy(gameObject);
        }
    }

    // 他のオブジェクトのコライダーに当たった時実行
    void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.name == "player"){
            // 監督スクリプトにプレイヤーと衝突したことを伝える
            GameObject director = GameObject.Find("GameDirector_CE");
            director.GetComponent<GameDirector_CE>().DecreaseHP();
            // this.GameDirector.GetComponent<GameDirector_CE>().DecreaseHP(); //無理だった
            Destroy(gameObject);
        }
    }
}