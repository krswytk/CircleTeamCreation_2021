using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TransferStage_Select : MonoBehaviour
{
    [SerializeField] GameObject Panel;
   // [SerializeField] GameObject text;
    float FadeOut = -0.0025f;
    public static float alfa = 1f;
    float red, blue, green;
    public string Scene2;
    // Start is called before the first frame update
    void Start()
    {
        red = GetComponent<Image>().color.r;
        green = GetComponent<Image>().color.g;
        blue = GetComponent<Image>().color.b;
    }

    // Update is called once per frame
    void Update()
    {
        //text = GameObject.Find("Text");
        Panel = GameObject.Find("Panel");
        GetComponent<Image>().color = new Color(red, green, blue, alfa);
        alfa += FadeOut;
      
        if (alfa <= 0f)
        {
           // text.SetActive(true);
            alfa = 0f;
            FadeOut = 0;
        }
        if (Input.GetMouseButtonDown(0) && alfa == 0f)
        {
            Invoke("SceneMovement", 1);
        }
        if (Input.GetMouseButtonDown(0))
        {
            alfa = 0f;
        }
    }
    void SceneMovement()
    {
        SceneManager.LoadScene("Stage_Select");
    }
}
