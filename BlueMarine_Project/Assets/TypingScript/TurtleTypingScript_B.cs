using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   

public class TurtleTypingScript_B : MonoBehaviour
{
    // Start is called before the first frame update

    public Text tx2;
    private string m_text2 = "안녕! 나는 거북이야~ 나는 주로 해파리나 오징어를 먹고 살아 근데 요즘 비닐봉지를 해파리나 오징어 인줄 알고 먹어서 배가 너무 아파 ㅠㅠ 제발 바다에 쓰레기를 버리지 말아줘... 나 말고도 아픈 동물이 또 있어 마린이가 소개해 줄꺼야 마린이한테 커서를 올려봐 ~~ ";
    
     void Start()
    {
         StartCoroutine(typing());
    }

     IEnumerator typing()
    {
       
        for(int i = 0; i < m_text2.Length; i++)
        {
            tx2.text = m_text2.Substring(0,i);
            yield return new WaitForSeconds(0.15f);
        }
        
    }
}
