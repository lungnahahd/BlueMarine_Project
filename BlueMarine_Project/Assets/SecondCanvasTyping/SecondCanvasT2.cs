using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class SecondCanvasT2 : MonoBehaviour
{
    // Start is called before the first frame update

    public Text tx2;
    private string m_text2 = "거북이가 할얘기가 있나봐 거북이에 커서를 올려봐!! ";
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
