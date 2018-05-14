using UnityEngine;
using System.Collections;
using PureMVC.Patterns;

[RequireComponent(typeof(BoxCollider2D))]
public class Ctrl_Pipe : MonoBehaviour {



    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //通过PurMvc 通知机制 游戏结束
            Facade.Instance.SendNotification("Reg_EndGameCommand");
        }
    }


	void Start () {
	
	}
	
	
	void Update () {
	
	}
}
