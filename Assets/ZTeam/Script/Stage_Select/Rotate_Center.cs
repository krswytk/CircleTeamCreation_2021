using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Center : MonoBehaviour
{
    public GameObject stage1;//= GameObject.Find("stage1");
    public GameObject stage2;//= GameObject.Find("stage2");
    public static int RotateFrequency = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       //ebug.Log(RotateFrequency);
        if(RotateFrequency%2==0)
        {
            stage1.SetActive(true);
            stage2.SetActive(false);
        }else
        {
            stage1.SetActive(false);
            stage2.SetActive(true);
        }
    }
}
