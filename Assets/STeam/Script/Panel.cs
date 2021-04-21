using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panel : MonoBehaviour
{
    string itemtext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //textget();
    }
    void textget()
    {
     //   transform.Find("Text").gameObject.GetComponent<Text>().text = "abcd";
        transform.Find("Text").gameObject.GetComponent<Text>().text = "abcd";
    }
    public void itemTelop(string B)
    {
        itemtext = B;
        
        transform.Find("Text").gameObject.GetComponent<Text>().text = itemtext+"を手に入れた";
    }
}
