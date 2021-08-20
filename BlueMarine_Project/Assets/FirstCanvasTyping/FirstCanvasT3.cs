using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class FirstCanvasT3 : MonoBehaviour
{
    // Start is called before the first frame update

    public Text tx3;
    private string m_text3 = "물고기 세계의 친구들이 할얘기가 있데,,, 같이한번 들으러 갈까??";
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
