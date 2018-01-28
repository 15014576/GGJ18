using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutcomeGen : ScriptableObject
{
    //takes in a rumour and a character ID and adds to the outcomes for the day

    public void DecideOutcome(Rumour r, CharacterID c)
    {
        Debug.Log("Rumour: " + r.summary + " to " + c.fullname);
    }
}
