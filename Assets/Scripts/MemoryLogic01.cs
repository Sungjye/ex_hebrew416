using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

using TMPro; 

public class MemoryLogic01 : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    public int cnt1, cnt2, cnt3;
    // Start is called before the first frame update

    public static Vector2 defaultposition; // 원래 위치로 보내기 위한 변수.

    //public TMP_Text instScrText;
    public TMP_Text instSematicPhrase;


    // Start is called before the first frame update
    void Start()
    {
        cnt1 = cnt2 = cnt3 = 0;

        instSematicPhrase.enabled = false;


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData) // 드래그 시작할 떄
    {


        defaultposition = this.transform.position;

        //instSematicPhrase.enabled = true;

    }

    void IDragHandler.OnDrag(PointerEventData eventData)  // 드래그 중일 때
    {


        Vector2 currentPos = Input.mousePosition;
        //Vector2 currentPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        this.transform.position = currentPos;


        instSematicPhrase.enabled = true;

        Debug.Log("(" +this.transform.position.x + ", "+ this.transform.position.y + ") "+ GetComponent<RectTransform>().rect.width);
    }

    //public void OnDrag(PointerEventData eventData)
    void IEndDragHandler.OnEndDrag(PointerEventData eventData) // When the dragging is ended.
    {
                
        //this.transform.position = defaultposition;

        instSematicPhrase.enabled = false;
    }


}
