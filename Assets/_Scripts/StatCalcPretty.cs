﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StatCalcPretty : MonoBehaviour {

    public Group cool;
    public Group sports;
    public Group pretty;
    public Group drama;
    public Group nerd;
    public RectTransform rtMain;
    public RectTransform rt;
    public TextMeshProUGUI text;

    // Use this for initialization
    void Start()
    {
        rt.GetComponent<RectTransform>();
        // (stat/sum) * rt.xmax
        float UIL = rtMain.rect.xMax;

        int sum = cool.stature.getStature() + sports.stature.getStature() + pretty.stature.getStature() + drama.stature.getStature() + nerd.stature.getStature();

        text.text = (pretty.stature.getStature() / sum) * (UIL / 5) + "%";

        float y = (pretty.stature.getStature() / sum) * (UIL / 5);

        rt.sizeDelta = new Vector2(rt.rect.height, y);
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
