using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemStatus : MonoBehaviour {

#if false
    private Dictionary<int, ItemStatus> m_ItemList; //背包中的Item
    private List<ItemStatus> m_PartItemList; //背包分页中的Item

    private enum TabType
    {
        All,
        Equip,
        Potion,
        Other
    }
    private TabType m_TabType = TabType.All;

    /// <summary>
    /// 向分页添加物品
    /// </summary>
    private void AddItemToPartGrid(List<ItemStatus> itemList)
    {
        //初始化分页格子数量为PartItemList的数量
        InitGrid(this.m_PnlPartGrid, itemList.Count, this.m_PartGridList);
        for (int i = 0; i < itemList.Count; i++)
        {
            GameObject go = GameObject.Instantiate(this.m_ItemPrefab);
            go.transform.SetParent(this.m_PartGridList[i]);
            go.GetComponent<UIItem>().SetInfo(itemList[i]);
            go.transform.localPosition = Vector3.zero;
            go.transform.localScale = Vector3.one;
            go.GetComponent<UIItem>().PointerClick += OnUIItemPointerClick;
        }
    }

    /// <summary>
    /// 刷新分页
    /// </summary>
    private void RefreshPartGrid()
    {
        switch (this.m_TabType)
        {
            case TabType.Equip:
                this.m_PartItemList = m_ItemList
                   .Select(i => i.Value).Cast<ItemStatus>()
                   .Where(d =>
                       d.WhereType == WhereType.Knapsack
                       && (d.ItemType == ItemType.Weapon
                       || d.ItemType == ItemType.Armor
                       || d.ItemType == ItemType.Ring
                       || d.ItemType == ItemType.Necklace)
                       ).ToList();
                break;
            case TabType.Potion:
                m_PartItemList = m_ItemList
                    .Select(i => i.Value).Cast<ItemStatus>()
                    .Where(d =>
                        d.WhereType == WhereType.Knapsack
                        && d.ItemType == ItemType.Potion
                        ).ToList();
                break;
            case TabType.Other:
                m_PartItemList = m_ItemList
                    .Select(i => i.Value).Cast<ItemStatus>()
                    .Where(d =>
                        d.WhereType == WhereType.Knapsack
                        && d.ItemType == ItemType.Other
                        ).ToList();
                break;
        }
        if (this.m_PartItemList != null)
            AddItemToPartGrid(this.m_PartItemList);

        UpdateCount();
    }

    private void UpdateCount()
    {
        string countStr;
        if (this.m_TabType == TabType.All)
        {
            countStr = string.Format("{0} / {1}", this.m_ItemList.Count, gridCount);
        }
        else
        {
            countStr = string.Format("{0} / {1}", this.m_PartItemList.Count, gridCount);
        }

        this.m_txtCount.text = countStr;
    }

    public void AddItem(UserItemEntity item)
    {
        Transform grid = GetEnmptyGrid();
        if (grid == null) //背包已满
            return;
        if (!m_ItemEntityList.ContainsKey(item.ID))
            return;

        GameObject go = GameObject.Instantiate(this.m_ItemPrefab);
        go.transform.SetParent(grid);
        ItemStatus itemStatus = go.GetComponent<UIItem>().SetInfo(item);
        go.transform.localPosition = Vector3.zero;
        go.transform.localScale = Vector3.one;
        go.GetComponent<UIItem>().PointerClick += OnUIItemPointerClick;

        if (m_ItemList.ContainsKey(itemStatus.ItemID))
        {
            m_ItemList[itemStatus.ItemID] = itemStatus;
        }
        else
        {
            m_ItemList.Add(itemStatus.ItemID, itemStatus);
        }

        RefreshPartGrid();
    }

    public void RemoveItem(ItemStatus itemStatus)
    {
        itemStatus.Count -= 1;

        if (itemStatus.Count == 0)
        {//销毁物品
            this.m_ItemList.Remove(itemStatus.ItemID);
            DestroyImmediate(itemStatus.gameObject);
        }
        else
        {//更新数量显示
            itemStatus.gameObject.GetComponent<UIItem>().UpdateCount();
        }

        RefreshPartGrid();
    }
    private void BtnRestorePointerClick(PointerEventData obj)
    {
        InitGrid(this.m_PnlGrid, gridCount, m_GridList);
        LoadData();
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
#endif
}
