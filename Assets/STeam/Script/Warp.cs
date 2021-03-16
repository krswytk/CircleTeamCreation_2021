using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Warp : MonoBehaviour
{
    SceneData scene;

    string scenename = "STeam/Scenes/";
    //public static bool inout=false;//教室内か外か static変数でどのシーンからも共通している

    // Start is called before the first frame update
    void Start()
    {
        scene = GameObject.FindWithTag("GameManager").GetComponent<SceneData>();
    }

   
    //プレイヤーがトリガーのオブジェクトに触れたら
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (other.gameObject.tag == "indoor")
            { 
                scenename += other.gameObject.name;
                SceneManager.sceneLoaded += scene.GameSceneLoaded;
                SceneManager.LoadScene(scenename);
            }
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (other.gameObject.tag == "outdoor")
            {
                SceneManager.sceneLoaded += scene.GameSceneLoaded;
                SceneManager.LoadScene("STeam/Scenes/rouka");
            }
        }
    }
}