using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

using TMPro; // 2021.04.26
using System;

// 이 레퍼런스에 따른 터치 이동 테스트: DragHandler 를 사용하는 방법.
// https://greenteacat.tistory.com/35

// https://docs.unity3d.com/kr/2019.3/ScriptReference/EventSystems.IPointerEnterHandler.html

//public class MovingByTouch01 : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler, IPointerEnterHandler, IPointerExitHandler
public class MovingByTouch01 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public static Vector2 defaultposition;

    public TMP_Text instScrText; //2021.04.26 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Detect if the Cursor starts to pass over the GameObject
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        //Output to console the GameObject's name and the following message
        Debug.Log("Cursor Entering " + name + " GameObject");

        string strTime = DateTime.Now.ToString(); // 2021.04.26

        strTime = strTime + "\n" + "Cursor Entering " + name + " GameObject";

        instScrText.text = strTime;
    }

    //Detect when Cursor leaves the GameObject
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        //Output the following message with the GameObject's name
        Debug.Log("Cursor Exiting " + name + " GameObject");

        string strTime = DateTime.Now.ToString(); // 2021.04.26

        strTime = strTime + "\n" + "Cursor Exiting! " + name + " GameObject";

        instScrText.text = strTime;
    }
/*
    //public void OnBeginDrag(PointerEventData eventData)
    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData) // 드래그 시작할 떄
    {

        Debug.Log("Start!");

        //defaultposition = this.transform.position;
        // throw new System.NotImplementedException();
    }

    //public void OnEndDrag(PointerEventData eventData)
    void IEndDragHandler.OnEndDrag(PointerEventData eventData) // 드래그 중일 때
    {
        Debug.Log("Ing!");

        //Vector2 currentPos = Input.mousePosition;
        Vector2 currentPos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        this.transform.position = currentPos;
        //throw new System.NotImplementedException();
    }

    //public void OnDrag(PointerEventData eventData)
    void IDragHandler.OnDrag(PointerEventData eventData) // When the dragging is ended.
    {
        Debug.Log("End!");

        Vector2 mousePos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        this.transform.position = defaultposition;
        //throw new System.NotImplementedException();
    }
 */


}