using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneData : MonoBehaviour
{
    //シーンのデータを行き来するスクリプト

    ItemManager imane;
    Flag f;
    Warp w;

    private Image[] nextchild;

    private void Start()
    {
        imane = GameObject.FindWithTag("Player").GetComponent<ItemManager>();
        f = GameObject.FindWithTag("Player").GetComponent<Flag>();
        w = GameObject.FindWithTag("Player").GetComponent<Warp>();
    }

    //移るscene先のデータに移動前のデータで上書き
    public void GameSceneLoaded(Scene next, LoadSceneMode mode)
    {
        //次のシーンのItemManagerを持つ変数
        var nextparent = GameObject.FindWithTag("Player").GetComponent<ItemManager>();

        //次のシーンのFlagを持つ変数
        var nextflag = GameObject.FindWithTag("Player").GetComponent<Flag>();

        var nextpos= GameObject.FindWithTag("Player").GetComponent<Warp>();

        //次のシーンのImage配列の子の数分だけ、画像配列を初期化
        nextchild = new Image[nextparent.itemimage.transform.childCount];//transform.childCountで子の数を取得　要するに整数

        //次のシーンのImage配列全てにImageのコンポーネントを付与　多分配列を作っただけだとImageのコンポーネントがない
        for (int i = 0; i < imane.gazou.Length; i++)
        {
            nextchild[i] = nextparent.itemimage.transform.GetChild(i).GetComponent<Image>();
        }
        

        //////////////////主にやってること//////////////////////

        //次のシーンに、画像と保持しているアイテムの種類を渡す
        for (int i = 0; i < imane.gazou.Length; i++)
        {
            if (imane.gazou[i].sprite == null)//もし、画像に何も入っていなければbreak
            {
                //break;
            }
            nextchild[i].sprite = imane.gazou[i].sprite;
            nextparent.itemkind[i] = imane.itemkind[i];
           
            

        }

        //フラグの引継ぎ
        for (int i = 0; i < f.rockflag.Length; i++)
        {
            if (f.rockflag[i] == true) nextflag.rockflag[i] = true;
            else nextflag.rockflag[i] = false;

            if (f.getflag[i] == true) nextflag.getflag[i] = true;
            else nextflag.getflag[i] = false;

            if (f.nazoflag[i] == true) nextflag.nazoflag[i] = true;
            else nextflag.nazoflag[i] = false;
        }

        nextpos.setvector(w.getvector(),w.getname());

        //ここで次のシーンへ、持っているアイテムの個数を譲渡
        nextparent.setcount(imane.getcount());

        //SceneManager.sceneLoaded -= GameSceneLoaded;

    }

}
