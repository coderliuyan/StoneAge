using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextCtrl : UIBase
{
    //public void OnClick()
    //{
    //    UIManager.Instance.MainCanvas.Find("Main_N").gameObject.SetActive(true);
    //}
    //菜单切换
    public void OnClickMain()
    {
        Debug.Log(222);
        UIManager.Instance.MainCanvas.Find("Main_N").gameObject.SetActive(true);
        UIManager.Instance.MainCanvas.Find("Bag_N").gameObject.SetActive(true);
        UIManager.Instance.MainCanvas.Find("Player_N").gameObject.SetActive(false);
        UIManager.Instance.MainCanvas.Find("HomeMap_N").gameObject.SetActive(false);
        UIManager.Instance.MainCanvas.Find("BuildingInfo_N").gameObject.SetActive(false);
        UIManager.Instance.MainCanvas.Find("Buildings_N").gameObject.SetActive(false);
        UIManager.Instance.MainCanvas.Find("TechnologyTree_N").gameObject.SetActive(false);
        //GetWidget("Main_N").SetActive(false);
        //Debug.Log(".....");
    }
    public void OnClickPersonal()
    {
        UIManager.Instance.MainCanvas.Find("Main_N").gameObject.SetActive(false);
        UIManager.Instance.MainCanvas.Find("Bag_N").gameObject.SetActive(true);
        UIManager.Instance.MainCanvas.Find("Player_N").gameObject.SetActive(true);
        UIManager.Instance.MainCanvas.Find("HomeMap_N").gameObject.SetActive(false);
        UIManager.Instance.MainCanvas.Find("Buildings_N").gameObject.SetActive(false);
        UIManager.Instance.MainCanvas.Find("BuildingInfo_N").gameObject.SetActive(false);
        UIManager.Instance.MainCanvas.Find("TechnologyTree_N").gameObject.SetActive(false);
    }
    public void OnClickHome()
    {
        UIManager.Instance.MainCanvas.Find("Main_N").gameObject.SetActive(false);
        UIManager.Instance.MainCanvas.Find("Bag_N").gameObject.SetActive(false);
        UIManager.Instance.MainCanvas.Find("Player_N").gameObject.SetActive(false);
        UIManager.Instance.MainCanvas.Find("HomeMap_N").gameObject.SetActive(true);
        UIManager.Instance.MainCanvas.Find("Buildings_N").gameObject.SetActive(true);
        UIManager.Instance.MainCanvas.Find("BuildingInfo_N").gameObject.SetActive(true);
        UIManager.Instance.MainCanvas.Find("TechnologyTree_N").gameObject.SetActive(false);
    }
    public void OnClickTec()
    {
        UIManager.Instance.MainCanvas.Find("Main_N").gameObject.SetActive(false);
        UIManager.Instance.MainCanvas.Find("Bag_N").gameObject.SetActive(false);
        UIManager.Instance.MainCanvas.Find("Player_N").gameObject.SetActive(false);
        UIManager.Instance.MainCanvas.Find("HomeMap_N").gameObject.SetActive(false);
        UIManager.Instance.MainCanvas.Find("Buildings_N").gameObject.SetActive(false);
        UIManager.Instance.MainCanvas.Find("BuildingInfo_N").gameObject.SetActive(false);
        UIManager.Instance.MainCanvas.Find("TechnologyTree_N").gameObject.SetActive(true);
    }
    public void OnClickMenu()
    {

    }
    //制作探索
    public void OnClickExplore()
    {
        Debug.Log("探索成功:获得" + "石头");
    }

    public void OnClickMake()
    {
        Debug.Log("制作成功:获得" + "木头");
    }
    //背包切换
    //public void OnClickBA()
    //{
    //    UIManager.Instance.MainCanvas.Find("BasisMB_N").gameObject.SetActive(true);
    //    Debug.Log("基础材料");
    //}
    //public void OnClickSE()
    //{
    //    UIManager.Instance.MainCanvas.Find("SeniorMB_N").gameObject.SetActive(true);
    //    UIManager.Instance.MainCanvas.Find("BasisMB_N").gameObject.SetActive(false);
    //    Debug.Log("gaoji材料");
    //}
    // Use this for initialization
    void Start()
    {
        AddButtonListen("MainPage_N", OnClickMain);
        AddButtonListen("PersonalPage_N", OnClickPersonal);
        AddButtonListen("HomePage_N", OnClickHome);
        AddButtonListen("TechnologyPage_N", OnClickTec);
        AddButtonListen("Menu_N", OnClickMenu);

        AddButtonListen("Explore_N", OnClickExplore);
        AddButtonListen("Make_N", OnClickMake);

        //AddButtonListen("BasisM_N", OnClickBA);
        //AddButtonListen("SeniorM_N", OnClickSE);

		//test 测试读取 json
		string jsonName = "helloworld.json";
		LitJson.JsonData data =  Common.IJson.LoadJsonWithPath (jsonName);
		Debug.Log (data[0]["name"]);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
