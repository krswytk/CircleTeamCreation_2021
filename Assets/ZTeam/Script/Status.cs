using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Status : MonoBehaviour
{
    public int statusG;
    public int statusHP;
    public int attackP;
    public bool FireS=false;
    public bool PotionHave = false;
    private float Ftime=0f;
    public Text Gold;
    public Text Hitpoint;
    public Text Attack;
    public Text izyou;
    public Text Potionhave;
    public GameObject GameOverText;
    
    // Start is called before the first frame update
    void Start()
    {
        GameOverText.SetActive(false);
      
    }


    // Update is called once per frame
    void Update()
    {
        Gold.text = ": "+statusG;
        Hitpoint.text =": "+statusHP;
        Attack.text = ": " + attackP;

        if (statusHP <= 0)
        {
            statusHP = 0;
            GameOverText.SetActive(true);//gameover表示
        }

        BulletStatus();
        PotionUse();
        zyoutai();

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
        for (int i = 0; i < 10; i++)
        {
            if (statusG >= 100 * i)
            {

                attackP = 1 + i * 2;


            }
        }
     
    }

    public void PotionUse()
    {
        if (PotionHave==true) {
            Potionhave.text = "ポーション有：Cで使用";
            if (Input.GetKeyDown(KeyCode.C))
            {
                HP(25);
                PotionHave = false;
            }

        }
        else
        {
            Potionhave.text = "ポーションなし";
        }
      
    }

    public void zyoutai()
    {
        if (FireS == true)
        {
            
            izyou.text = " 炎上" ;
            
            for (int i = 0; i < 4; i++)//四回繰り返す
            {
                Ftime += Time.deltaTime;
                if (Ftime > 2)
                {//if文の中でデルタタイムが1.5Sを超えたら2ダメージを与えてリセット
                   // Debug.Log(Ftime);
                    HP(-2);
                    if (i < 3) {
                        Ftime = 0f;
                    }
                    else
                    {
                        FireS = false;//FireSをfalseにする
                    }
                   
                }
            }
        

        }
        else
        {
            izyou.text = "ノーマル";
        }
    }


}