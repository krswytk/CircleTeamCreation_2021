using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetItem : MonoBehaviour
{
   ItemManager hairetu;

    // Start is called before the first frame update
    void Start()
    {
         hairetu = GetComponent<ItemManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Item")
        {

            if (Input.GetKey(KeyCode.Z))
            {
                hairetu.getitem(other.GetComponent<Item>().s);
                Destroy(other.gameObject);
            }

        }
    }
  /*  public void Get(Sprite s)
    {
        Debug.Log("呼び出され");
        for (int i = 0; i < hairetu.Imege.Length; i++)
        {
            Debug.Log(hairetu.Imege[i].GetComponent<Image>().sprite);
            if (hairetu.Imege[i].GetComponent<Image>().sprite == null)
            {
                hairetu.Imege[i].GetComponent<Image>().sprite = s;
                break;
            }
        }
    }
    */

}
