using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Vb2_Video2 : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject vbB4bject;

    public GameObject text1A;
    public GameObject text2;
    public GameObject Video1A;
    public GameObject Video2A;


    // Start is called before the first frame update
    void Start()
    {
        vbB4bject = GameObject.Find("Button3");
        vbB4bject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        Video1A = GameObject.Find("Vid1");
        Video2A = GameObject.Find("Vid2");
        text1A = GameObject.Find("Txt1");

        Video1A.active = false;
        Video2A.active = false;

    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {

        //here is where the button would display the character and play the recording
        Video1A.active = false;
        Video2A.active = true;
        text1A.active = false;


        //for debuging purposes
        Debug.Log("BIN Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        //here is where the button would make the character disapear and stop playing the recording
        Video1A.active = false;
        Video2A.active = false;
        text1A.active = true;


        //for debuging purposes
        Debug.Log("BIN Realesed");
    }
}

