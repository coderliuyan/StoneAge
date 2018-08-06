using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Events;


public class UIBase : MonoBehaviour {


    void Awake()
    {
 
         
        Transform[]  allChildren=   transform.GetComponentsInChildren<Transform>();


        for (int i = 0; i < allChildren.Length; i++)
        {

            if (allChildren[i].name.EndsWith("_N"))
            {
 
                allChildren[i].gameObject.AddComponent<UIBehavriour>();
            }
            
        }

    }


    public GameObject GetWedagte(string widegateName)
    {

        return  UIManager.Instance.GetGameObject(transform.name,widegateName);
    }

    public UIBehavriour GetBehaviour(string widageName)
    {

        GameObject tmpObj = GetWedagte(widageName);


        if (tmpObj != null)
        {
           return    tmpObj.GetComponent<UIBehavriour>();
        }

        return null;
 

    }


    public void AddButtonListen( string  widageName , UnityAction action)
    {


        UIBehavriour tmpBehaviour = GetBehaviour(widageName);

        if (tmpBehaviour != null)
        {
            tmpBehaviour.AddButtonListen(action);
        }


    }



    public void ChangeTextContent(string widageName ,string  content)
    {


        UIBehavriour tmpBehaviour = GetBehaviour(widageName);

        if (tmpBehaviour != null)
        {
            tmpBehaviour.ChangeTextContent(content);
        }


    }




        

        // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
