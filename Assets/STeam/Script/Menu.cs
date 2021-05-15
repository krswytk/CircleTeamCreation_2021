using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
   public GameObject menu;

   public bool opcl = false;//メニューを開いているかどうか

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (opcl == false)
            {
                menu.SetActive(true);
                opcl = true;
               // Time.timeScale = 0;
            }
            else
            {
               // Time.timeScale=1;
                menu.SetActive(false);
                opcl = false;
            }
        }
    }
}
