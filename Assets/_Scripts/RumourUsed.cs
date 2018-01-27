using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RumourUsed : MonoBehaviour {

    public Button button;
    public GameObject canvas;

    void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(Disable);
    }

    private void Disable()
    {
        button.interactable = false;
        canvas.SetActive(false);
    }
}
