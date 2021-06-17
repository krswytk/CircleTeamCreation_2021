using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateL_Center : MonoBehaviour
{
 
    public GameObject CenterMarker;//= GameObject.Find("CenterMarker");
    public GameObject stage1;
    public GameObject stage2;
    public GameObject Rrotate;
    bool rotStart = false,rota=true;
    float speed = 3.0f;
    float rotAngle = 180f;
    float variation;
    float rot;
    int  j = 1;
    public static int RotateTotal=0;
    //Start is called before the first frame update
    void Start()
    {
        //CenterMarker = GameObject.Find("CenterMarker");

        variation = rotAngle / speed;
    }

    //Update is called once per frame
    void Update()
    {
        // Debug.Log(rotStart);
        if (rotStart)
        {
            RotateTotal++;
            CenterMarker.transform.Rotate(0, j, 0);
            Debug.Log(RotateTotal);
            Debug.Log(rotStart);
            //rot += variation * Time.deltaTime;
            if (RotateTotal % 180 == 0)
            {
                rotStart = false;
                //rota = true;
                Rrotate.SetActive(true);
                //CenterMarker.transform.localRotation = Quaternion.Euler(0, 0, 0);
            }
        }
        if (RotateTotal % 360 == 90)
        {
            stage1.SetActive(false);
            stage2.SetActive(true);
        }
        if (RotateTotal % 360 == 270)
        {
            stage1.SetActive(true);
            stage2.SetActive(false);
        }
        //Debug.Log(i);
    }
    public void OnClick()
    {
        // Debug.Log("押された!");
        rot = 0f;
        //CenterMarker.transform.localRotation = Quaternion.Euler(0, 0, 0);
        rotStart = true;
       // rota = false;
        Rrotate.SetActive(false);
        //this.gameObject.SetActive(false);
    }
}

