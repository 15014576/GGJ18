using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Writing/Panel")]
public class Panel : ScriptableObject
{
    public PanelType typeOfPanel;
    public string nameOfSpeaker;
    [TextArea]
    public string text;
}

public enum PanelType
{
    Setting, One_Person, Two_Person
}
