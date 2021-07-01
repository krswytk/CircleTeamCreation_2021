using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject menu;
    public GameObject image;

    public bool opcl = false;//メニューを開いているかどうか

    void Start()
    {

    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.C)) opcl = !opcl;

        //ずっと呼び出すのはなぁ…
        if (opcl == false)
        {
            menu.SetActive(false);
            image.SetActive(false);

        }

        if (opcl == true)
        { 
            menu.SetActive(true);
            image.SetActive(true);

        }


    }
}
