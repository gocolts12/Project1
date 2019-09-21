using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Vb2_Floating_text : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject vbB2bject;

    public GameObject text1;
    public GameObject text2;
    public int state2;

    // Start is called before the first frame update
    void Start()
    {
        vbB2bject = GameObject.Find("Button2");
        vbB2bject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        text1 = GameObject.Find("Txt1");
        text2 = GameObject.Find("Txt2");

        text2.active = false;
        state2 = 0;

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {

        //here is where the button would display the character and play the recording
        if (state2 == 0)
        {
            text1.active = false;
            text2.active = true;
        }
        else if (state2 == 1)
        {
            text1.active = true;
            text2.active = false;
        }

            //for debuging purposes
            Debug.Log("BIN Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        //here is where the button would make the character disapear and stop playing the recording

        state2++;

        //for debuging purposes
        Debug.Log("BIN Realesed");
    }

    void Update()
    {
        if (state2 == 2)
        {
            state2 = 0;
            text2.active = false;
            text1.active = true;
        }

    }
}
