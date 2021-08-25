using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class SixthCanvasT1 : MonoBehaviour
{
    // Start is called before the first frame update

    public Text tx1;
    private string m_text1 = "시청해주셔서 감사합니다. ";
    void Start()
    {
         StartCoroutine(typing());
    }

     IEnumerator typing()
    {

        for(int i = 0; i < m_text1.Length; i++)
        {
            tx1.text = m_text1.Substring(0,i);
            yield return new WaitForSeconds(0.15f);
        }
        
    }
}
