using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneData : MonoBehaviour
{
    ItemManager imane;
    Flag f;

    private Image[] nextchild;

    private void Start()
    {
        imane = GameObject.FindWithTag("Player").GetComponent<ItemManager>();
        f = GameObject.FindWithTag("Player").GetComponent<Flag>();
    }

    public void GameSceneLoaded(Scene next, LoadSceneMode mode)
    {
        var nextparent = GameObject.FindWithTag("Player").GetComponent<ItemManager>();
        var nextflag = GameObject.FindWithTag("Player").GetComponent<Flag>();
        nextchild = new Image[nextparent.parent.transform.childCount];

        for (int i = 0; i < imane.gazou.Length; i++)
        {
            nextchild[i] = nextparent.parent.transform.GetChild(i).GetComponent<Image>();
        }
        
        for (int i = 0; i < imane.gazou.Length; i++)
        {
            if (imane.gazou[i].sprite == null)
            {
                break;
            }
            nextchild[i].sprite = imane.gazou[i].sprite;
            nextparent.itemkind[i] = imane.itemkind[i];
           
            //Debug.Log(imane.itemkind[i]);
            //Debug.Log(nextparent.itemkind[i]);

        }

        for (int i = 0; i < imane.gazou.Length; i++)
        {
           // if (f.itemhave[i] == true) nextflag.itemhave[i] = true;
            //else nextflag.itemhave[i] = false;

            if (f.getflag[i] == true) nextflag.getflag[i] = true;
            else nextflag.getflag[i] = false;

            if (f.nazoflag[i] == true) nextflag.nazoflag[i] = true;
            else nextflag.nazoflag[i] = false;
        }

        //ここで次のシーンへ、持っているアイテムの個数を譲渡
        nextparent.setcount(imane.getcount());

        //SceneManager.sceneLoaded -= GameSceneLoaded;

    }

}
