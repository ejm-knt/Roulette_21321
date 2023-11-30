using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vecter2 startPos = new Vecter2(2.0f, 1.0f);
        Vecter2 endPos = new Vecter2(8.0f, 5.0f);
        Vecter2 dir = endPos - startPos;
        Debug.Log(dir);

        float len = dir.magnitude;
        Debug.Log(len);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
