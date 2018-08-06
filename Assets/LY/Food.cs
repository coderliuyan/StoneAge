using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : Item {

	public override void DragItem ()
	{
		base.DragItem ();

	}

	//初始化食材数据
	public override void Init ()
	{
		base.Init ();
		this.name_item = "food";
		#if UNITY_IOS || UNITY_IPHONE
		this.imagePath = Application.persistentDataPath + "Resource/Images/"+this.name_item;
		#endif

		#if UNITY_5 || UNITY_EDITOR
		this.imagePath = Application.dataPath + "Resource/Images/"+this.name_item;
		#endif
		this.foodStatus = FoodStatus.BaseFood;
		this.energyApply = 15;
		this.isCanEat = true;
	}


	public int energyApply; //回复精力值
	public bool isCanEat; //是否能直接吃
	public enum FoodStatus 
	{
		BaseFood,
		MidFood,
		AdvanceFood
	}
	public FoodStatus foodStatus;// 食材的状态等级


	//吃
	public virtual void EatFood(){
		switch (foodStatus){
		case(FoodStatus.BaseFood):
			{
				//使用低级食材
			}
			break;
		case(FoodStatus.MidFood):
			{
				//使用中级食材
			}
			break;
		case(FoodStatus.AdvanceFood):
			{
				//使用高级食材
			}
			break;
		}
	}

	// Use this for initialization
	void Start () {
		Init ();

		Dictionary<string,string> dict = new Dictionary<string,string> ();
		dict.Add ("name", "打哈哈");

		Common.IJson.WriteJsonToFile ("testJson",dict);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
