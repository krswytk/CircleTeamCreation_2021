using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
   public GameObject menu;

   public bool opcl = false;//メニューを開いているかどうか

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
