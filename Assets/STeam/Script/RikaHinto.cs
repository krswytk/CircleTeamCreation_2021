using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RikaHinto : MonoBehaviour
{
    PanelManager context;
    public int page;
    public bool a;
    // Start is called before the first frame update
    void Start()
    {
        a = false;
        page = 15;
        context = GameObject.FindWithTag("PanelManager").GetComponent<PanelManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKeyUp(KeyCode.Z) && a == false)
            {
                page = 0;
                Debug.Log(page);
                Debug.Log(a);
            }



            if (Input.GetKeyUp(KeyCode.Z) && a == true)
            {
                page++;
                Debug.Log(page);
                Debug.Log(a);
            }




            if (page == 0)
            {
                context.TextActive("(1/4)授業プリントのようだ　\n(Z：次のページ)");
                a = true;
            }

            if (page == 1)
            {
                context.TextActive("(2/4)ーーーという特徴がある。\nちなみに酸性の液体液体は錆取りに使えることもあり、\nそれを利用した工業製品がーーー");
                a = true;
            }

            if (page == 2)
            {
                context.TextActive("(3/4)ーーー2020年度、授業プリント");
                a = true;
            }
            if (page == 3)
            {
                context.TextActive("(4/4)・・・この年代だとすると・・・保健室にあるかもしれない");
                a = false;

            }
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            a = false;
            page = 15;

        }


    }
}