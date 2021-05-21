﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{

    //寿司を格納する変数
    public GameObject sushi;
    [SerializeField]
    float y=0.8f, z=-3.3f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 sushiPos = sushi.transform.position;

        //カメラとプレイヤーの位置を同じにする
        transform.position = new Vector3(sushiPos.x, y, z);
    }
}