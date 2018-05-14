using UnityEngine;
using System.Collections;

/// <summary>
/// 管道移动
/// 控制层
/// </summary>
public class Ctrl_PipMove : MonoBehaviour {

    public float floMoveSpeed = 1f;  //陆地移动速度

    private Vector2 _VecOriginalPosition; //陆地原始位置

    private bool _IsStartGame = false; //是否开始游戏 

    void Start()
    {
        //保存陆地原始位置
        _VecOriginalPosition = this.gameObject.transform.position;

       


    }


    //游戏开始
    public void StartGame()
    {
        _IsStartGame = true;
    }
    //游戏结束
    public void EndGame()
    {
        _IsStartGame = false;
        //管道复位
        ReSetPipPosition();
    }


    void Update()
    {
        if (_IsStartGame)
        {
            //陆地循环移动,到了一个临界值，恢复原始方位
            if (this.gameObject.transform.position.x <= -15f)
            {
                this.gameObject.transform.localPosition = _VecOriginalPosition;
            }

            //移动
            this.gameObject.transform.Translate(Vector2.left * Time.deltaTime * floMoveSpeed);
        }
    }

    private void ReSetPipPosition()
    {
        this.gameObject.transform.position = _VecOriginalPosition;
    }
}
