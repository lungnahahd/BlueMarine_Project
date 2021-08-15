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
    public GameObject WhaleTyping;

    public Transform TurtlePos;
    public GameObject Turtle;
    public GameObject TurtleText;
    public GameObject TurtleTyping;


    public Transform DolphinPos;
    public GameObject Dolphin;
    public GameObject DolphinText;
    public GameObject DolphinTyping;


    public Transform SharkPos;
    public GameObject Shark;
    public GameObject SharkText;
    public GameObject SharkTyping;


    //firstCanvas
    public GameObject FirstCanvasB1;
    public GameObject FirstCanvasB2;
    public GameObject FirstCanvasB3;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    
    public GameObject FirstCanvasT2;
    public GameObject FirstCanvasT3;
    public GameObject FirstCanvasT4;


    //secondCanvas
    public GameObject SecondCanvasB1;
    public GameObject Ttext1;
    public GameObject Ttext2;
    public GameObject SecondCanvas2Text;

    public GameObject SecondCanvasT1;
    public GameObject SecondCanvasT2;
    public GameObject SecondCanvas2T;





    public Transform MainFishPos;
    public GameObject MainFish;

    public GameObject turtleArrowPointer1;
    public GameObject turtleArrowPointer2;

    public GameObject dolphinArrowPointer1;
    public GameObject dolphinArrowPOinter2;

    public GameObject sharkArrowPointer1;
    public GameObject sharkArrowPointer2;

    public GameObject whaleArrowPointer1;
    public GameObject whaleArrowPointer2;

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
        Vector3 forward = cam.transform.TransformDirection(Vector3.forward*100);
        if(Physics.Raycast(cam.transform.position,forward,out hit)){
            if(hit.transform.tag == "Whale"){
                pointer.fillAmount = timeElapsed / 2;
                timeElapsed = timeElapsed + Time.deltaTime;

                if(timeElapsed >= 2){

                    StartCoroutine(moveWhale());
                    WhaleTyping.SetActive(true);
                    WhaleText.SetActive(true);
                    Whale.SetActive(false);
                    Debug.Log("Whale hit");
                    MainFish.transform.GetComponent<BoxCollider>().enabled = true;

                }
            }else if(hit.transform.tag == "Turtle"){
                pointer.fillAmount = timeElapsed / 2;
                timeElapsed = timeElapsed + Time.deltaTime;

                if(timeElapsed >= 2){
        
                    StartCoroutine(moveTurtle());
                    TurtleTyping.SetActive(true);
                    TurtleText.SetActive(true);
                    Turtle.SetActive(false);

                    Ttext2.SetActive(false);
                    Debug.Log("Turtle hit");
                    MainFish.transform.GetComponent<BoxCollider>().enabled = true;
                }

            }else if(hit.transform.tag == "Dolphin"){
                pointer.fillAmount = timeElapsed / 2;
                timeElapsed = timeElapsed + Time.deltaTime;

                if(timeElapsed >= 2){
        
                    StartCoroutine(moveDolphin());
                    DolphinTyping.SetActive(true);
                    DolphinText.SetActive(true);
                    Dolphin.SetActive(false);
                    Debug.Log("Dolphin hit");
                    MainFish.transform.GetComponent<BoxCollider>().enabled = true;
                }

            }else if(hit.transform.tag == "Shark"){
                pointer.fillAmount = timeElapsed / 2;
                timeElapsed = timeElapsed + Time.deltaTime;

                if(timeElapsed >= 2){
        
                    StartCoroutine(moveShark());
                    SharkTyping.SetActive(true);
                    SharkText.SetActive(true);
                    Shark.SetActive(false);
                    Debug.Log("Shark hit");
                    MainFish.transform.GetComponent<BoxCollider>().enabled = true;
                }

            }else if(hit.transform.tag == "FirstCanvasB1"){
                pointer.fillAmount = timeElapsed / 2;
                timeElapsed = timeElapsed + Time.deltaTime;

                if(timeElapsed >= 2){
                    
                    text1.SetActive(false);
                    text2.SetActive(true);

                    FirstCanvasT2.SetActive(true);

                    FirstCanvasB1.SetActive(false);
                    FirstCanvasB2.SetActive(true);
                    timeElapsed = 0;
                    pointer.fillAmount = 0;

                   
                }

            }else if(hit.transform.tag == "FirstCanvasB2"){
                pointer.fillAmount = timeElapsed / 2;
                timeElapsed = timeElapsed + Time.deltaTime;

                if(timeElapsed >= 2){

                    text2.SetActive(false);
                    text3.SetActive(true);

                    FirstCanvasT3.SetActive(true);

                    FirstCanvasB2.SetActive(false);
                    FirstCanvasB3.SetActive(true);
                    timeElapsed = 0;
                    pointer.fillAmount = 0;
                    
                    
                }

            }else if(hit.transform.tag == "FirstCanvasB3"){
                pointer.fillAmount = timeElapsed / 2;
                timeElapsed = timeElapsed + Time.deltaTime;

                if(timeElapsed >= 2){
                    text3.SetActive(false);
                    text4.SetActive(true);
                    FirstCanvasT4.SetActive(true);

                    FirstCanvasB3.SetActive(false);

                    timeElapsed = 0;
                    pointer.fillAmount = 0;
                    Debug.Log("but3 hit");
                    MainFish.transform.GetComponent<BoxCollider>().enabled = true;
                }

            }else if(hit.transform.tag == "SecondCanvasB1"){
                pointer.fillAmount = timeElapsed / 2;
                timeElapsed = timeElapsed + Time.deltaTime;

                if(timeElapsed >= 2){
                    Ttext1.SetActive(false);

                    SecondCanvasT2.SetActive(true);
                    Ttext2.SetActive(true);
                    
                    SecondCanvasB1.SetActive(false);
                    Turtle.transform.GetComponent<BoxCollider>().enabled = true;

                    timeElapsed = 0;
                    pointer.fillAmount = 0;
                }

            }
            else if(hit.transform.tag == "MainFish"){
                pointer.fillAmount = timeElapsed / 2;
                timeElapsed = timeElapsed + Time.deltaTime;

                if(timeElapsed >= 2)
                {
                    MainFish.transform.GetComponent<BoxCollider>().enabled = false;
                    if(count == 0)
                    {
                        text4.SetActive(false);
                        MainFish.transform.GetComponent<Animator>().SetBool("SeeMainFish", true);
                        turtleArrowPointer1.SetActive(true);
                    }else if(count == 1)
                    {
                        TurtleText.SetActive(false);

                        SecondCanvas2T.SetActive(true);
                        SecondCanvas2Text.SetActive(true);
                      
                        MainFish.transform.GetComponent<Animator>().SetBool("SeeMainFish", false);
                        dolphinArrowPointer1.SetActive(true);
                    }else if(count == 2)
                    {
                        MainFish.transform.GetComponent<Animator>().SetBool("SeeMainFish", true);
                        sharkArrowPointer1.SetActive(true);
                    }else if(count == 3)
                    {
                        MainFish.transform.GetComponent<Animator>().SetBool("SeeMainFish", false);
                        whaleArrowPointer1.SetActive(true);
                    }
                }
            }
            else if(hit.transform.tag == "ArrowPointer")
            {
                pointer.fillAmount = timeElapsed / 2;
                timeElapsed = timeElapsed + Time.deltaTime;

                if(timeElapsed >= 2)
                {
                    transform.GetComponent<Animator>().SetBool("SeeArrow", true);
                    if(count == 0)
                    {
                        turtleArrowPointer1.SetActive(false);
                        turtleArrowPointer2.SetActive(true);
                    }else if(count == 1)
                    {
                        SecondCanvas2Text.SetActive(false);
                        dolphinArrowPointer1.SetActive(false);
                        dolphinArrowPOinter2.SetActive(true);

                    }else if(count == 2)
                    {
                        sharkArrowPointer1.SetActive(false);
                        sharkArrowPointer2.SetActive(true);
                    }else if(count == 3)
                    {
                        whaleArrowPointer1.SetActive(false);
                        whaleArrowPointer2.SetActive(true);
                    }
                }
            }
            else if(hit.transform.tag == "ArrowPointer2")
            {
                pointer.fillAmount = timeElapsed / 2;
                timeElapsed = timeElapsed + Time.deltaTime;

                if(timeElapsed >= 2)
                {
                    transform.GetComponent<Animator>().SetBool("SeeArrow", false);
                    if (count == 0)
                    {
                        turtleArrowPointer2.SetActive(false);
                        Turtle.SetActive(true);
                        
                        SecondCanvasT1.SetActive(true);
                        Ttext1.SetActive(true);
                        
                        SecondCanvasB1.SetActive(true);
                    }
                    else if (count == 1)
                    {
                        dolphinArrowPOinter2.SetActive(false);
                        Dolphin.SetActive(true);
                    }
                    else if (count == 2)
                    {
                        sharkArrowPointer2.SetActive(false);
                        Shark.SetActive(true);
                    }
                    else if(count == 3)
                    {
                        whaleArrowPointer2.SetActive(false);
                        Whale.SetActive(true);
                    }
                    count += 1;
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
