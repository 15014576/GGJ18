using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handler : MonoBehaviour
{
    public State StateManager;
    public GameObject BrowserCanvas;
    public GameObject StoryCanvas;


	// Use this for initialization
	void Start ()
    {
        StateManager.Setup(BrowserCanvas, StoryCanvas);
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
