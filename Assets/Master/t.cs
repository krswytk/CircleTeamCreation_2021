using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class t: MonoBehaviour
{
    public Sprite s;
    Sprite SC;

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("呼び出し");
            other.GetComponent<tac>().GetItem(s);
        }
    }
}


