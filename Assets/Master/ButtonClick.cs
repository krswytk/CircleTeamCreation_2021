using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ボタンクリックで各シーンに移動する
public class ButtonClick : MonoBehaviour
{

    public void R()
    {
        //Title_Zにシーン遷移
        feadSC.fade("Title_Z");
    }

    public void L()
    {
        //Title_Sにシーン遷移
        feadSC.fade("Title_S");
    }
}
