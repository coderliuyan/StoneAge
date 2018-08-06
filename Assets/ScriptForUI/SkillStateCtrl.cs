using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillStateCtrl :UIBase {
    public void OnClickSkillState()
    {
        UIManager.Instance.MainCanvas.Find("SkillState_N").gameObject.SetActive(true);
    }
    public void OnClickSkillExit()
    {
        UIManager.Instance.MainCanvas.Find("Skills_N").gameObject.SetActive(false);
    }
    // Use this for initialization
    void Start () {
        AddButtonListen("Skill1_N", OnClickSkillState);
        AddButtonListen("Skill2_N", OnClickSkillState);
        AddButtonListen("Skill3_N", OnClickSkillState);
        AddButtonListen("Skill4_N", OnClickSkillState);
        AddButtonListen("Skill5_N", OnClickSkillState);
        AddButtonListen("Skill6_N", OnClickSkillState);
        AddButtonListen("Skill7_N", OnClickSkillState);
        AddButtonListen("Skill8_N", OnClickSkillState);
        AddButtonListen("Skill9_N", OnClickSkillState);
        AddButtonListen("Skill10_N", OnClickSkillState);
        AddButtonListen("Skill11_N", OnClickSkillState);
        AddButtonListen("Skill12_N", OnClickSkillState);
        AddButtonListen("Skill13_N", OnClickSkillState);
        AddButtonListen("Skill14_N", OnClickSkillState);
        AddButtonListen("Skill15_N", OnClickSkillState);
        AddButtonListen("Exit_N", OnClickSkillExit);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
