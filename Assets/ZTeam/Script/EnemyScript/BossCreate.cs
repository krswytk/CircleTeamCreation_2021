using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossCreate : MonoBehaviour
{
    public GameObject Boss;
    private bool BossCreated=false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (BossCreated == false)
        {
            if (collision.gameObject.tag == "Player")
            {
                BossCreated = true;
                GameObject.Instantiate(Boss, transform.position, Quaternion.Euler(0f, 0f, 0f));

                Destroy(gameObject);
            }
        }
      
    }
}
