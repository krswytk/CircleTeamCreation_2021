using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    //アイテムを取得したかどうか
    public bool getflag=false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnItem()
    {
        this.enabled = true;
    }

    public void OffItem()
    {
        this.enabled = false;
    }

}
