using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tool : MonoBehaviour
{
    Flag f;

    [SerializeField]
    GameObject a, b;

    // Start is called before the first frame update
    void Start()
    {
        f = GameObject.FindGameObjectWithTag("Player").GetComponent<Flag>();

        if (f.rockflag[1] == true)
        {
            // g.SetActive(true);
            a.SetActive(false);
            b.SetActive(true);

        }
        else
        {
            //gameObject.SetActive(true);

            //g.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (f.rockflag[1] == true)
        {
            // g.SetActive(true);

            b.SetActive(true);

        }
    }



}
