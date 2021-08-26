using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class FifthCanvasT3 : MonoBehaviour
{
    // Start is called before the first frame update

    public Text tx3;
    private string m_text3 = "너는 잘 몰랐구나...물고기세계 동물들이 사람 때문에 아파해.. 그러면서 바다는 점점 병들어가고, 바다를 아프게 만든 사람도 결국 아파지게 될거야... 이 사실을 알았으면 좋겠어!! ";

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
