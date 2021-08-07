using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MyDialogInput : Fungus.DialogInput
{
    protected override void Update()
    {
        base.Update();
        if (EventSystem.current == null)
        {
            return;
        }

        if (writer != null && writer.IsWriting)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {  //ここを好きなキーに設定する
                SetNextLineFlag();
            }
        }
    }
}