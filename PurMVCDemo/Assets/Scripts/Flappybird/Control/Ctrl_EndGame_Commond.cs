using UnityEngine;
using System.Collections;
using PureMVC.Patterns;
using SUIFW;
public class Ctrl_EndGame_Commond : SimpleCommand
{

    public override void Execute(PureMVC.Interfaces.INotification notification)
    {
       
        //停止脚本运行
        StopScriptsRunning();
        //关闭当前UI窗体  回到玩法介绍界面
        CloseCurrentUIForms();
        //保存当前最高分数

    }


    private void StopScriptsRunning()
    {
        //结束运行
        GameObject.FindGameObjectWithTag("Player").GetComponent<Ctrl_HeroControl>().StopGame();

        //得到层级视图的根对象
        GameObject goEvenRoot = GameObject.Find("MainGameScene");

        //管道组复位
        UnityHelper.FindTheChildNode(goEvenRoot, "GamePips").GetComponent<Ctrl_PipMove>().EndGame();

        //获取时间脚本
        goEvenRoot.GetComponent<Ctrl_GetTime>().StopGame();
    }

    void CloseCurrentUIForms()
    {
        UIManager.GetInstance().CloseUIForms("GamePlayUIFrom");
    }
}
