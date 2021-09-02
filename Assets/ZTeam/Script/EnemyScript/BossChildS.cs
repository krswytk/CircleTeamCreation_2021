using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossChildS : MonoBehaviour
{
    GameObject Body;
    BossS BossS;
    // Start is called before the first frame update
    void Start()
    {
        Body  = GameObject.Find("body");
        BossS = Body.GetComponent<BossS>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (this.gameObject.name == "part1")
        {
            Debug.Log("part1に当たった");
            BossS.ChangeHP();

        }else if (this.gameObject.name == "part2")
        {
            Debug.Log("part2に当たった");
            BossS.ChangeHP();
        }
    }
}
