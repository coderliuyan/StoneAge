using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateCtrl :UIBase {

    public void OnClickState()
    {
        UIManager.Instance.MainCanvas.Find("Skills_N").gameObject.SetActive(true);
    }
    



    // Use this for initialization
    void Start () {
        AddButtonListen("Details_N",OnClickState);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
