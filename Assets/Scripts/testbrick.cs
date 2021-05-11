/*
  브릭을 터치하면 소리가 나고, 그 브릭을 터치로 드래그 해서 위치를 옮길수 있게 하는 스크립트. 연습 1. 

[Ref.]
2021.04.30. 어떤 레퍼를 갖다 써야될지 모르겠다. 
https://202psj.tistory.com/1287


[소리 예시]
 틀린 위치에 갖다 놓았을 때: 다시 생각해봐~ (변조)

*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System; 
using TMPro; // 2021.04.26


//#####
//using UnityEngine.EventSystems;

public class testbrick : MonoBehaviour
{
    // Start is called before the first frame update


    // 오디오 소스 여러개 사용하기 위해.
    private AudioSource brickSpeaker;
    public AudioClip okSnd, nopSnd;

    public BoxCollider2D boxCollider2D;
    //private Rigidbody rb;

     public TMP_Text instScrText; //2021.04.26 

    Vector2 FirstPoint, SecondPoint;
    bool isMouseDown = false;



    void Start()
    {
        boxCollider2D = GetComponent<BoxCollider2D>();

        this.brickSpeaker = this.gameObject.AddComponent<AudioSource>();
        this.brickSpeaker.clip = this.okSnd;
        this.brickSpeaker.loop = false;

        //brickSpeaker.Play();

        Debug.Log(boxCollider2D.size.x);


        //StartCoroutine(OnMouseDrag());

        //StartCoroutine(TestCo());

        Invoke("ObjMoveTest", 1f);

    }

    void ObjMoveTest()
    {
        Vector2 oldPosition = this.transform.position;
        Vector2 newPosition = new Vector2(oldPosition.x+1f, oldPosition.y+1f);
        this.transform.position = newPosition;

    }
/*
    IEnumerator TestCo()
    {
        Debug.Log("!!!");

        //yield return null;
        yield return new WaitForFixedUpdate();
    }

    // 왜 안불림? 콜라이더도 추가되어 있는데.. 
    // https://codingmania.tistory.com/173
    IEnumerator OnMouseDrag() 
    {
        Debug.Log("Mouse Event!");

        while( Input.GetMouseButton(0) )
        {
            Debug.Log("DRAG!!");
            yield return null;
        }
    }
*/




 // 터치 하는 곳으로 무조건 브릭이 옮겨지는 기능.
    // Update is called once per frame
    void Update()
    {

        float mvx, mvz;

        string strTime = DateTime.Now.ToString(); // 2021.04.26
        strTime = strTime + "\n" + boxCollider2D.offset.x + ": " + (boxCollider2D.offset.x+boxCollider2D.size.x);


#if UNITY_EDITOR
        // https://202psj.tistory.com/1287

        // 마우스 눌림.
        if( Input.GetMouseButtonDown(0) )
        {
            FirstPoint = Input.mousePosition;

            isMouseDown = true;
        }

        // 마우스 떼짐.
        if( Input.GetMouseButtonUp(0) )
        {
            isMouseDown = false;
        }

        // 드래그 중임을 나타냄. 
        if( isMouseDown == true )
        {
            SecondPoint = Input.mousePosition;

            //float 
            Debug.Log( "CUSTOM: "+FirstPoint + "; " + SecondPoint + "; "  );

            // 오브젝트 이동하기. 
            Vector2 mouseDragPos = new Vector2( Input.mousePosition.x, Input.mousePosition.y );
            Vector2 worldObjPos = Camera.main.ScreenToWorldPoint(mouseDragPos);

            this.transform.position = worldObjPos;

        }


        mvx = Input.GetAxis("Horizontal");
        mvz = Input.GetAxis("Vertical");

        strTime = strTime + "\nTouch input is not valid.";

//#elif UNITY_ANDROID || UNITY_IOS
#elif UNITY_ANDROID || UNITY_IPHONE

/*
        // 모바일 기기(안드로이드) 동작용. For a controling in the mobile devices.
        Touch touch = Input.GetTouch(0);

        //mvx = touch.deltaPosition.x * Time.deltaTime * 1f;
        //mvz = touch.deltaPosition.y * Time.deltaTime * 1f; // touch.. y...
        mvx = touch.deltaPosition.x;
        mvz = touch.deltaPosition.y; // touch.. y...

        strTime = strTime + "\n x: " + mvx;
        strTime = strTime + "\n y: " + mvz;
*/

       if( Input.touchCount > 0 )
       {
           if( Input.GetTouch(0).phase == TouchPhase.Began )
           {
               FirstPoint = Input.GetTouch(0).position;
           }

           if( Input.GetTouch(0).phase == TouchPhase.Moved )
           {
                SecondPoint = Input.GetTouch(0).position;

                Vector2 touchDragPos = new Vector2( SecondPoint.x, SecondPoint.y );
                Vector2 worldObjPos = Camera.main.ScreenToWorldPoint(touchDragPos);

                this.transform.position = worldObjPos;

                strTime = strTime + "\n x: " + worldObjPos.x;
                strTime = strTime + "\n y: " + worldObjPos.y;
           }
       }



#else // WINDOWS? WEBGL?
        mvx = Input.GetAxis("Horizontal");
        mvz = Input.GetAxis("Vertical");

        strTime = strTime + "\nTouch input is not valid.";
#endif

    /*
    Debug.Log(mvx + " "+ mvz);

    //strTime = strTime + "\n" + "test";
    

    if( (mvx > boxCollider2D.offset.x) && (mvx < (boxCollider2D.offset.x+boxCollider2D.size.x) ) )
    {
        brickSpeaker.Play();

        strTime = strTime + "\n [IN!!] ";

    }
    */
    instScrText.text = strTime;

    }


}
