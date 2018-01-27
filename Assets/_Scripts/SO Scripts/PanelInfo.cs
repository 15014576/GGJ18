using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Writing/Dialogue", fileName = "Dialogue")]
public class PanelInfo : ScriptableObject
{
    public List<Panel> panels;
    public int index;

    private void OnEnable()
    {
        index = 0;
    }

    public Panel GetNextPanel()
    {
        Panel panel = panels[index];
        index++;
        return panel;
    }
}
