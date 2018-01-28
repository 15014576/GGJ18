using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StatureCalc : MonoBehaviour {

    //get all groups and their statures
    public Panel mainPanel;
    RectTransform rt;
    public Panel[] ChildPanels;
    public TextMeshProUGUI coolText;
    public TextMeshProUGUI sportsText;
    public TextMeshProUGUI prettyText;
    public TextMeshProUGUI dramaText;
    public TextMeshProUGUI nerdText;

    // Use this for initialization
    void Start () {
        ChildPanels = GetComponentsInChildren<Panel>();
        rt = GetComponent<RectTransform>();
    }
	
	// Update is called once per frame
	void Update () {


        float UIL = rt.rect.xMax;


	}
}
