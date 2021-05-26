using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyC3_s : MonoBehaviour
{
    public GameObject obj;
    private Rigidbody2D rb;
    private float RSpeed=5f;
    private Vector3 axis = new Vector3(0,0,1);
    // Start is called before the first frame update
    void Start()
    {
      
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(obj.transform.position, axis, RSpeed);
    }
}
