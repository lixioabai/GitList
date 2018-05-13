using UnityEngine;
using System.Collections;
using SUIFW;

public class GameStart : MonoBehaviour {

	// Use this for initialization
	void Start () {
        UIManager.GetInstance().ShowUIForms("StartUIForm");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
