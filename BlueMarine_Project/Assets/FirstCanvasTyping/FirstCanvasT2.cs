using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class FirstCanvasT2 : MonoBehaviour
{
    // Start is called before the first frame update

    public Text tx2;
    private string m_text2 = "나는물고기 세계의 가이드 마린이야 잘부탁해!";
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
