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

    // Update is called once per frame
    void Update()
    {

    }
    //プレイヤーがトリガーのオブジェクトに触れたら
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "indoor")
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                scenename += other.gameObject.name;
                SceneManager.sceneLoaded += scene.GameSceneLoaded;
                SceneManager.LoadScene(scenename);
            }
        }

        if (other.gameObject.tag == "outdoor")
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                SceneManager.sceneLoaded += scene.GameSceneLoaded;
                SceneManager.LoadScene("STeam/Scenes/rouka");
            }
        }
    }
}