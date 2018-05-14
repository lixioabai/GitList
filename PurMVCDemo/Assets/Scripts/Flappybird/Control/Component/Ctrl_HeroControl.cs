using UnityEngine;
using System.Collections;

/// <summary>
/// 控制层
/// 小鸟的控制脚本
/// </summary>
[RequireComponent(typeof(Rigidbody2D))]
public class Ctrl_HeroControl : MonoBehaviour {


	//升力
    public float floUpPower = 3f;
    //刚体
    private Rigidbody2D rd2D;
    //原始位置
    private Vector2 _VecHeroOriginalPosition;
    //是否开始游戏
    private bool _IsGameStart = false;

    /// <summary>
    /// 游戏开始
    /// </summary>
    public void StartGame()
    {
        _IsGameStart = true;
        rd2D.isKinematic = false;
    }

    /// <summary>
    /// 游戏结束
    /// </summary>
    public void StopGame()
    {
        _IsGameStart = false;
        this.gameObject.transform.position = _VecHeroOriginalPosition;
        DisableRigibody2D();
    }



	void Start () 
    {
	    //保存原始位置
        _VecHeroOriginalPosition = this.gameObject.transform.position;
       //获取2D刚体
        rd2D = this.GetComponent<Rigidbody2D>();
        //禁用刚体
        DisableRigibody2D();
       
	}
	
	
    /// <summary>
    /// 接收玩家的收入
    /// </summary>
	void Update () 
    {
        if (_IsGameStart)
        {
            if (Input.GetButton("Fire1"))
            {
                rd2D.velocity = Vector2.up * floUpPower;
            }
        }

	}


    private void DisableRigibody2D()
    {
        rd2D.isKinematic = true;
    }
}
