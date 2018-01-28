using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Chats : MonoBehaviour {

    public TextMeshProUGUI[] rumourDialog;
    public TextMeshProUGUI[] chatDialog;
    public RumoursForTheDay rFTD;
    public OutcomesForTheDay oFTD;

    // Use this for initialization
    void Start () {
        for (int i = 0; i < rFTD.rumours.Count; i++)
        {
            if (rFTD.rumours[i] != null)
            {
                rumourDialog[i].text = rFTD.rumours[i].summary;
            }
            else
            {
                rumourDialog[i].text = "No Rumours Here...";
            }
        }

        for (int i = 0; i < oFTD.outcomes.Count; i++)
        {
            if (oFTD.outcomes[i] != null)
            {
                chatDialog[i].text = oFTD.outcomes[i].panels[i].text;
            }
            else
            {
                chatDialog[i].text = "No Chats Here...";
            }
        }
    }
}
