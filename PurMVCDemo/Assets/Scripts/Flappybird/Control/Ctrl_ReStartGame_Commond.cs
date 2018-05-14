using UnityEngine;
using System.Collections;
using PureMVC.Patterns;
using SUIFW;

public class Ctrl_ReStartGame_Commond : SimpleCommand
{

    public override void Execute(PureMVC.Interfaces.INotification notification)
    {
        base.Execute(notification);
        //重新运行
        GameObject.FindGameObjectWithTag("Player").GetComponent<Ctrl_HeroControl>().StartGame();
        //得到层级视图根节点。
        GameObject goEnviromentRoot = GameObject.Find("MainGameScene");
        //管道组停止运行
        UnityHelper.FindTheChildNode(goEnviromentRoot, "GamePips").GetComponent<Ctrl_PipMove>().StartGame();
        //获取时间脚本
        goEnviromentRoot.GetComponent<Ctrl_GetTime>().StartGame();


    }
}
