using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    public void SceneGameStart()//ゲームシーンに移動
    {
        SceneManager.LoadScene("STeam/Scenes/rouka/East rouka");
    }

}
