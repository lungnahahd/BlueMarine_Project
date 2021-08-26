using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class DolphinTypingScript_B : MonoBehaviour
{
    // Start is called before the first frame update

    public Text tx3;
    private string m_text3 = "안녕 나는 돌고래야!! 나는 물에 살지만 포유류라서 폐호흡을 해~ 근데 저번에 그물에 꼬리가 걸려서 죽을 뻔 했어.. 사람들이 무심코 버린 폐그물에 우리 돌고래들이 죽을 수 있다는 걸 알아줘.. 마린이가 다른 친구를 소개 시켜 줄 꺼야 마린이한테 커서를 올려봐 ~~ ";

    void Start()
    {
         StartCoroutine(typing());
    }

     IEnumerator typing()
    {

        for(int i = 0; i < m_text3.Length; i++)
        {
            tx3.text = m_text3.Substring(0,i);
            yield return new WaitForSeconds(0.15f);
        }
        
    }
}
