using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyC4 : MonoBehaviour
{
    float EnemyPosY;
    // Start is called before the first frame update
    void Start()
    {
        EnemyPosY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
       
        transform.position = new Vector3(transform.position.x, EnemyPosY + Mathf.Sin(2*Time.time)/2, transform.position.z);
    }
}
