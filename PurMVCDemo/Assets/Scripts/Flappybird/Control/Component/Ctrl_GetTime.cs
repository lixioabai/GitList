using UnityEngine;
using System.Collections;
using PureMVC.Patterns;

/// <summary>
/// 每格一秒钟取得一次时间
/// </summary>
public class Ctrl_GetTime : MonoBehaviour {

    public Model_GameDataProxy dataProxy = null;

    //游戏是否开始

    private bool IsStartGame = false;

    /// <summary>
    /// 游戏开始
    /// </summary>
    public void StartGame()
    {
        IsStartGame = true;
        dataProxy = Facade.Instance.RetrieveProxy(Model_GameDataProxy.NAME) as Model_GameDataProxy;

    }

    /// <summary>
    /// 游戏结束
    /// </summary>
    public void StopGame()
    {
        IsStartGame = false;
    }

    void Start()
    { 
       //启动携程
        StartCoroutine(GetTime());
    }

    IEnumerator GetTime()
    {
        yield return new WaitForEndOfFrame();
        while (true)
        {
            yield return new WaitForSeconds(1);
            if (dataProxy != null && IsStartGame == true)
            { 
              //调用模型层方法
                dataProxy.AddGameTime();
            }
        }
    }
}
