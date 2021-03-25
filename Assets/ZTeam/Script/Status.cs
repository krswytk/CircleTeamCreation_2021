using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Status : MonoBehaviour
{
    public int statusG;
    public int statusHP;
    public Text Gold;
    public Text Hitpoint;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Gold.text = "G : " + statusG;
        Hitpoint.text = "HP : " + statusHP;
    }
}