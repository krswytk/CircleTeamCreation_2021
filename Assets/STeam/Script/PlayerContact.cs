using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContact : MonoBehaviour
{
    PanelManager p;

    void Start()
    {
        p = GameObject.FindWithTag("PanelManager").GetComponent<PanelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay(Collision collision)
    {
        if (Input.GetKey(KeyCode.Z))
        {
            if (collision.gameObject.name == "gareki"){
                p.TextActive("瓦礫があって先に進むことができない");
            }
        }
    }
}
