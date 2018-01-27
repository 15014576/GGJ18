using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SliderController : MonoBehaviour {

    public soReputation update;
    public Slider repBar;

    private void Start()
    {
    }

    private void Update()
    {
        repBar.value = update.getReputation();
    }
}
