using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAt : MonoBehaviour
{
    public static bool lookright;
    // Start is called before the first frame update
    void Start()
    {
        lookright = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            Lookright();
        }
    }
    
    bool Lookright()//現在どの方向を向いているかをBulletに返す
    {
        float horizontalKey = Input.GetAxis("Horizontal");
        if (horizontalKey > 0) 
        {
            lookright = true;
        }
        else
        {
            lookright = false;
        }
        return lookright;
    }

}
