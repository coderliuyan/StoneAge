using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TechCtrl :UIBase {
    public void OnClickB1()
    {
        UIManager.Instance.MainCanvas.Find("Tech_N").gameObject.SetActive(true);
    }
    // Use this for initialization
    void Start () {
        AddButtonListen("TechB1_N", OnClickB1);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
