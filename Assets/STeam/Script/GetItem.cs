using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItem : MonoBehaviour
{
    Item item;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Item")
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                //item.OffItem();
                Destroy(other.gameObject);
            }
        }
    }
}
