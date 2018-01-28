using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CharacterID")]
public class CharacterID : ScriptableObject
{
    public string fullname;
    public Group group;
    public int rank;
}