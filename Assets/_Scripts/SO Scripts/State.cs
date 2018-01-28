using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "Misc/State")]
public class State : ScriptableObject
{
    StateName currentState;

    GameObject Broswer;
    GameObject Story;
    public Cinematic Cine;
    RumourMill Mill;
    public bool panelInfoWaiting;

    public void Setup(GameObject _browser, GameObject _story, RumourMill _mill)
    {
        Broswer = _browser;
        Story = _story;
        Mill = _mill;

        Broswer.SetActive(false);
        Story.SetActive(false);

        changeState(StateName.Home);
    }

    public void SetupCinematic(Cinematic c)
    {
        Cine = c;
    }

    public StateName GetState()
    {
        return currentState;
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
            case StateName.Outcomes:
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
                Mill.Generate();
                int iter = 0;
                while(!Mill.ready)
                {
                    iter++;

                    if(iter > 10000)
                    {
                        Debug.LogWarning("Crashed out of whilst waiting for rumour generation to complete");
                    }
                }
                Story.SetActive(true);
                panelInfoWaiting = true;
                
                break;
            case StateName.Outcomes:
                Story.SetActive(true);
                Cine.ShowOutcomes();
                
                break;
        }
    }

    public void LogOff()
    {
        changeState(StateName.Rumours);
    }

    public void EndOfCinematic()
    {
        if(currentState == StateName.Rumours)
        {
            changeState(StateName.Schoolyard);
        }
        else if(currentState == StateName.Outcomes)
        {
            changeState(StateName.Home);
        }
    }

}
public enum StateName
{
    Menu, Home, Rumours, Schoolyard, Outcomes
}
