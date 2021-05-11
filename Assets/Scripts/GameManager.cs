//--------------------------
// 주님, 감사합니다. 
// 이렇게 아이들이 말씀을 익힐수 있는 도구를 만들 생각을 주셔서 감사합니다. 
// 이것이 저의 자랑이나 제 마음 대로의 실현이 되지 않게 하시고, 
// 하나님 보시기에 선하것, 주님의 도구로 온전히 쓰이게 하여 주십시요.
// 그래서, 엘림이 이든이를 포함한 이 세대의 아이들이 
// 주님의 말씀을 기뻐하고 즐거워 하고 늘 가까이 하며 실천하며 살아내는 
// 귀한 세대가 되게 하여 주십시요. 
// 나의 주님 예수님의 이름으로 기도드립니다, 아멘. 
// 2021.04.21. 다일교회 청소년부 실.
// 
// 2021.05.07. 일단, 드래깅시 텍스트 나타나는 걸로 해서 순서대로 터치하면 끝나는 걸로 해보자. 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System; 
using TMPro; // 2021.04.26

public class GameManager : MonoBehaviour
{
    
    public TMP_Text tmpSp1;
    public TMP_Text tmpSp2;
    public TMP_Text tmpSp3;
    public TMP_Text tmpSp4;
    public TMP_Text tmpSp5;
    public TMP_Text tmpSp6;
    public TMP_Text tmpSp7;

    public GameObject b1, b2;

    // Start is called before the first frame update
    void Start()
    {
        // 시작할 때, 다음의 작업을들을 해야함. 
        /*
        . 사용자에 의해 선택된 해당 절의 텍스트를 로딩한다. (이 텍스트 구절은 semantic phrase 구분자로 구분되어 있다.)
        . SP 개수에 맞게 브릭을 instanciate 하고, 
        . 그 각 브릭에 (미리 리소스로 있는) 소리 파일을 각각 assign 한다. 
        . 그 각 브릭에 (미리 리소스로 있는) 텍스트 sp를 각각 assign 한다. 
        . 인스턴시에잇 하면서 검사한다. 텍스트가 브릭을 넘어가지 않는지. 아니면, TMP에 무슨 크게 별 맞게 만드는 에셋있나?
        . 그리고 나서 바닥에서 대기하고 있다가 로직을 타고 하나씩 상승한다. 

        */

        /*
        브릭에 추가할 컴포넌트. 
        . 2D box collider.
        . 
        */

        /*
        히브리서 4:16. 개역개정

        그러므로 우리는 긍휼하심을 받고 때를 따라 돕는 은혜를 얻기 위하여 
        은혜의 보좌 앞에 담대히 나아갈 것이니라. 

        RNKSV 새번역
        그러므로 우리는 담대하게 은혜의 보좌로 나아갑시다. 
        그리하여 우리가 자비를 받고 은혜를 입어서, 제때에 주시는 도움을 받도록 합시다.
        히브리서 4:16
        https://my.bible.com/bible/142/HEB.4.16

        NASB2020
        Therefore let’s approach the throne of grace with confidence, 
        so that we may receive mercy and find grace for help at the time of our need.

        Hebrews 4:16
        https://my.bible.com/bible/2692/HEB.4.16

        */
        tmpSp1.text = "그러므로 우리는";
        tmpSp2.text = "긍휼하심을 받고";
        tmpSp3.text = "때를 따라 돕는";
        tmpSp4.text = "은혜를 얻기 위하여";
        tmpSp5.text = "은혜의 보좌 앞에";
        tmpSp6.text = "담대히";
        tmpSp7.text = "나아갈 것이니라.";

        Invoke("testActive", 2.5f);

        Debug.Log("###(" +b1.transform.position.x + ", "+ b1.transform.position.y + ") "+ b1.GetComponent<RectTransform>().rect.width);

        
    }

    void testActive()
    {
        tmpSp1.enabled = false;
        tmpSp2.enabled = false;
        tmpSp3.enabled = false;
        tmpSp4.enabled = false;
        tmpSp5.enabled = false;
        tmpSp6.enabled = false;
        tmpSp7.enabled = false;

        Debug.Log("INVOKE!");
    }
    // Update is called once per frame
    void Update()
    {
        //instScrText.text = DateTime.Now.ToString(); // 2021.04.26

        // 크기를 재서, 브릭이 순서에 맞게 겹치면, 해당 텍스트 들을 계속 보이게 한다. 
        // 일단 맞기 시작하면 맞추기 진행 모드로 변경. state machine. 
        // 하다가 틀리면 idle 모드로 변경. 브릭들은 제자리로 흩어짐. 또는 랜덤하게 흩어짐. 
        // 다 맞으면 축하 이펙트. 
        
        //if()


        //# 종료 기능 처리. 
        // #if UNITY_ANDROID
        // #if UNITY_IOS
        if( Application.platform == RuntimePlatform.Android )
        {
            if( Input.GetKey(KeyCode.Home) )
            {
                Application.Quit();
            }else if( Input.GetKey(KeyCode.Escape) ) // Back button
            {

                Application.Quit();

            }else if( Input.GetKey(KeyCode.Menu) )
            {
                ;
            }

        }


    }
}
