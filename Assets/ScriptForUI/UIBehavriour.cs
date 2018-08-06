using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

using UnityEngine.Events;


public class UIBehavriour : MonoBehaviour {


    void Awake()
    {

        UIBase  tmpBase=  transform.GetComponentInParent<UIBase>();

        UIManager.Instance.RegistGameObject(tmpBase.name, transform.name, gameObject);
    }



    public void AddButtonListen(UnityAction  action)
    {

        Button tmpBtn = transform.GetComponent<Button>();

        if (tmpBtn != null)
        {

            tmpBtn.onClick.AddListener(action);
        }


    }

    public void AddSliderListen(UnityAction<float>  action)
    {

        Slider tmpBtn = transform.GetComponent<Slider>();

        if (tmpBtn != null)
        {

            tmpBtn.onValueChanged.AddListener(action);
        }
 
    }


    public void AddInputFiledEndEditorListen(UnityAction<string> action)
    {

        InputField tmpBtn = transform.GetComponent<InputField>();

        if (tmpBtn != null)
        {

            tmpBtn.onEndEdit.AddListener(action);
        }

    }

    public void AddInputFiledValueChangeListen(UnityAction<string> action)
    {

        InputField tmpBtn = transform.GetComponent<InputField>();

        if (tmpBtn != null)
        {

            tmpBtn.onValueChanged.AddListener(action);
        }

    }




    public void ChangeTextContent(string  content)
    {

        Text tmpBtn = transform.GetComponent<Text>();

        if (tmpBtn != null)
        {

            tmpBtn.text = content;
        }

    }



    public void ChangeImage(Sprite content)
    {

        Image tmpBtn = transform.GetComponent<Image>();

        if (tmpBtn != null)
        {

            tmpBtn.sprite  = content;
        }

    }








	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
