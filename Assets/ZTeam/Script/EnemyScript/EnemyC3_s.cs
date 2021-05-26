using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyC3_s : MonoBehaviour
{
    public GameObject gObject;
    private Rigidbody2D rb;
	private float speed;
    private Vector3 axis;

    // Start is called before the first frame update
    void Start()
    {
        axis =new Vector3(0,0,1);
        speed = 5.0f;

        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
           transform.RotateAround(gObject.transform.position, axis, speed);
    }
        
}
