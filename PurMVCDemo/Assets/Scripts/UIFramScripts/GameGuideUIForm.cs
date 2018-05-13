using UnityEngine;
using System.Collections;
using SUIFW;

public class GameGuideUIForm : BaseUIForm {

    void Awake()
    {
        CurrentUIType.UIForms_ShowMode = UIFormShowMode.HideOther; 

        RigisterButtonObjectEvent("BtnGuidOK",
            p => OpenUIForm("GamePlayUIFrom")
            
            );
    }
}
