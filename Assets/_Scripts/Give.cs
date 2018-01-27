using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Give : MonoBehaviour
{
    //Rumour rumour;

    // Use this for initialization
    void Start()
    {
        //Rumour rumour = new Rumour();

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
                    hit.transform.Translate(10, 0, 0);
                }
            }
        }
    }
}
