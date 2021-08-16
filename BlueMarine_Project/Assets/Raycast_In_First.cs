using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Raycast_In_First : MonoBehaviour
{
    public GameObject cam;
    public Image pointer;
    float timeElapsed;

    public GameObject TV;
    public GameObject Player;


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
            if (hit.transform.tag == "TV")
            {

                pointer.fillAmount = timeElapsed / 2;
                timeElapsed = timeElapsed + Time.deltaTime;

                if (timeElapsed >= 2)
                {
                    StartCoroutine(ShowTV());
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
    IEnumerator ShowTV()
    {
        Player. transform.GetComponent<Animator>().SetBool("SeeTV", true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Demo Scene");
        
    }
}

