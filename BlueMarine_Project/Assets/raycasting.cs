using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class raycasting : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject cam;
    public Image pointer;
    float timeElapsed;

    public Transform whalePos;
    public GameObject Whale;
    public GameObject WhaleText;

    public Transform TurtlePos;
    public GameObject Turtle;
    public GameObject TurtleText;

    public Transform DolphinPos;
    public GameObject Dolphin;
    public GameObject DolphinText;

    public Transform SharkPos;
    public GameObject Shark;
    public GameObject SharkText;

    public Transform MainFishPos;
    public GameObject MainFish;

    public GameObject turtleArrowPointer1;
    public GameObject turtleArrowPointer2;

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
        Vector3 forward = cam.transform.TransformDirection(Vector3.forward*100);

        if(Physics.Raycast(cam.transform.position,forward,out hit)){
            if(hit.transform.tag == "Whale"){
                pointer.fillAmount = timeElapsed / 3;
                timeElapsed = timeElapsed + Time.deltaTime;

                if(timeElapsed >= 3){

                    StartCoroutine(moveWhale());
                    WhaleText.SetActive(true);
                    Whale.SetActive(false);
                    Debug.Log("Whale hit");

                }
            }else if(hit.transform.tag == "Turtle"){
                pointer.fillAmount = timeElapsed / 3;
                timeElapsed = timeElapsed + Time.deltaTime;

                if(timeElapsed >= 3){
        
                    StartCoroutine(moveTurtle());
                    TurtleText.SetActive(true);
                    Turtle.SetActive(false);
                    Debug.Log("Turtle hit");
                }

            }else if(hit.transform.tag == "Dolphin"){
                pointer.fillAmount = timeElapsed / 3;
                timeElapsed = timeElapsed + Time.deltaTime;

                if(timeElapsed >= 3){
        
                    StartCoroutine(moveDolphin());
                    DolphinText.SetActive(true);
                    Dolphin.SetActive(false);
                    Debug.Log("Dolphin hit");
                }

            }else if(hit.transform.tag == "Shark"){
                pointer.fillAmount = timeElapsed / 3;
                timeElapsed = timeElapsed + Time.deltaTime;

                if(timeElapsed >= 3){
        
                    StartCoroutine(moveShark());
                    SharkText.SetActive(true);
                    Shark.SetActive(false);
                    Debug.Log("Shark hit");
                }

            }
            else if(hit.transform.tag == "MainFish"){
                pointer.fillAmount = timeElapsed / 2;
                timeElapsed = timeElapsed + Time.deltaTime;

                if(timeElapsed >= 2)
                {
                    MainFish.transform.GetComponent<Animator>().SetBool("SeeMainFish", true);
                    Debug.Log("MainFish Hit");
                    turtleArrowPointer1.SetActive(true);
                }
            }
            else if(hit.transform.tag == "ArrowPointer")
            {
                pointer.fillAmount = timeElapsed / 2;
                timeElapsed = timeElapsed + Time.deltaTime;

                if(timeElapsed >= 2)
                {
                    transform.GetComponent<Animator>().SetBool("SeeArrow", true);
                    turtleArrowPointer1.SetActive(false);
                    turtleArrowPointer2.SetActive(true);
                }
            }
            else if(hit.transform.tag == "ArrowPointer2")
            {
                pointer.fillAmount = timeElapsed / 2;
                timeElapsed = timeElapsed + Time.deltaTime;

                if(timeElapsed >= 2)
                {
                    transform.GetComponent<Animator>().SetBool("SeeArrow", false);
                    turtleArrowPointer2.SetActive(false);
                }
            }
        }
        else
        {
            timeElapsed = 0;
            pointer.fillAmount = 0;
        }
        Debug.DrawRay(cam.transform.position,forward,Color.red);
    }

    IEnumerator moveWhale(){
        
        while(transform.position != whalePos.position){
             transform.position = Vector3.MoveTowards(transform.position,whalePos.position,Time.deltaTime*10);
             yield return null;
        }
        
    }

    IEnumerator moveTurtle(){
        
        while(transform.position != TurtlePos.position){
             transform.position = Vector3.MoveTowards(transform.position,TurtlePos.position,Time.deltaTime*10);
             yield return null;
        }
        
    }

    IEnumerator moveDolphin(){
        
        while(transform.position != DolphinPos.position){
             transform.position = Vector3.MoveTowards(transform.position,DolphinPos.position,Time.deltaTime*10);
             yield return null;
        }
        
    }

    IEnumerator moveShark(){
        
        while(transform.position != SharkPos.position){
             transform.position = Vector3.MoveTowards(transform.position,SharkPos.position,Time.deltaTime*10);
             yield return null;
        }
        
    }

    IEnumerator moveMainFish()
    {
        while(MainFish.transform.position != MainFishPos.position)
        {
            MainFish.transform.position = Vector3.MoveTowards(MainFish.transform.position, MainFishPos.position, Time.deltaTime);
            yield return null;
        }
    }

    
}
