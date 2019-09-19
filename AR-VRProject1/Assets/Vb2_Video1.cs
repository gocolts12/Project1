using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Vb2_Video1 : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject vbB3bject;

    public GameObject text1;
    public GameObject text2;
    public GameObject Video1;
    public GameObject Video2;


    // Start is called before the first frame update
    void Start()
    {
        vbB3bject = GameObject.Find("Button3");
        vbB3bject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        Video1 = GameObject.Find("Vid1");
        Video2 = GameObject.Find("Vid2");
        text1 = GameObject.Find("Txt1");

        Video1.active = false;
        Video2.active = false;

    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {

        //here is where the button would display the character and play the recording
        Video1.active = true;
        Video2.active = false;
        text1.active = false;


        //for debuging purposes
        Debug.Log("BIN Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        //here is where the button would make the character disapear and stop playing the recording
        Video1.active = false;
        Video2.active = false;
        text1.active = true;
       

        //for debuging purposes
        Debug.Log("BIN Realesed");
    }
}
