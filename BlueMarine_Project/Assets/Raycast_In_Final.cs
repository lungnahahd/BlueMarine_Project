using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class Raycast_In_Final : MonoBehaviour
{
    public GameObject cam;
    public Image pointer;
    float timeElapsed;

    public GameObject videoOne;
    public GameObject videoTwo;
    public GameObject pictureThree;
    public GameObject MainFish;
    public GameObject Player;
 

    int count = 0;

    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        raticle();
    }

    void raticle()
    {
        RaycastHit hit;
        Vector3 forward = cam.transform.TransformDirection(Vector3.forward * 100);
        if (Physics.Raycast(cam.transform.position, forward, out hit))
        {
            if (hit.transform.tag == "MainFish")
            {
                
                pointer.fillAmount = timeElapsed / 2;
                timeElapsed = timeElapsed + Time.deltaTime;

                if (timeElapsed >= 2)
                {
                    if(count == 0)
                    {
                        videoOne.SetActive(true);
                        //MainFish.transform.GetComponent<BoxCollider>().enabled = false;
                        MainFish.transform.GetComponent<Animator>().SetBool("mainFish", true);
                        Player.transform.GetComponent<Animator>().SetBool("Player", true);
                        count++;
                    }
                    else if(count == 1)
                    {
                        videoOne.SetActive(true);
                        count++;
                    }
                    else if(count == 2)
                    {
                        videoOne.SetActive(false);
                        videoTwo.SetActive(true);
                        count++;
                    }
                    else if(count == 3)
                    {
                        videoTwo.SetActive(false);
                        pictureThree.SetActive(true);
                    }

                    // 추후에 확인 버튼을 누르고, 넘어가도록 처리하게 하면 이후에 수정할 부분 -> Delay 신경 쓰지 말기!!!
                    Thread.Sleep(500);
                    
                }
            }

        }
        else
        {
            timeElapsed = 0;
            pointer.fillAmount = 0;
        }
        Debug.DrawRay(cam.transform.position, forward, Color.red);
    }

    

    


    

    
}
