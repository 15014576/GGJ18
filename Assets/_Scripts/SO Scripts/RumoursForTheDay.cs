using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RumoursForTheDay")]
public class RumoursForTheDay : ScriptableObject
{
    public List<Rumour> rumours;
    public int index;
}
