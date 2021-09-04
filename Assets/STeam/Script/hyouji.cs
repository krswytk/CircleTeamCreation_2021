using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hyouji : MonoBehaviour
{
    [SerializeField]
    GameObject g;

    bool flag;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (flag == true && (Input.GetKeyDown(KeyCode.Z)))
        {
            SceneManager.LoadScene("STeam/Scenes/Title_s");
        }

    }

    public void a()
    {
        g.SetActive(true);
        flag = true;
    }

}
