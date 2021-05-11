// 레퍼도 급하게 하면 틀린다. 
// https://greenteacat.tistory.com/35


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

using TMPro; 
using System;

public class MovingByTouch02 : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    public int cnt1, cnt2, cnt3;
    // Start is called before the first frame update

    public static Vector2 defaultposition; // 원래 위치로 보내기 위한 변수.

    public TMP_Text instScrText;
    
    void Start()
    {
        cnt1 = cnt2 = cnt3 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData) // 드래그 시작할 떄
    {

        ++cnt1;
        Debug.Log("Start!: " + cnt1);

        defaultposition = this.transform.position;
        // throw new System.NotImplementedException();

        string strTime = DateTime.Now.ToString();
        strTime = strTime + "\n" + "Begin Drag! " + name + ", Cnt: " + cnt1;
        instScrText.text = strTime;
    }

    void IDragHandler.OnDrag(PointerEventData eventData)  // 드래그 중일 때
    {
        ++cnt2;
        Debug.Log("Ing!: " + cnt2);

        Vector2 currentPos = Input.mousePosition;
        //Vector2 currentPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        this.transform.position = currentPos;

        //throw new System.NotImplementedException();

        string strTime = DateTime.Now.ToString();
        strTime = strTime + "\n" + "On Drag! " + name + ", Cnt: " + cnt2;
        strTime = strTime + "\n" + "( " + currentPos.x +", " + currentPos.y +")";
        instScrText.text = strTime;
    }

    //public void OnDrag(PointerEventData eventData)
    void IEndDragHandler.OnEndDrag(PointerEventData eventData) // When the dragging is ended.
    {
        ++cnt3;
        Debug.Log("End!: " + cnt3);

                
        this.transform.position = defaultposition;

        /*
        Vector2 mousePos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        this.transform.position = defaultposition;
        */
        //throw new System.NotImplementedException();

        string strTime = DateTime.Now.ToString();
        strTime = strTime + "\n" + "End Drag! " + name + ", Cnt: " + cnt3;
        instScrText.text = strTime;
    }


}
