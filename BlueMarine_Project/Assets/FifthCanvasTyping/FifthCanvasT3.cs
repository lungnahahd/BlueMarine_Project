using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class FifthCanvasT3 : MonoBehaviour
{
    // Start is called before the first frame update

    public Text tx3;
    private string m_text3 = "물고기세계 동물들이 사람때문에 아파해 그런데 물고기세계 동물들이 계속 아파하면 아프게 만든 사람도 결국 아파지게 된다는 사실이야!";

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
