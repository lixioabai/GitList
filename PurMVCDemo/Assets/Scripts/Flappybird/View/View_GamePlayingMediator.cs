using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using PureMVC.Patterns;
using UnityEngine.UI;
using SUIFW;

public class View_GamePlayingMediator : Mediator {

    public new const string NAME = "View_GamePlayingMediator";

    private Text _TxtGameTime;
    private Text _TxtShowGameTime;

    private Text _TxtGameScore;
    private Text _TxtShowGameScore;

    private Text _TxtGameHighestScore;
    private Text _TxtShowGameHighestScore;


    public View_GamePlayingMediator():base(NAME)
    {
        //得到层级视图根节点
        GameObject goRootCanvas = GameObject.Find("Canvas(Clone)");

        _TxtGameTime = UnityHelper.GetTheChildNodeComponetScripts<Text>(goRootCanvas, "TextTime");
        _TxtShowGameTime = UnityHelper.GetTheChildNodeComponetScripts<Text>(goRootCanvas, "TextTimeShow");

        _TxtGameScore = UnityHelper.GetTheChildNodeComponetScripts<Text>(goRootCanvas, "TextScore");
        _TxtShowGameScore = UnityHelper.GetTheChildNodeComponetScripts<Text>(goRootCanvas, "TextScoreShow");

        _TxtGameHighestScore = UnityHelper.GetTheChildNodeComponetScripts<Text>(goRootCanvas, "TextHighScore");
        _TxtShowGameHighestScore = UnityHelper.GetTheChildNodeComponetScripts<Text>(goRootCanvas, "TextHighScoreShow");


        _TxtGameTime.text = "时间是";
        _TxtGameScore.text = "分数是";
        _TxtGameHighestScore.text = "最高分是";
    }


    /// <summary>
    /// 允许可以接受的消息列表sss
    /// </summary>
    /// <returns></returns>
    public override IList<string> ListNotificationInterests()
    {
        IList<string> listResult = new List<string>() ;
        listResult.Add("Msg_DisPlayGameInfo");
        return listResult;
    }

    /// <summary>
    /// 处理接受到的消息列表
    /// </summary>
    /// <param name="notification"></param>
    public override void HandleNotification(PureMVC.Interfaces.INotification notification)
    {
        Model_GameData gameData = null;
        switch (notification.Name)
        {
            case "Msg_DisPlayGameInfo":
                gameData = notification.Body as Model_GameData;
                if (gameData != null && _TxtShowGameTime != null && _TxtShowGameHighestScore != null && _TxtShowGameHighestScore!=null)
                {
                    _TxtShowGameTime.text = gameData.GameTime.ToString();
                    _TxtShowGameScore.text = gameData.Score.ToString();
                    _TxtShowGameHighestScore.text = gameData.HighScore.ToString();
                }
                break;

            default:
                break;
        }
        base.HandleNotification(notification);
    }
}
