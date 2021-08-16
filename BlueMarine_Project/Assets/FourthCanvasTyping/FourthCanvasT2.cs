using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class FourthCanvasT2 : MonoBehaviour
{
    // Start is called before the first frame update

    public Text tx2;
    private string m_text2 = "상어가 할 얘기가 있나봐~~ 상어에 커서를 올려봥!! ";
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
