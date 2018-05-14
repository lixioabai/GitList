using UnityEngine;
using System.Collections;
using PureMVC.Patterns;

/// <summary>
/// 命令层
///（控制层）
/// 开始游戏
/// </summary>
public class Ctrl_StartGame_Commond : MacroCommand
{

    protected override void InitializeMacroCommand()
    {
        base.InitializeMacroCommand();
        //注册模型与视图Command
        AddSubCommand(typeof(Ctrl_RigistModelAndView_Commond));
        //注册重新开始
        AddSubCommand(typeof(Ctrl_ReStartGame_Commond));

    }

}
