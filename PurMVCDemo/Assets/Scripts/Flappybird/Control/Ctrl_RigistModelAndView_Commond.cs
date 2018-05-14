using UnityEngine;
using System.Collections;
using PureMVC.Patterns;

/// <summary>
/// 命令层
/// </summary>
public class Ctrl_RigistModelAndView_Commond : SimpleCommand {


    public override void Execute(PureMVC.Interfaces.INotification notification)
    {
        base.Execute(notification);
        Facade.RegisterProxy(new Model_GameDataProxy());
        Facade.RegisterMediator(new View_GamePlayingMediator()); 
    }
}
