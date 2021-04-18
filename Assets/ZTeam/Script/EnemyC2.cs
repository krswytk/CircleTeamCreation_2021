using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EnemyC2 : MonoBehaviour
{
    [SerializeField]
    Transform target; //追いかける対象
    NavMeshAgent agent;

    GameObject Canvas;
    Status Status;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        Canvas = GameObject.Find("Canvas");
        Status = Canvas.GetComponent<Status>();
    }


    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "mybullet" || collision.collider.tag == "Player")
        {
            Destroy(gameObject);
        }
    }


}
