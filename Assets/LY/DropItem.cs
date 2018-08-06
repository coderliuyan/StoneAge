using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class DropItem : MonoBehaviour,IPointerEnterHandler {

	public void  OnPointerEnter (PointerEventData eventData)
	{
		BagforReal.Instance.Target = transform;
	}
}
