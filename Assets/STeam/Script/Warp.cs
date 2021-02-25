using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Warp : MonoBehaviour
{
    public static bool inout=false;//教室内か外か static変数でどのシーンからも共通している


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //プレイヤーがトリガーのオブジェクトに触れたら
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "A-1")
        {
            if (inout == false)
            {
                incord("A-1");
            }
            else
            {
                outcord();
            }
        }

        if (other.gameObject.name == "A-2")
        {
            if (inout == false)
            {
                incord("A-2");
            }
            else
            {
                outcord();
            }
        }

        if (other.gameObject.name == "B-1")
        {
            if (inout == false)
            {
                incord("B-1");
            }
            else
            {
                outcord();
            }
        }

    }
    //教室名を引数に取り、そのシーンをロード
    public void incord(string s)
    {
        s = "STeam/Scenes/" + s;

        if (Input.GetKeyDown(KeyCode.Z))
        {
            SceneManager.LoadScene(s);
            inout = true;
        }
    }

    //廊下に移動
    public void outcord()
    {

        if (Input.GetKeyDown(KeyCode.Z))
        {
            SceneManager.LoadScene("STeam/Scenes/rouka");
            inout = false;
        }
    }

}
/*if (other.gameObject.name == "教室の入り口のobjの名前")
        {
            if (inout == false)
            {
                incord("教室の名前");
            }
            else
            {
                outcord();
            }
        }
 */