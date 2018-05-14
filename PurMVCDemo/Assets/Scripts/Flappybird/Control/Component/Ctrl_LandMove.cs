using UnityEngine;
using System.Collections;

/// <summary>
/// 控制层
/// 陆地移动
/// </summary>
public class Ctrl_LandMove : MonoBehaviour {

    public float floMoveSpeed = 1f;  //陆地移动速度

    private Vector2 _VecOriginalPosition; //陆地原始位置


	void Start () 
    {
	 //保存陆地原始位置
        _VecOriginalPosition = this.gameObject.transform.position;

        //


	}

    void Update()
    { 
       
       //陆地循环移动,到了一个临界值，恢复原始方位
        if (this.gameObject.transform.position.x<=-5f)
        {
            this.gameObject.transform.localPosition = _VecOriginalPosition;
        }

        //移动
        this.gameObject.transform.Translate(Vector2.left * Time.deltaTime * floMoveSpeed);
    }
	
	
	
}
