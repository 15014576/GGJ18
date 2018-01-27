using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RumourPool : ScriptableObject
{
    public List<Rumour> tierone;
    public List<Rumour> tiertwo;
    public List<Rumour> tierthree;

    public Rumour GetRumour(int tier)
    {
        List<Rumour> rumourList;

        switch(tier)
        {
            case 1:
                rumourList = tierone;
                break;
            case 2:
                rumourList = tiertwo;
                break;
            case 3:
                rumourList = tierthree;
                break;
            default:
                Debug.LogWarning("You are asking for a tier that doesn't exist in the RumourPool Class");
                rumourList = new List<Rumour>();
                break;
        }

        return rumourList[Random.Range(0, rumourList.Count)];
    }

}
