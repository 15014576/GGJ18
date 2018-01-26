using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Give : MonoBehaviour
{
    Rumour rumour;

    // Use this for initialization
    void Start()
    {
        Rumour rumour = new Rumour("Goth's hate dogs", "Goth");

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
                Goth.Jock jock;

                if (hit.transform.name == rumour.about)
                {
                    //give positive score
                }
                else if (hit.transform.name != rumour.about && )
            }
        }
    }
}
