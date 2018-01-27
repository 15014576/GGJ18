using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rumour : MonoBehaviour
{

    public string rumour;
    public string about;

    public Rumour(string rT, string a)
    {
        rumour = rT;
        about = a;
    }

	// Use this for initialization
	void Start () {
		if (about == "Goth")
        {
            Group.Goth goth;
        }
	}
	
	void rumourGiven()
    {

    }
}
