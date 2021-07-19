using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    Status Status;
    ShopS ShopS;
    GameObject Canvas;
    GameObject select;
    GameObject shop;


        private void Start()
    {
        shop = GameObject.Find("shop");
        select = GameObject.Find("select");
        Canvas = GameObject.Find("Canvas");
        Status = Canvas.GetComponent<Status>();
        ShopS = shop.GetComponent<ShopS>();
    }
    public void Onclick()
    {
        if (Status.statusG >= 25)
        {
            Status.GOLD(-25);
        }
        else
        {
            Debug.Log("購入できません");
        }

        select.gameObject.SetActive(false);
        ShopS.ShopOpen = false;

    }

    public void Onclick2()
    {
        select.gameObject.SetActive(false);
        ShopS.ShopOpen = false;
    }
}
