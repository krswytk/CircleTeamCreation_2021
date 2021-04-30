using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    int StertF = 0;//0:初期状態　1:チュートリアル　2：初めから　３：つづきから　４：遊び方
    int A = 0;



    private void Update()
    {
        Debug.LogError(StertF);


        StertF = GameModeHAZIMEKARA();
        if (Input.GetKeyDown(KeyCode.Z) && StertF == 1)
        {
            //zキーが押されたときの処理

            

            SceneManager.LoadScene("STeam/Scenes/rouka/East rouka");

            StertF = 0;
        }
    }


    



    public int　GameModeHAZIMEKARA()//ゲームシーンに移動
    {

        StertF = 1;


        return StertF;


    }








}
