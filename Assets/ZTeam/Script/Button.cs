using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    Status Status;
    GameObject Canvas;
    GameObject select;

        private void Start()
    {
        select = GameObject.Find("select");
        Canvas = GameObject.Find("Canvas");
        Status = Canvas.GetComponent<Status>();
    }
    public void Onclick()
    {
        if (Status.statusG >= 25)
        {
            Status.GOLD(-25);
        }
        else
        {
            Debug.Log("購入できません");
        }

        select.gameObject.SetActive(false);

    }

    public void Onclick2()
    {
        select.gameObject.SetActive(false);
    }
}
