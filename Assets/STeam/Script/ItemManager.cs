using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    //主にアイテムに関する関数


    //カーソルのスクリプトを触りたいので取得(非表示なので)
    [SerializeField]
    GameObject cursor;

    //クラス　カーソル 
    CursorCtrl cursornum;

    Menu m;

    //シーン引継ぎの時に配列の大きさ(子の数)を合わせるために子の親であるobjを取得
    public GameObject itemimage;

    public Image[] gazou;

    //アイテム名・詳細
    public string[] itemname, itemabout;

    //所持しているアイテムの種類　順番は取得した順
    public int[] itemkind;

    //持っているアイテムの個数　カーソルの上限やアイテムの配列の大きさが決まる
    private int havecount = 0;


    private void Start()
    {
        cursornum = cursor.GetComponent<CursorCtrl>();
        m = GameObject.FindGameObjectWithTag("Player").GetComponent<Menu>();

        //配列の初期化
        gazou = new Image[itemimage.transform.childCount];
        for (int i = 0; i < gazou.Length; i++)
        {
            gazou[i] = itemimage.transform.GetChild(i).GetComponent<Image>();
        }
    }


    void Update()
    {

    }

    public void useitem()//アイテムを消費する時は必ず呼び出す
    {
        //うわって思うかもしれないけど、cursornum.getcursor()←これはただの整数　カーソルが何番を指しているか
        if (m.opcl==true)
        {

            //カーソルで選択した画像の場所を削除、消したところを詰める
            gazou[cursornum.getcursor()].sprite = null;
            itemkind[cursornum.getcursor()] = -1;
            itemname[cursornum.getcursor()] = "null";
            itemabout[cursornum.getcursor()] = "null";

            for (int i = 0; i < gazou.Length - (cursornum.getcursor() + 1); i++)
            {
                gazou[cursornum.getcursor() + i].sprite = gazou[cursornum.getcursor() + i + 1].sprite;//画像
                itemkind[cursornum.getcursor() + i] = itemkind[cursornum.getcursor() + i + 1];//アイテムの種類
                itemname[cursornum.getcursor() + i] = itemname[cursornum.getcursor() + i + 1];//アイテム名
                itemabout[cursornum.getcursor() + i] = itemabout[cursornum.getcursor() + i + 1];//アイテム詳細
            }
            cursornum.decursor();//アイテム画像が消えたのでカーソルも手前へ移動
            decount();//アイテムがなくなったので

            m.opcl = false;
        }

    }

    public void inputitem(Sprite s)//アイテムの画像を移行
    {
        for (int i = 0; i < gazou.Length; i++)
        {
            if (gazou[i].GetComponent<Image>().sprite == null)
            {
                gazou[i].GetComponent<Image>().sprite = s;
                break;
            }
        }
    }

    public void inputitemname(string s)//アイテムの名前を移行
    {
        for (int i = 0; i < itemname.Length; i++)
        {
            if (itemname[i] == "null")
            {
                itemname[i] = s;
                break;
            }
        }
    }

    public void inputitemabout(string s)//アイテムの詳細を移行
    {
        for (int i = 0; i < itemabout.Length; i++)
        {
            if (itemabout[i] == "null")
            {
                itemabout[i] = s;
                break;
            }
        }
    }

    public string[] getabout()
    {
        return itemabout;
    }

    public int getcount()
    {
        return havecount;
    }

    public void setcount(int n)
    {
        havecount = n;
    }

    public void incount()
    {
        havecount++;
    }

    public void decount()
    {
        havecount--;
    }
}
