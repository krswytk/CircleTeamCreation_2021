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
        if (Status.PotionHave == false)
        {
            if (Status.statusG >= 25)
            {
                Status.GOLD(-25);
                Status.PotionHave = true;
            }
            else
            {
                Debug.Log("お金が足りないため、購入できません");
            }
        }
        else
        {
            Debug.Log("重複購入はできません");
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
