using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class FirstCanvasT3 : MonoBehaviour
{
    // Start is called before the first frame update

    public Text tx3;
    private string m_text3 = "앞으로 모험을 떠나볼껀데 나를 잘 따라와!!";
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
