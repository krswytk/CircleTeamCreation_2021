using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCloud : MonoBehaviour
{
    float y = 0;
    float x = 0;
    Vector3 Position;
    // Start is called before the first frame update
    void Start()
    {
        x = Random.Range(0.002f, 0.004f);
    }

    // Update is called once per frame
    void Update()
    {
        Position = this.transform.position;
        Position.x += x;
        if (Position.x >= 12.1f)
        {
            y = Random.Range(3.00f, 4.45f);
            x = Random.Range(0.002f, 0.004f);
            Position.x = (-11.6f);
            Position.y = y;
        }
        gameObject.transform.position = Position;
    }
}
