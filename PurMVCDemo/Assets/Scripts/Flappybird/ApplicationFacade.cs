using UnityEngine;
using System.Collections;
using PureMVC.Patterns;
using SUIFW;

public class ApplicationFacade : Facade 
{
    public ApplicationFacade()
    {
          //注册控制层
        RegisterCommand("Reg_StartGameCommand",typeof(Ctrl_StartGame_Commond));
        RegisterCommand("Reg_EndGameCommand", typeof(Ctrl_EndGame_Commond));

        //添加游戏脚本
        AddGameObjectScripts();


         //注册核心的命令层


         //添加游戏对象脚本



    }


    /// <summary>
    /// 添加游戏对象脚本
    /// </summary>
    void AddGameObjectScripts()
    { 
        //得到层级视图的根对象
        GameObject goEvenRoot = GameObject.Find("MainGameScene");
        

       //添加主角控制脚本
        GameObject.FindGameObjectWithTag("Player").AddComponent<Ctrl_HeroControl>();

        //动态挂载陆地移动脚本
        UnityHelper.AddChildNodeCompnent<Ctrl_LandMove>(goEvenRoot, "GameLadning");

        //动态挂载管道
        UnityHelper.AddChildNodeCompnent<Ctrl_PipMove>(goEvenRoot, "GamePips");

        //挂载游戏对象
        for (int i = 0; i <=3; i++)
        {
            UnityHelper.AddChildNodeCompnent<Ctrl_Pipe>(goEvenRoot, "Pip"+i+"_Up");
             UnityHelper.AddChildNodeCompnent<Ctrl_Pipe>(goEvenRoot, "Pip"+i+"_Down");
        }

        goEvenRoot.AddComponent<Ctrl_GetTime>();
    }

}
