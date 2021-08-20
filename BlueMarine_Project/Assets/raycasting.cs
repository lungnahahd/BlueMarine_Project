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

    public Transform ManPos;
    public GameObject Man;
    public GameObject ManText1;
    public GameObject ManText2;
    public GameObject ManTyping1;
    public GameObject ManTyping2;
    public GameObject ManCanvasB1;

    //FifthCanvas
    public GameObject FifthCanvasB1;
    public GameObject FifthCanvasB2;
    public GameObject Fitext1;
    public GameObject Fitext2;  
    public GameObject Fitext3;  

    public GameObject FifthCanvasT1;
    public GameObject FifthCanvasT2;
    public GameObject FifthCanvasT3;


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



     //ThirdCanvas
    public GameObject ThirdCanvasB1;
    public GameObject Thtext1;
    public GameObject Thtext2;  
    public GameObject ThirdCanvas2Text;

    public GameObject ThirdCanvasT1;
    public GameObject ThirdCanvasT2;
    public GameObject ThirdCanvas2T;



     //FourthCanvas
    public GameObject FourthCanvasB1;
    public GameObject Fotext1;
    public GameObject Fotext2;  
    public GameObject FourthCanvas2Text;

    public GameObject FourthCanvasT1;
    public GameObject FourthCanvasT2;
    public GameObject FourthCanvas2T;







    public Transform MainFishPos;
    public GameObject MainFish;

    public GameObject turtleArrowPointer1;
    public GameObject turtleArrowPointer2;

    public GameObject dolphinArrowPointer1;
    public GameObject dolphinArrowPOinter2;

    public GameObject sharkArrowPointer1;
    public GameObject sharkArrowPointer2;

    public GameObject ManArrowPointer1;
    public GameObject ManArrowPointer2;

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
            if(hit.transform.tag == "Man"){
                pointer.fillAmount = timeElapsed / 2;
                timeElapsed = timeElapsed + Time.deltaTime;

                if(timeElapsed >= 2){

                    StartCoroutine(moveMan());
                    ManTyping1.SetActive(true);
                    ManText1.SetActive(true);
                    //Man.SetActive(false);

                    Fitext2.SetActive(false);
                    ManCanvasB1.SetActive(true);
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

                    Thtext2.SetActive(false);
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

                    Fotext2.SetActive(false);
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

            }else if(hit.transform.tag == "ThirdCanvasB1"){
                pointer.fillAmount = timeElapsed / 2;
                timeElapsed = timeElapsed + Time.deltaTime;

                if(timeElapsed >= 2){
                   Thtext1.SetActive(false);

                   ThirdCanvasT2.SetActive(true);
                   Thtext2.SetActive(true);
                  
                   ThirdCanvasB1.SetActive(false);
                   Dolphin.transform.GetComponent<BoxCollider>().enabled = true;

                   timeElapsed = 0;
                   pointer.fillAmount = 0;

                }

            }else if(hit.transform.tag == "FourthCanvasB1"){
                pointer.fillAmount = timeElapsed / 2;
                timeElapsed = timeElapsed + Time.deltaTime;

                if(timeElapsed >= 2){
                   Fotext1.SetActive(false);

                   FourthCanvasT2.SetActive(true);
                   Fotext2.SetActive(true);
                  
                   FourthCanvasB1.SetActive(false);
                   Shark.transform.GetComponent<BoxCollider>().enabled = true;

                   timeElapsed = 0;
                   pointer.fillAmount = 0;

                }

            }else if(hit.transform.tag == "FifthCanvasB1"){
                pointer.fillAmount = timeElapsed / 2;
                timeElapsed = timeElapsed + Time.deltaTime;

                if(timeElapsed >= 2){
                   Fitext1.SetActive(false);

                   FifthCanvasT2.SetActive(true);
                   Fitext2.SetActive(true);
                  
                   FifthCanvasB1.SetActive(false);
                   Man.transform.GetComponent<BoxCollider>().enabled = true;

                   timeElapsed = 0;
                   pointer.fillAmount = 0;

                }

            }else if(hit.transform.tag == "ManCanvasB1"){
                pointer.fillAmount = timeElapsed / 2;
                timeElapsed = timeElapsed + Time.deltaTime;

                if(timeElapsed >= 2){
                   ManText1.SetActive(false);

                   FifthCanvasT3.SetActive(true);
                   Fitext3.SetActive(true);
                  
                   ManCanvasB1.SetActive(false);
                   FifthCanvasB2.SetActive(true);
                   Man.transform.GetComponent<BoxCollider>().enabled = true;

                   timeElapsed = 0;
                   pointer.fillAmount = 0;

                }

            }else if(hit.transform.tag == "FifthCanvasB2"){
                pointer.fillAmount = timeElapsed / 2;
                timeElapsed = timeElapsed + Time.deltaTime;

                if(timeElapsed >= 2){
                   Fitext3.SetActive(false);

                   ManTyping2.SetActive(true);
                   ManText2.SetActive(true);
                  
                   FifthCanvasB2.SetActive(false);
                   
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
                        DolphinText.SetActive(false);

                        ThirdCanvas2T.SetActive(true);
                        ThirdCanvas2Text.SetActive(true);

                        MainFish.transform.GetComponent<Animator>().SetBool("SeeMainFish", true);
                        sharkArrowPointer1.SetActive(true);
                    }else if(count == 3)
                    {
                        SharkText.SetActive(false);

                        FourthCanvas2T.SetActive(true);
                        FourthCanvas2Text.SetActive(true);

                        MainFish.transform.GetComponent<Animator>().SetBool("SeeMainFish", false);
                        ManArrowPointer1.SetActive(true);
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
                        ThirdCanvas2Text.SetActive(false);
                        sharkArrowPointer1.SetActive(false);
                        sharkArrowPointer2.SetActive(true);
                    }else if(count == 3)
                    {
                        FourthCanvas2Text.SetActive(false);
                        ManArrowPointer1.SetActive(false);
                        ManArrowPointer2.SetActive(true);
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

                        ThirdCanvasT1.SetActive(true);
                        Thtext1.SetActive(true);

                        ThirdCanvasB1.SetActive(true);
                    }
                    else if (count == 2)
                    {
                        sharkArrowPointer2.SetActive(false);
                        Shark.SetActive(true);

                        Fotext1.SetActive(true);
                        FourthCanvasT1.SetActive(true);

                        FourthCanvasB1.SetActive(true);
                    }
                    else if(count == 3)
                    {
                        ManArrowPointer2.SetActive(false);
                        Man.SetActive(true);

                        Fitext1.SetActive(true);
                        FifthCanvasT1.SetActive(true);

                        FifthCanvasB1.SetActive(true);

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

    IEnumerator moveMan(){
        
        while(transform.position != ManPos.position){
             transform.position = Vector3.MoveTowards(transform.position,ManPos.position,Time.deltaTime*10);
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
