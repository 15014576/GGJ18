using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "Group")]
public class Group : ScriptableObject
{
    public string title;

    public soStature stature;

    public soReputation playerRep;

    public RumourPool pool;

    public List<Group> friends;
    public List<Group> enemies;

    public Rumour GetRumour()
    {
        //return a rumour of intensity based on current number of friends
        int rep = playerRep.getFriends();

        int tier = 0;

        List<int> choices = new List<int>();

        switch(rep)
        {
            case 0:
                Add(choices, 1, 100);
                break;
            case 1:
                Add(choices, 1, 75);
                Add(choices, 2, 25);
                break;
            case 2:
                Add(choices, 1, 50);
                Add(choices, 2, 50);
                break;
            case 3:
                Add(choices, 2, 80);
                Add(choices, 3, 20);
                break;
            case 4:
                Add(choices, 2, 50);
                Add(choices, 3, 50);
                break;
            default:
                Debug.LogWarning("Unexpected number of friends in Group Class, Rumour Gen");
                break;
        }

        tier = choices[Random.Range(0, choices.Count)];

        return pool.GetRumour(tier);
    }

    public List<int> Add(List<int> choices, int value, int quantity)
    {
        for(int i=0; i<quantity; i++)
        {
            choices.Add(value);
        }

        return choices;
    }
}
