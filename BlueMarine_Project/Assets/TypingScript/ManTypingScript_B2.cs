using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  

public class ManTypingScript_B2 : MonoBehaviour
{
    // Start is called before the first frame update
    public Text tx2;
    private string m_text2 = "미안해 다 우리잘못이야... 플라스틱 사용도 줄이고 바다에 쓰레기를 함부로 버리지 않을게!! ";

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
