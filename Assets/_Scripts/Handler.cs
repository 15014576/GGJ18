using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handler : MonoBehaviour
{
    public State StateManager;
    public GameObject BrowserCanvas;
    public GameObject StoryCanvas;
    public RumourMill RumourMillScript;


    // Use this for initialization
    void Start ()
    {
        StateManager.Setup(BrowserCanvas, StoryCanvas,RumourMillScript);
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
