using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Give : MonoBehaviour
{
    public soReputation rep;
    public Canvas canvas;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.tag == "Goth")
                {
                    rep.changeReputation(100);
                    Debug.Log(rep.getReputation());
                    canvas.gameObject.SetActive(true);
                }
            }
        }
    }
}
