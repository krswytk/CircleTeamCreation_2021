using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyC3r_s : MonoBehaviour {
    private Transform _Transform;
    private float Rotate;
    

    void Start() {

        _Transform = GetComponent<Transform>();
        Rotate = 0;

    }
    // Update is called once per frame 
    void Update() {

        Rotate = Rotate + 2;
        _Transform.rotation = Quaternion.Euler(0, 0, Rotate);

    }
}