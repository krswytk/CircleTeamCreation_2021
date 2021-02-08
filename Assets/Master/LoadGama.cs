using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadGama : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //右矢印/Dを押した場合
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            //Title_Zにシーン遷移
            feadSC.fade("Title_Z");
        }

        //左矢印/Aを押した場合
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            //Title_Sにシーン遷移
            feadSC.fade("Title_S");
        }
    }
}
