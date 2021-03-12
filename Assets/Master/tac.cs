using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tac : MonoBehaviour
{
    public GameObject[] Box;

    private void Start()
    {
        /*
        Box = new Image[3];
        for (int i = 1; i < Box.Length + 1; i++)
        {
            Debug.Log("item" + i);
            Box[i - 1] = GameObject.Find("item" + i).GetComponent<Image>();
        }
        */
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Box[1].GetComponent<Image>().sprite = null;
            Box[1].GetComponent<Image>().sprite = Box[2].GetComponent<Image>().sprite;
            Box[2].GetComponent<Image>().sprite = null;
        }
    }

    public void GetItem(Sprite s)
    {
        Debug.Log("呼び出され");
        for (int i = 0; i < Box.Length; i++)
        {
            Debug.Log(Box[i].GetComponent<Image>().sprite);
            if (Box[i].GetComponent<Image>().sprite == null)
            {
                Box[i].GetComponent<Image>().sprite = s;
                break;
            }
        }
    }
}
