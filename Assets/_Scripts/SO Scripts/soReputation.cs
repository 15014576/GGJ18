using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "soReputation")]
public class soReputation : ScriptableObject {

    private int reputation;

    public int min;
    public int max;

    public int[] milestones = { 100, 200, 500, 800 };

    private void OnEnable()
    {
        reputation = 0;
    }

    public int getReputation()
    {
        return reputation;
    }

    public void changeReputation(int val)
    {
        reputation += val;

        if(reputation < min)
        {
            reputation = min;
        }

        if(reputation > max)
        {
            reputation = max;
        }
    }

    public int getFriends()
    {
        int friends = 0;

        for(int i=0; i < milestones.Length; i++)
        {
            if(milestones[i] < reputation)
            {
                friends++;
            }
        }

        return friends;
    }
}
