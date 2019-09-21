using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Vb2_Video1 : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject vbB3bject;

    public GameObject text1;
   // public GameObject text2;
    public GameObject Video1;
    public GameObject Video2;
    public int state;


    // Start is called before the first frame update
    void Start()
    {
        vbB3bject = GameObject.Find("Button3");
        vbB3bject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);


        Video1 = GameObject.Find("Vid1");
        Video2 = GameObject.Find("Vid2");
        text1 = GameObject.Find("Txt1");
        //text2 = GameObject.Find("Txt2");

        //if(Video1.active = false | Video2.active = false)
        Video1.active = false;
        Video2.active = false;
        text1.active = true;
        //text2.active = false;
        state = 0;

    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {

        //here is where the button would display the character and play the recording
        if (state == 0)
        {
            Video1.active = true;
            Video2.active = false;
            text1.active = false;
        }
        else if (state == 1)
        {
            Video1.active = false;
            Video2.active = true;
            text1.active = false;
        }

        //for debuging purposes
        Debug.Log("BIN Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        //here is where the button would make the character disapear and stop playing the recording

        state++;
       

        //for debuging purposes
        Debug.Log("BIN Realesed");
    }

    void Update()
    {
        if ( state == 2)
        {
            state = 0;
            Video1.active = false;
            Video2.active = false;
            text1.active = true;
        }

    }
}
