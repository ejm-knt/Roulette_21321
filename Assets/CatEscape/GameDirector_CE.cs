using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector_CE : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject hpGaude;
    Image hpImage;
    GameObject hpGauge;
    float time;
    public Text timeText; //コンポーネントと同じ型にすると、初期からその型で取ってくれて設定しなくて楽らしい

    //! inspectのオブジェクトのshow/HiddenチェックマークをTrue,Falseで設定可能
    //! そのためにはTextではなく、GameObjectにしないとイジれないので、こいつはテキストだけど定義はGOにしている
    public GameObject gameOverText; 

    void Start()
    {
        hpImage = hpGaude.GetComponent<Image>();
        gameOverText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        timeText.text = $"Time:{time:F2}秒";
    }


    public void DecreaseHP(){
        this.hpImage.fillAmount -= 0.1f;
            if(hpImage.fillAmount <= 0.0f){
            gameOverText.SetActive(true);
            //! timeScale = 1 => 1倍速で時間経過。
            //! timeScale = 0 => 0倍速 => つまりゲーム停止。
            //! timeScaleの適応範囲は「Time」に関連する全てなので、移動処理とかは適応外。(GameOver後も動ける)
            Time.timeScale = 0;
        }
    }

    // public void DecreaseHp(){
	// 			// HPゲージを減らして、HPが0以下になったらGameOverテキストを表示
    //     Image hpImage = this.hpGauge.GetComponent<Image>();
    //     hpImage.fillAmount -= 0.1f;

    // }
}