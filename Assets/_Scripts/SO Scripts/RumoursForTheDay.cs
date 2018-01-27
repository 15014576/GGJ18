using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "Misc/RumoursForDay")]
public class RumoursForTheDay : ScriptableObject
{
    public List<Rumour> rumours;
    public int index;
}
