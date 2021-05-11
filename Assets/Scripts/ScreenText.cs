using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System; 
using TMPro;

public class ScreenText : MonoBehaviour
{
    //public TMP_Text scrText;

    //public GameObject textObjC_Prefeb;

    public TMP_Text instScrText;


    // Start is called before the first frame update
    void Start()
    {
        // 2021.04.26. 오예.. 기억이 없으니 열심히 10분 뒤져서.. 찾았다. 
        // ExerUnity 프로젝트에, GenWords.cs.
        /*
        // 게임 오브젝트로 먼저 가져와서,
        GameObject textObject = Instantiate( textObjC_Prefeb, vPos, Quaternion.identity);
        // 텍메프 컴포넌트를 가져와서, 단어/구 넣어주고,
            TMP_Text instTMP = textObject.GetComponent<TextMeshPro>();
            instTMP.text = word;

            // 이참에 (단어구분이 같은색이면 잘 안되니..) 랜덤색으로 넣어주기?
            // <https://www.youtube.com/watch?v=Pli7n-JKc7w>, <https://m.blog.naver.com/PostView.nhn?blogId=bililic&logNo=220548639497&proxyReferer=https:%2F%2Fwww.google.com%2F>
            instTMP.color = new Color(UnityEngine.Random.Range(0.0f, 1.0f), 
                                        UnityEngine.Random.Range(0.0f, 1.0f),
                                        UnityEngine.Random.Range(0.0f, 1.0f), 
                                        1f); //Color.cyan;

        */


        //instScrText = GetComponent<TextMeshPro>();
        //instScrText = this.GetComponent<TextMeshPro>();


    }

    // Update is called once per frame
    void Update()
    {
        instScrText.text = DateTime.Now.ToString();

    }
}
