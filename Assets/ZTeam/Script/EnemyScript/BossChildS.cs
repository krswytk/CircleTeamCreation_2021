using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossChildS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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
        }else if (this.gameObject.name == "part2")
        {
            Debug.Log("part2に当たった");
        }
    }
}
