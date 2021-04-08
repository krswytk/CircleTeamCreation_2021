using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Warp : MonoBehaviour
{
    SceneData scene;
    Menu menu;

    string scenename = "STeam/Scenes/";
    Vector3 vec;

    void Start()
    {
        scene = GameObject.FindWithTag("GameManager").GetComponent<SceneData>();
        menu = GetComponent<Menu>();
       
        if (SceneManager.GetActiveScene().name == "rouka"&&vec!=Vector3.zero)
        {
            this.transform.position = vec;
        }
    }


    //プレイヤーが入り口のオブジェクトに触れたら
    private void OnTriggerStay(Collider other)
    {
        if (menu.opcl == false)
        {
            if (other.gameObject.GetComponent<Rock>() == false)//入り口にRockのスクリプトがアタッチされてないなら
            {
                if (Input.GetKeyDown(KeyCode.Z))
                {
                    if (other.gameObject.tag == "indoor")
                    {
                        scenename += other.gameObject.name;
                        vec = this.transform.position;
                        
                        //シーンを読み込む前にこれを呼び出してデータの引継ぎをする
                        SceneManager.sceneLoaded += scene.GameSceneLoaded;
                        SceneManager.LoadScene(scenename);
                    }

                    if (other.gameObject.tag == "outdoor")
                    {
                        //シーンを読み込む前にこれを呼び出してデータの引継ぎをする
                        SceneManager.sceneLoaded += scene.GameSceneLoaded;
                        SceneManager.LoadScene("STeam/Scenes/rouka");
                    }
                }
            }
        }

    }

    public void setvector(Vector3 v)
    {
        vec = v;
    }

    public Vector3 getvector()
    {
        return vec;
    }
}