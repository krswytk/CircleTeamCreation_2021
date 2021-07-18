using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    private GameObject child;
    private void Start()
    {
        child = transform.GetChild(0).gameObject;

        child.GetComponent<RectTransform>().SetAsLastSibling();
       
    }
    void Update()
    {
       

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Stage_1");
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            SceneManager.LoadScene("Stage_Select");
        }
    }
}
