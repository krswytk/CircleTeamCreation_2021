using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Textchecker : MonoBehaviour
{
    public GameObject back;
    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            back.gameObject.SetActive(true);
            text.gameObject.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            text.gameObject.SetActive(false);
            back.gameObject.SetActive(false);
        }
    }
}
