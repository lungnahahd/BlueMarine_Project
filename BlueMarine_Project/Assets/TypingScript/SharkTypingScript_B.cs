using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SharkTypingScript_B : MonoBehaviour
{
    // Start is called before the first frame update
    public Text tx4;
    private string m_text4 = "안녕!! 나는 바다 최강 포식자 상어야~ 근데 요즘 고민이 생겼어 피부병이 걸렸는 지 피부가 이상해 ㅠㅠ 무분별한 바다 쓰레기로 인해 수온이 상승하고 다양한 바이러스가 생겨나서 그런거 같아 ㅠㅠ 너무 간지러워... 마린이가 마지막 친구를 소개시켜 줄꺼야 마린이한테 커서를 올려봐~ ";
    void Start()
    {
         StartCoroutine(typing());
    }

    IEnumerator typing()
    {
       
        for(int i = 0; i < m_text4.Length; i++)
        {
            tx4.text = m_text4.Substring(0,i);
            yield return new WaitForSeconds(0.15f);
        }
        
    }
}
