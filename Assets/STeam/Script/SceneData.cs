using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneData : MonoBehaviour
{
    ItemManager Item;
    ItemData i;
    Menu nextparent;

    private Image[] nextchild;

    private void Start()
    {
        Item = GameObject.FindWithTag("Player").GetComponent<ItemManager>();
    }

    private void FixedUpdate()
    {
        
    }

    public void GameSceneLoaded(Scene next,LoadSceneMode mode)
    {
        nextparent = GameObject.FindWithTag("Player").GetComponent<Menu>();
        nextchild = new Image[nextparent.menu.transform.childCount];

        for(int i=1;i< nextparent.menu.transform.childCount; i++)
        { 
            nextchild[i] = nextparent.menu.transform.GetChild(i).GetComponent<Image>();
        }

        for(int i = 1; i < Item.gazou.Length; i++)
        {
            if (Item.gazou[i].sprite == null) break;
            nextchild[i].sprite = Item.gazou[i].sprite;
        }

        SceneManager.sceneLoaded -= GameSceneLoaded;

    }

}
