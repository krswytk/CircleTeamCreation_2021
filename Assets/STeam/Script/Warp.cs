using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Warp : MonoBehaviour
{
    SceneData scene;
    Menu menu;

    string roomname = "STeam/Scenes/room/";
    string roukaname, s;
    Vector3 vec, startvec;

    void Start()
    {
        scene = GameObject.FindWithTag("GameManager").GetComponent<SceneData>();
        menu = GetComponent<Menu>();

        if (SceneManager.GetActiveScene().name.Contains("rouka") && vec != Vector3.zero)
        {
            this.transform.position = vec;
            vec = Vector3.zero;
        }
        else if (SceneManager.GetActiveScene().name.Contains("rouka") && roukaname != null)
        {
            startvec = GameObject.Find(roukaname).transform.position;
            this.transform.position = startvec;
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
                        roukaname = SceneManager.GetActiveScene().name;//教室の入り口に戻れる用に廊下の名前取得
                        roomname += other.gameObject.name;
                        vec = this.transform.position;

                        //シーンを読み込む前にこれを呼び出してデータの引継ぎをする
                        SceneManager.sceneLoaded += scene.GameSceneLoaded;
                        SceneManager.LoadScene(roomname);
                    }

                    if (other.gameObject.tag == "outdoor")
                    {
                        //シーンを読み込む前にこれを呼び出してデータの引継ぎをする
                        SceneManager.sceneLoaded += scene.GameSceneLoaded;
                        SceneManager.LoadScene("STeam/Scenes/rouka/" + roukaname);
                    }

                    if (other.gameObject.tag == "rouka")
                    {
                        s = other.gameObject.name;
                        roukaname = SceneManager.GetActiveScene().name;
                        //vec = Vector3.zero;
                        //シーンを読み込む前にこれを呼び出してデータの引継ぎをする
                        SceneManager.sceneLoaded += scene.GameSceneLoaded;
                        SceneManager.LoadScene("STeam/Scenes/rouka/" + s);
                    }

                }
            }
        }

    }

    public void setvector(Vector3 v, string s)
    {
        vec = v;
        roukaname = s;
    }

    public Vector3 getvector()
    {
        return vec;
    }

    public string getname()
    {
        return roukaname;
    }
}