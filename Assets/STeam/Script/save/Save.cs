using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Save : MonoBehaviour
{
    ItemManager imane;
    Flag f;
    Warp w;
    Pl p=new Pl();

    [System.Serializable]
    public class Pl
    {
        [SerializeField]
        public Image[] gazou = new Image[18];
        public string[] itemname = new string[18], itemabout = new string[18];
        public int[] itemkind = new int[18];
        public bool[] rockflag=new bool[18], getflag = new bool[18], nazoflag = new bool[18];
        public Vector3 vec;
        public string str;
        public int have;

    }
    void Start()
    {
        imane = GameObject.FindWithTag("Player").GetComponent<ItemManager>();
        f = GameObject.FindWithTag("Player").GetComponent<Flag>();
        w = GameObject.FindWithTag("Player").GetComponent<Warp>();


        for (int i = 0; i < 18; i++)
        {
            p.itemkind[i] = -1;
            p.itemname[i] = "null";
            p.itemabout[i] = "null";
        }


        Invoke("a", 0.01f);
        Invoke("b", 0.03f);

    }


    void a()
    {

        for (int i = 0; i < 9; i++)
        {
            p.gazou[i] = imane.itemimage.transform.GetChild(i).GetComponent<Image>();
        }

        for (int i = 0; i < imane.gazou.Length; i++)
        {
            if (imane.gazou[i].sprite != null) p.gazou[i].sprite = imane.gazou[i].sprite;
            if (imane.itemkind[i] != -1) p.itemkind[i] = imane.itemkind[i];
            if (imane.itemname[i] != "null") p.itemname[i] = imane.itemname[i];
            if (imane.itemabout[i] != "null") p.itemabout[i] = imane.itemabout[i];

        }

        for (int i = 0; i < f.rockflag.Length; i++)
        {
            if (f.rockflag[i] == true) p.rockflag[i] = true;
            else p.rockflag[i] = false;

            if (f.getflag[i] == true) p.getflag[i] = true;
            else p.getflag[i] = false;

            if (f.nazoflag[i] == true) p.nazoflag[i] = true;
            else p.nazoflag[i] = false;
        }

        //遷移時の初期場所
        p.vec = w.getvector();
        p.str = w.getname();

        //ここで次のシーンへ、持っているアイテムの個数を譲渡
        p.have = imane.getcount();

        SaveData.SetString("scene_name", SceneManager.GetActiveScene().name);
        SaveData.SetClass<Pl>("p1", p);
        SaveData.Save();
    }

    void b()
    {
        if (Title.tuduki == true)
        {
            Pl getPl = SaveData.GetClass<Pl>("p1", p);

            for (int i = 0; i < 9; i++)
            {
                getPl.gazou[i] = imane.itemimage.transform.GetChild(i).GetComponent<Image>();
            }

            for (int i = 0; i < 9; i++)
            {
                if (getPl.gazou[i].sprite != null) imane.gazou[i].sprite = getPl.gazou[i].sprite;
                if (getPl.itemkind[i] != -1) imane.itemkind[i] = getPl.itemkind[i];
                if (getPl.itemname[i] != "null") imane.itemname[i] = getPl.itemname[i];
                if (getPl.itemabout[i] != "null") imane.itemabout[i] = getPl.itemabout[i];

            }

            for (int i = 0; i < getPl.rockflag.Length; i++)
            {
                if (getPl.rockflag[i] == true) f.rockflag[i] = true;
                else f.rockflag[i] = false;

                if (getPl.getflag[i] == true) f.getflag[i] = true;
                else f.getflag[i] = false;

                if (getPl.nazoflag[i] == true) f.nazoflag[i] = true;
                else f.nazoflag[i] = false;
            }

            w.setvector(getPl.vec, getPl.str);
            imane.setcount(getPl.have);
        }
    }

    void Update()
    {

    }
}
