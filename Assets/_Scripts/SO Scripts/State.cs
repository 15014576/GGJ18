using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "Misc/State")]
public class State : ScriptableObject
{
    public StateName currentState;

    GameObject Broswer;
    GameObject Story;

    public void Setup(GameObject _browser, GameObject _story)
    {
        Broswer = _browser;
        Story = _story;

        Broswer.SetActive(false);
        Story.SetActive(false);

        changeState(StateName.Home);
    }

    void changeState(StateName newState)
    {
        switch(currentState)
        {
            case StateName.Home:
                Broswer.SetActive(false);
                break;
            case StateName.Rumours:
                Story.SetActive(false);
                break;

        }

        currentState = newState;

        switch(currentState)
        {
            case StateName.Home:
                Broswer.SetActive(true);
                break;
            case StateName.Rumours:
                Story.SetActive(true);
                break;
        }
    }

    public void LogOff()
    {
        changeState(StateName.Rumours);
    }

}
public enum StateName
{
    Menu, Home, Rumours, Schoolyard, Outcomes
}
