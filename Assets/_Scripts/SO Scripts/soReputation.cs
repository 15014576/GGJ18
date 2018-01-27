using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "soReputation")]
public class soReputation : ScriptableObject {

    public int reputation;

    private void OnEnable()
    {
        reputation = 0;
    }
}
