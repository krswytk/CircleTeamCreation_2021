﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class furimukiS : MonoBehaviour
{
    EnemyC1 EnemyC1;
    public bool isOn = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Playerが判定に入りました");
        if (collision.tag == "player")
        {
            isOn = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.tag == "player")
        {
            isOn = false;
        }
    }
}
