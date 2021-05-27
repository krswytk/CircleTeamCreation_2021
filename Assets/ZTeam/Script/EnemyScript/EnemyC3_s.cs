using UnityEngine;

public class EnemyC3_s : MonoBehaviour {
    private Transform _Transform;
    private float Ratete;
    

    void Start() {

        _Transform = GetComponent<Transform>();
        Ratete = 0;

    }
    // Update is called once per frame 
    void Update() {

        Ratete++;
        _Transform.rotation = Quaternion.Euler(0, 0, Ratete);

    }
}