using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonScript : MonoBehaviour,IVirtualButtonEventHandler { //IVirtualButtonEventHandler is an interface

    public GameObject cubeObject, sphereObject;

    //VirtualButtonBehavior is a script and we need a datatype of that script to store the script
    VirtualButtonBehaviour vbb;

	// Use this for initialization
	void Start () {
        //storing the VirtualButtonBehavior script in vbb
        vbb = GetComponentInChildren<VirtualButtonBehaviour>();

        //Registering the virtualButton
        vbb.RegisterEventHandler(this);

        cubeObject.SetActive(true);
        sphereObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //OnButtonPressed is an abstract method of IVirtualButtonEventHandler
    public void OnButtonPressed(VirtualButtonBehaviour vb) //VirtualButtonBehavior is a datatype that gives the name of the virual butotn pressed   
    {
        cubeObject.SetActive(false);
        sphereObject.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        cubeObject.SetActive(true);
        sphereObject.SetActive(false);
    }
}
