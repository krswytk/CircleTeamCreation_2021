using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Title : MonoBehaviour
{
    int StertF = 0;//0:初期状態　1:チュートリアル　2：初めから　３：つづきから　４：遊び方
    int A = 0;
    Button button_1, button_2, button_3, button_4;

    public void Start()
    {

        button_1 = GameObject.Find("Canvas/Button_Tutorial").GetComponent<Button>();

        button_2 = GameObject.Find("Canvas/Button Hazimekara").GetComponent<Button>();

        button_3 = GameObject.Find("Canvas/Button Tuzukikara").GetComponent<Button>();

        button_4 = GameObject.Find("Canvas/Button Asobikata").GetComponent<Button>();

    }

    private void Update()
    {

       


        if (Input.GetMouseButtonUp(0))
        {


            Debug.Log("始め方");

            switch (StertF)
            {

                case 1:
                    //ボタンが選択された状態になる
                    button_1.Select();
                    break;

                case 2:
                    //ボタンが選択された状態になる
                    button_2.Select();
                    break;

                case 3:
                    //ボタンが選択された状態になる
                    button_3.Select();
                    break;

                case 4:
                    //ボタンが選択された状態になる
                    button_4.Select();
                    break;

                default:
                    Debug.Log("例外");
                    break;


            }

        }



        if (Input.GetKeyDown(KeyCode.Z))
        {

           

            switch (StertF)
            {

                case 1:
                    Debug.Log("チュートリアル");
                    SceneManager.LoadScene("STeam/Scenes/rouka/Tyutoriaru rouka");
                    break;

                case 2:
                     SceneManager.LoadScene("STeam/Scenes/rouka/North rouka");
                     StertF = 0;
                    break;

                case 3:
                    Debug.Log('a');
                    break;

                case 4:
                    Debug.Log("始め方");
                    break;

                default:
                    Debug.Log("例外");
                    break;

            }


        }

    }



    public void GameModeTYUTORIAL()//ゲームシーンに移動
    {

        StertF = 1;
        Debug.Log(StertF);
        

    }

    public void GameModeHAZIMEKARA()//ゲームシーンに移動
    {
      
        StertF = 2;
        Debug.Log(StertF);
       

    }



    public void GameModeTUZUKI()//ゲームシーンに移動
    {
       
        StertF = 3;
        Debug.Log(StertF);
        

    }

    public void GameModeASOBIKATA()
    {
        
        StertF = 4;
        Debug.Log(StertF);
        


    }


}
