using UnityEngine;
using System.Collections;
using PureMVC.Patterns;

public class Model_GameDataProxy : Proxy {

    //类的名称
    public new const string NAME = "Model_GameDataProxy";
    //游戏数据实体类
    private Model_GameData _GameData;

    public Model_GameDataProxy():base(NAME)
    {
        _GameData = new Model_GameData();
        //得到最高分

        _GameData.HighScore = PlayerPrefs.GetInt("GameHighScore");

    }

    //增加游戏的时间
    public void AddGameTime()
    {
        ++_GameData.GameTime;
        //数值发送到视图层
        SendNotification("Msg_DisPlayGameInfo", _GameData);
    }

    //增加分数
    public void AddScores()
    {
        ++_GameData.Score;
        //更新最高分数

    }

    //得到最高分数
    public int GetHightsScores()
    {
        if (_GameData.Score > _GameData.HighScore)
        {
            _GameData.HighScore = _GameData.Score;
        }

        return _GameData.HighScore;
    }

    //保存最高分数
    public void SaveHighestScore()
    {
        if (_GameData.HighScore > PlayerPrefs.GetInt("GameHighScore"))
        {
           PlayerPrefs.SetInt("GameHighScore", _GameData.HighScore);
        }
    }


}
