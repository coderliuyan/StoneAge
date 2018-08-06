using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPropertyAttribute : PropertyAttribute
{
	public string Name { get; private set; }
	public bool IsDirty { get; set; }

	public SetPropertyAttribute(string name)
	{
		this.Name = name;
	}
}

public class Player : Singleton<Player> {

	//id
	public	string p_id;

	//图片路径
	public string p_imagePath;

	//名字
	public string p_nickname;

	//描述
	public string p_description;

	[SerializeField,SetPropertyAttribute("hp")]
	private int _energy;
	public int energy{
		set{
			_energy = value;
			if (_energy > 100)
				_energy = 100;
		}
		get{ 
			if (_energy < 0)
				_energy = 0;
			return _energy;
		}
	}  

	public int conenergy_rate;




	//战斗力
	[SerializeField,SetPropertyAttribute("power")]
	private int _power;
	public int power{
		set{ _power = value;}
		get{ return _power;}
	}

	// 采集相关

	//采集等级
	private int _collect_level;
	public int collect_level{set{ _collect_level = value;} get{ return _collect_level;}}

	// 狩猎等级
	private int _hunting_level;
	public int hunting_level{set{ _hunting_level = value;}get{ return _hunting_level;}}


	// 伐木等级
	private int _logging_level;
	public int logging_level{set{ _logging_level = value;}get{ return _logging_level;}}

	// 挖矿等级
	private int _dig_level;
	public int dig_level{set{ _dig_level = value;}get{ return _dig_level;}}

	// 钓鱼等级
	private int _fish_level;
	public int fish_level{set{ _fish_level = value;}get{ return _fish_level;}}


	//制造相关

	//制陶等级
	private int _mk_china_lv;
	public int mk_china_lv{set{ _mk_china_lv = value;}get{ return _mk_china_lv;}}

	//建造等级
	private int _mk_build_lv;
	public int mk_build_lv{set{ _mk_build_lv = value;}get{ return _mk_build_lv;}}

	//建造等级
	private int _mk_weapon_lv;
	public int mk_weapon_lv{set{ _mk_weapon_lv = value;}get{ return _mk_weapon_lv;}}



	// 装备
	public int p_head_id;
	public Equip p_head;

	public int p_body_id;
	public Equip p_body;

	public int p_foot_id;
	public Equip p_foot;

	public int p_trousers_id;
	public Equip p_trousers;


	//背包
	//探索背包
	public List<Goods> devloper_bag = new List<Goods>();

	//补给背包
	public List<Goods> supply_bag = new List<Goods>();


	//加成道具 4种


}
