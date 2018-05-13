using UnityEngine;
using System.Collections;
using SUIFW;

public class StartUIForm : BaseUIForm {

	
	void Awake () 
    {
        RigisterButtonObjectEvent("ImageBackGround",
            p => OpenUIForm("GameGuideUIForm")
            );
	}

    private void Start()
    { 
        //启动MVC
        new ApplicationFacade();
    }
	
}
