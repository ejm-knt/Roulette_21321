using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayeController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        //右矢印押した時
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-3,0,0); //左に3動く
        }

        //右矢印押した時
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(3,0,0); //右に3動く
        }
    }
}
