using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clear : MonoBehaviour
{
    public GameObject tclear;
    // Start is called before the first frame update
    void Start()
    {
        tclear.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            tclear.gameObject.SetActive(true);
        }
    }

}
