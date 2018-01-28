using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Give : MonoBehaviour
{
    public soReputation rep;
    public soVector3 playerPosition;
    public GameObject canvas;

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
                Vector3 dist = playerPosition.Value - hit.transform.position;

                if (dist.magnitude < 3.0f)
                {
                    if (hit.transform.tag == "NPC")
                    {
                        rep.changeReputation(100);
                        Debug.Log(rep.getReputation());
                        canvas.SetActive(true);
                    }
                }
            }
        }
    }
}
