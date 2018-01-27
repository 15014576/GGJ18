using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rumour : ScriptableObject
{
    //Variables generated
    public CharacterID about;
    public PanelInfo opening;
    public List<PanelInfo> outcomes;

    public int intensity;
    GroupID idealGroup;

    //Variables affected by gameplay
    public int outcomeIndex;
    public CharacterID told;
}
