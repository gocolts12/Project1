using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Vb2_Floating_text : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject vbB2bject;

    public GameObject text1;
    public GameObject text2;

    // Start is called before the first frame update
    void Start()
    {
        vbB2bject = GameObject.Find("Button2");
        vbB2bject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        text1 = GameObject.Find("Txt1");
        text2 = GameObject.Find("Txt2");

        text2.active = false;

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {

        //here is where the button would display the character and play the recording
        text1.active = false;
        text2.active = true;

        //for debuging purposes
        Debug.Log("BIN Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        //here is where the button would make the character disapear and stop playing the recording
        text1.active = true;
        text2.active = false;

        //for debuging purposes
        Debug.Log("BIN Realesed");
    }
}
