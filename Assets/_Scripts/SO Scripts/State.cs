using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "Misc/State")]
public class State : ScriptableObject
{
    public StateName currentState;

    public void Setup()
    {

    }

}
public enum StateName
{
    Menu, Home, Rumours, Schoolyard, Outcomes
}
