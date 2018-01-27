using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterID : MonoBehaviour
{
    public string fullname;
    public GroupID group;
}

public enum GroupID
{
    Goth, Cool, Pop, Geek, Jock
}