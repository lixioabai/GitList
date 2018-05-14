using UnityEngine;
using System.Collections;
using SUIFW;
using PureMVC.Patterns;

public class GameGuideUIForm : BaseUIForm {

    void Awake()
    {
        CurrentUIType.UIForms_ShowMode = UIFormShowMode.HideOther;

        RigisterButtonObjectEvent("BtnGuidOK",
            p =>
            {
                OpenUIForm("GamePlayUIFrom");
                //MVC启动命令
                Facade.Instance.SendNotification("Reg_StartGameCommand");
            }
            );
    }
}
