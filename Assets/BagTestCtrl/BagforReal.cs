using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class BagforReal : MonoBehaviour {

    public static BagforReal Instance;//单例脚本

    private Transform original;//交换方
    private Transform target;//被交换方

    private Transform tmp;//临时image

    private Image originalImage;
    private Image targetImage;
    private Image tmpImage;

    public Transform Original
    {
        set
        {
            original = value;
            originalImage = original.GetComponent<Image>();
        }
    }
    public Transform Target
    {
        set
        {
            target = value;
            if (target != null)
            {
                targetImage = target.GetComponent<Image>();
            }         
        }
    }

    void Start () {
        Instance = this;
        //获取临时显示的image
        tmp = transform.Find("Image");
        tmpImage = tmp.GetComponent<Image>();
	}

    /// <summary>
    /// 拖拽完成
    /// </summary>
    public void EndDrag()
    {
		
        //判断是否要交换
        if (target != null)
        {
			if (target.name == "Garbage_N") {
				Debug.Log("拖到垃圾桶！");
				tmp.gameObject.SetActive(false);
				//message  box show here!!!
				Transform messagebox = UIManager.Instance.MainCanvas.Find ("MessageBox_N");
				UIManager.Instance.MainCanvas.Find ("MessageBox_N").gameObject.SetActive(true);
				messagebox.transform.localScale = new Vector3(0.43f,0.43f,1f);
				messagebox.transform.DOScale (Vector3.one,0.33f).SetEase(Ease.Linear);
				originalImage.color = new Color(1, 1, 1, 1);
				return ;
			}

            //需要交换
			if(targetImage.sprite != null){
				originalImage.sprite = targetImage.sprite;
			}
            targetImage.sprite = tmpImage.sprite;
			tmp.gameObject.SetActive(false);
			return;
        }

        //不需要交换
		tmp.gameObject.SetActive(false);
		BagItemforReal bir = original.GetComponent<BagItemforReal>();
		bir.number++;
		bir.ChangeChildText ();
        originalImage.color = new Color(1, 1, 1, 1);
    }
    /// <summary>
    /// 开始拖拽
    /// </summary>
    public void BeginDrag()
    {

        //1.将拖拽物体的图片显示到临时拖拽图片上
        tmpImage.sprite = originalImage.sprite;
        //2.将拖拽物体图片隐藏
		BagItemforReal bir = original.GetComponent<BagItemforReal>();
		if (bir.number < 1)
			return;
		if (bir.number == 1) {
			originalImage.color = new Color (1, 1, 1, 0);
		} 
		bir.number--;
		bir.ChangeChildText ();
			
        //3.将临时拖拽图片的位置调整为拖拽图片的位置
        tmp.position = original.position;
        //4.降临时显示的图片显示出来
        tmp.gameObject.SetActive(true);
    }
    /// <summary>
    /// 拖拽过程
    /// </summary>
    /// <param name="position"></param>
    public void OnDrag(Vector2 position)
    {
        //修改临时图片的位置为鼠标位置
        tmp.position = position;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
