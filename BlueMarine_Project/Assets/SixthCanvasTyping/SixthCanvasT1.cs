using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class SixthCanvasT1 : MonoBehaviour
{
    // Start is called before the first frame update

    public Text tx1;
    private string m_text1 = "블루마린은 지구 환경을 살리자는 취지의 활동입니다." +
        "현재 다양한 블루마린 활동으로 지난 1년간 약 230톤의 플라스틱을 감축하였습니다." +
        "바다가 아파하고 지구가 고통스러워하고 있습니다." +
        "애터미의 블루마린 프로젝트로 여러분도 함께 이런 지구를 아끼고 보호해 주는 건 어떨까요?" +
        "시청해주셔서 감사합니다. ";
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
