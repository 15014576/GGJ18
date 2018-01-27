using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AssignRumour : MonoBehaviour {

    public RumoursForTheDay assign;
    public Button button1;
    public Button button2;
    public Button button3;

    // Use this for initialization
    void Start () {
        button1.GetComponentInChildren<Text>().text = assign.rumours[1].summary;
        button2.GetComponentInChildren<Text>().text = assign.rumours[2].summary;
        button3.GetComponentInChildren<Text>().text = assign.rumours[3].summary;
    }
}
