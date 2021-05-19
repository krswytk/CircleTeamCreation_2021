using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fadeText : MonoBehaviour
{
    private GameObject text/*= GameObject.Find("Text")*/;
    
    float alfa = 0;
    float Fade=0.01f;
    float fade;
    float red, blue, green;
    // Start is called before the first frame update
    void Start()
    {
        text = GameObject.Find("Text");
        //text.SetActive(false);
        red = GetComponent<Text>().color.r;
        green = GetComponent<Text>().color.g;
        blue = GetComponent<Text>().color.b;
    }

    // Update is called once per frame
    void Update()
    {
        
       // text = GameObject.Find("Text");
       
        if (TransferStage_Select.alfa <= 0.25f)
        {
           // text.SetActive(true);
        }  
        alfa += Fade;
        print(alfa);

            GetComponent<Text>().color = new Color(red, green, blue, alfa);
            if (alfa <= 0)
            {
                Fade = 0.01f;
            }
            else if (alfa >= 1f)
            {
                Fade = -0.01f;
            }
    }
    
}
