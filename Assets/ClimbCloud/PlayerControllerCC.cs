using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerControllerCC : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rigid2D;
    float jumpForce = 680.0f;
    float walkForce = 30.0f;
    float maxWalkSpeed = 2.0f;

    void Start()
    {
        Application.targetFrameRate = 60;
        this.rigid2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // ジャンプ
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }
        // 左右移動
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;

        // プレイヤー速度
        float speedx = Mathf.Abs(this.rigid2D.velocity.x);

        // スピード制限
        if (speedx < this.maxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }

        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }
    }
}