using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Writing/Rumour")]
public class Rumour : ScriptableObject
{
    //Variables generated
    public CharacterID about;
    public string summary;

    public PanelInfo opening;
    public PanelInfo outcome_tellAbout;
    public List<PanelInfo> outcomes_tellFriends;
    public List<PanelInfo> outcomes_tellEnemies;

    public int intensity;
    public Group idealGroup;

    //Variables affected by gameplay
    public CharacterID told;
}
