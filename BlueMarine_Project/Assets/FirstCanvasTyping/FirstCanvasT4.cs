using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class FirstCanvasT4 : MonoBehaviour
{
    // Start is called before the first frame update

    public Text tx4;
    private string m_text4 = "나한테 커서를 올리고 주변에 화살표를 찾아 커서를 올려봐~";

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
