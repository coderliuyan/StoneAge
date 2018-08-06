using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {


    public static UIManager Instance;

    private Transform Canvas_Main;
    public Transform MainCanvas
    {
        get
        {
            return Canvas_Main;
        }
    }

    /// <summary>
    ///   1 string 表示 panel     2 string  表示控件的名字
    /// </summary>
    Dictionary<string, Dictionary<string, GameObject>> allWedgate;


    public void RegistGameObject(string  panleName ,string wedageName,GameObject obj)
    {

        if (!allWedgate.ContainsKey(panleName))
        {

            allWedgate[panleName] = new Dictionary<string, GameObject>();
        }


        allWedgate[panleName].Add(wedageName,obj);
 
           

    }

    /// <summary>
    ///   获取  某一个 panle 下面的 子控件 
    /// </summary>
    /// <param name="panelName"></param>
    /// <param name="wedegateName"></param>
    /// <returns></returns>
    public GameObject GetGameObject(string panelName ,string  wedegateName)
    {


        if (allWedgate.ContainsKey(panelName))
        {
              return  allWedgate[panelName][wedegateName];
        }

        return null;
    }

    void Awake()
    {

        Instance = this;

        allWedgate = new Dictionary<string, Dictionary<string, GameObject>>();

        Canvas_Main = GameObject.FindGameObjectWithTag("MainCanvas").transform;
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
