using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RumourMill : ScriptableObject
{
    public RumoursForTheDay rumoursOut;
    public Group coolGroup;
    public Group dramaGroup;
    public Group nerdGroup;
    public Group prettyGroup;
    public Group sportyGroup;


    public void Generate()
    {
        //Clear Out the previous rumours
        rumoursOut.rumours.Clear();
        rumoursOut.index = 0;

        //Decide which pools to pull from for the three rumours
        Group[] groups = new Group[3];

        groups[0] = RandomGroupReputation();
        groups[1] = RandomGroupStature();
        groups[2] = RandomGroup(groups[0],groups[1]);

        //Ask those pools for some rumours
        for(int i=0; i<groups.Length;i++)
        {
            rumoursOut.rumours.Add(groups[i].GetRumour());
        }
    }

    Group GetRandomIndexGroup(float[] cumul)
    {
        float rand = Random.Range(0f, cumul[4]);
        int index = 0;

        for(int i=0; i<cumul.Length;i++)
        {
            if(rand >= cumul[i])
            {
                index++;
            }
        }

        switch(index)
        {
            case 0:
                return coolGroup;
            case 1:
                return dramaGroup;
            case 2:
                return nerdGroup;
            case 3:
                return prettyGroup;
            case 4:
                return sportyGroup;
            default:
                Debug.LogWarning("More indicies than groups in Rumour Mill Class");
                return null;
        }

    }

    Group RandomGroupReputation()
    {
        //make an array of reputations in global variable order
        float[] reps = new float[5];

        reps[0] = coolGroup.playerRep.getReputation();
        reps[1] = dramaGroup.playerRep.getReputation();
        reps[2] = nerdGroup.playerRep.getReputation();
        reps[3] = prettyGroup.playerRep.getReputation();
        reps[4] = sportyGroup.playerRep.getReputation();

        //change those values to be cumulative

        for(int i=1; i<reps.Length;i++)
        {
            reps[i] = reps[i] + reps[i - 1];
        }

        return GetRandomIndexGroup(reps);
    }

    Group RandomGroupStature()
    {
        //make an array of statures in global variable order
        float[] stats = new float[5];

        stats[0] = coolGroup.stature.getStature();
        stats[1] = dramaGroup.stature.getStature();
        stats[2] = nerdGroup.stature.getStature();
        stats[3] = prettyGroup.stature.getStature();
        stats[4] = sportyGroup.stature.getStature();

        //change those values to be cumulative

        for (int i = 1; i < stats.Length; i++)
        {
            stats[i] = stats[i] + stats[i - 1];
        }

        return GetRandomIndexGroup(stats);
    }

    Group RandomGroup(Group one, Group two)
    {
        Group rand;

        float[] cumul = { 1, 2, 3, 4, 5 };

        if(one == two)
        {
            rand = one;
            while(rand == one)
            {
                rand = GetRandomIndexGroup(cumul);
            }
        }
        else
        {
            rand = GetRandomIndexGroup(cumul);
        }

        return rand;

    }

}
