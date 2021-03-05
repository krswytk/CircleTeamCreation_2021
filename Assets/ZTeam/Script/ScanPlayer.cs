using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScanPlayer : MonoBehaviour
{
    private string PlayerTag = "Player";
    private bool isPlayerIn = false;
    private bool isPlayerEnter, isPlayerStay, isPlayerExit;

    public bool IsPlayerIn()
    {
        if (isPlayerEnter || isPlayerStay)
        {
            isPlayerIn = true;
        }
        else if (isPlayerExit)
        {
            isPlayerIn = false;
        }

        isPlayerEnter = false;
        isPlayerStay = false;
        isPlayerExit = false;
        return isPlayerIn;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == PlayerTag)
        {
            Debug.Log("Playerが判定に入りました");
            isPlayerEnter = true;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.tag == PlayerTag)
        {
            Debug.Log("Playerが判定に入り続けています");
            isPlayerStay = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.tag == PlayerTag)
        {
            Debug.Log(" Playerが判定をでました");
            isPlayerExit = true;
        }
    }
}
