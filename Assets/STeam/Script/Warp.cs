using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Warp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "A-1")
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                SceneManager.LoadScene("STeam/Scenes/A-1");
            }
        }

        if (other.gameObject.name == "A-2")
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                SceneManager.LoadScene("STeam/Scenes/A-2");
            }
        }

        if (other.gameObject.name == "B-1")
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                SceneManager.LoadScene("STeam/Scenes/B-1");
            }
        }

    }
}
