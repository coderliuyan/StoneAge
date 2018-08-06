using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TechExitCtrl :UIBase{
    public void OnClickExit()
    {
        UIManager.Instance.MainCanvas.Find("Tech_N").gameObject.SetActive(false);
    }
    // Use this for initialization
    void Start()
    {
        AddButtonListen("Exit_N", OnClickExit);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
