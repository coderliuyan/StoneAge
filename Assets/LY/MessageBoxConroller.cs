using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageBoxConroller :UIBase{

	// Use this for initialization
	void Start () {
		AddButtonListen ("Cancel_N",CancelDropItem);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void CancelDropItem(){
		UIManager.Instance.MainCanvas.Find ("MessageBox_N").gameObject.SetActive(false);
	}
}
