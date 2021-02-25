using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    [SerializeField]
    private int itemnum = 4;

   public Image[] gazou;
    Menu m;
    int n = 1;

    // Start is called before the first frame update
    void Start()
    {
        m = GetComponent<Menu>();
    }

    // Update is called once per frame
    void Update()
    {
        //アイテム使用
        if (m.opcl == true)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                gazou[n].sprite = null;
                for(int i = 0; i < gazou.Length-(n+1); i++)
                {
                    gazou[n+i].sprite = gazou[n+ i+1].sprite;
                }
                gazou[gazou.Length-1].sprite = null;

            }
        }
    }

    public void getitem(Sprite s)
    {
        Debug.Log("呼び出され");
        for (int i = 0; i < gazou.Length; i++)
        {
            Debug.Log(gazou[i].GetComponent<Image>().sprite);
            if (gazou[i].GetComponent<Image>().sprite == null)
            {
                gazou[i].GetComponent<Image>().sprite = s;
                break;
            }
        }
    }

}
