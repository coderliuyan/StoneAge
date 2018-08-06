using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explore :UIBase {

    //public Goods goods;
    public void OnClickExplore()
    {
        Debug.Log("探索成功:获得"+"石头");
    }

    public void OnClickMake()
    {
        Debug.Log("制作成功:获得"+"木头");
    }

    // Use this for initialization
    void Start () {
        AddButtonListen("Explore_N", OnClickExplore);
        AddButtonListen("Make_N", OnClickMake);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
