using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector2 startPos = new Vector2(2.0f, 1.0f);
        Vector2 endPos = new Vector2(8.0f, 5.0f);
        Vector2 dir = endPos - startPos; //! x(8-2) , y(5-1) -> dir(x:6.0f, y:4.0f) ということが起きてる
        Debug.Log(dir); //! dir(x:6.00, y:4.00)

        //! 三平方の定理を使って斜辺の長さ(ベクトル)を求める -> magnitude
        //! (6^2 + 4^2) = len(z^2) -> z^2 is ikutsu?
        //! 36 + 16 -> 52 -> 7.211... -> start-endのベクトル
        float len = dir.magnitude; 
        
        Debug.Log(len);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
