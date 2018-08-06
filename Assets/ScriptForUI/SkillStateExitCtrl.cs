using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillStateExitCtrl :UIBase {

    public void OnClickSkillStateExit()
    {
        UIManager.Instance.MainCanvas.Find("SkillState_N").gameObject.SetActive(false);
    }
    // Use this for initialization
    void Start () {
        AddButtonListen("Exitss_N", OnClickSkillStateExit);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
