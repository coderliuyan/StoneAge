using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BagItemforReal : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler,IPointerEnterHandler,IPointerExitHandler
{
	[HideInInspector]
	public int number  = 3;

	private Text numberT;
	void Awake(){
		numberT = GetComponentInChildren<Text> ();
//		ChangeChildText ();
	}

	public void ChangeChildText(){
		if (number > 1)
			numberT.text = number + "";
		else
			numberT.text = "";
	}

    public void OnBeginDrag(PointerEventData eventData)
    {
        BagforReal.Instance.Original = transform;
        BagforReal.Instance.BeginDrag();
    }

    public void OnDrag(PointerEventData eventData)
    {
        BagforReal.Instance.OnDrag(eventData.position);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        BagforReal.Instance.EndDrag();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        BagforReal.Instance.Target = transform;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        BagforReal.Instance.Target = null;
    }
}
