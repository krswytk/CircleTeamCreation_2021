using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTest : MonoBehaviour
{
    [SerializeField]
    private SoundManager soundManager; //サウンドマネージャー

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //左クリック
        {
            soundManager.sePlay("coinfire"); //サウンドマネージャーを使用して効果音再生
        }
        if (Input.GetMouseButtonDown(1)) //右クリック
        {
            soundManager.sePlay("damageenemy"); //サウンドマネージャーを使用して効果音再生
        }
        if (Input.GetKeyDown(KeyCode.X)) //Xキー
        {
            soundManager.sePlay("damageplayer");
        }
        if (Input.GetKeyDown(KeyCode.Z)) //Zキー
        {
            soundManager.sePlay("getcoin");
        }
        if (Input.GetKeyDown(KeyCode.C)) //Cキー
        {
            soundManager.sePlay("jumpplayer");
        }
        if (Input.GetKeyDown(KeyCode.V)) //Cキー
        {
            soundManager.sePlay("powerup");
        }
        if (Input.GetKeyDown(KeyCode.A)) //Cキー
        {
            soundManager.bgmPlay("bgm");
        }
    }
}