using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "soStature")]
public class soStature : ScriptableObject
{

    public int stature;

    public int min;
    public int max;

    private void OnEnable()
    {
        //stature = 0;
    }

    public int getStature()
    {
        return stature;
    }

    public void changeStature(int val)
    {
        stature += val;

        if (stature < min)
        {
            stature = min;
        }

        if (stature > max)
        {
            stature = max;
        }
    }
}

