using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateR_Center : MonoBehaviour
{
    public GameObject CenterMarker;//= GameObject.Find("CenterMarker");
    public GameObject stage1;
    public GameObject stage2;
    public GameObject Lrotate;
    bool rotStart = false;
   //float speed = 3.0f;
   //float rotAngle = 180f;
    //float variation;
    //float rot;
    int i = 0, Rj=2;
    //Start is called before the first frame update
    void Start()
    {
        //CenterMarker = GameObject.Find("CenterMarker");

        //variation = rotAngle / speed;
    }

   //Update is called once per frame
    void Update()
    {
      // Debug.Log(rotStart);
        if (rotStart)
        {
            i++;
            CenterMarker.transform.Rotate(0, -Rj, 0);
           // Debug.Log(RotateL_Center.RotateTotal++);
           // Debug.Log(rotStart);
            //rot += variation * Time.deltaTime;
            if (i %90==0)
            {
                rotStart = false;
                Lrotate.SetActive(true);
                //CenterMarker.transform.localRotation = Quaternion.Euler(0, 0, 0);
            }
            if (i % 90 == 44)
            {
                Rotate_Center.RotateFrequency++;
            }
        }
       /* if(i%360==90)
        {
            stage1.SetActive(false);
            stage2.SetActive(true);
        }
        if(i%360==270)
        {
            stage1.SetActive(true);
            stage2.SetActive(false);
        }*/
        //Debug.Log(i);
    }
    public void OnClick()
    {
       // Debug.Log("押された!");
       if(Rj==0)
        {
            Rotate_Center.RotateFrequency++;
        }
       //rot = 0f;
       //CenterMarker.transform.localRotation = Quaternion.Euler(0, 0, 0);
       rotStart = true;
        Lrotate.SetActive(false);
       //this.gameObject.SetActive(false);
    }
}
