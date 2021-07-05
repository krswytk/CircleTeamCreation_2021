﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Status : MonoBehaviour
{
    public int statusG;
    public int statusHP;
    public int attackP;
    private bool FireS=false;
    public Text Gold;
    public Text Hitpoint;
    public Text Attack;
    public Text izyou;
    public GameObject GameOverText;
    
    // Start is called before the first frame update
    void Start()
    {
        GameOverText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Gold.text = "  G : " + statusG;
        Hitpoint.text = "HP : " + statusHP;
        Attack.text = "Power : " + attackP;

        if (statusHP <= 0)
        {
            statusHP = 0;
            GameOverText.SetActive(true);//gameover表示
        }

        BulletStatus();

    }

    public void HP(int damage)
    {
        if (statusHP != 0)
        {
            if(statusHP+damage>100)
            {
                statusHP=100;
            }
            else
            {
               statusHP += damage;
            }
        }
    }

    public void GOLD(int GetGold)
    {
        
            statusG += GetGold;
        
    }

    public void BulletStatus()
    {
        if (Input.GetKeyDown(KeyCode.Z))//射撃の際
        {
             
           for(int i=0;i<10;i++)
            {
                if(statusG>=100*i)
                {
                     
                    attackP=1+i*2;
                   // Debug.Log(attackP);//攻撃力確認用

                }
            }
        }
    }

    public void zyoutai()
    {//受け渡しを考え直すから後でやる
        if (FireS == true)
        {
            izyou.text = " 炎上" ;
        }
        else
        {
            izyou.text = " ノーマル";
        }
    }
}