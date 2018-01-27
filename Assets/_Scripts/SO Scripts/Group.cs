using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "Group")]
public class Group : ScriptableObject
{
    public string title;

    public float stature;

    //insert soreputation here yo;

    public List<Group> friends;
    public List<Group> enemies;
}
