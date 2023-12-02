using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;


public class GameDirector_SC : MonoBehaviour
{
    public GameObject car;
    public GameObject flag;
    public GameObject distance;
    // Start is called before the first frame update
    void Start()
    {
        // this.car = GameObject.Find("car_0");
        // this.flag = GameObject.Find("flag_0");
        // this.distance = GameObject.Find("distance_0");
    }

    // Update is called once per frame
    void Update()
    {
        float length = this.flag.transform.position.x - this.car.transform.position.x;
        this.distance.GetComponent<Text>().text = "Distance:" + length.ToString("F2") + "m";
    }
}
