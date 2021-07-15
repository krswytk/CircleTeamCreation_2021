using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Goal_Stage1 : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
    }
    void SceneMoveStage2()
    {
        SceneManager.LoadScene("Stage_2");
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("すり抜けた！");
        Invoke("SceneMoveStage2",5);
    }
}
