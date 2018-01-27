using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float cameraMoveSpeed;
    public soVector3 playerPosition;

    bool playerOutOfSight;
    float timeAway;

	// Use this for initialization
	void Start ()
    {
        playerOutOfSight = false;
        timeAway = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        if(playerOutOfSight)
        {
            timeAway += Time.fixedDeltaTime;

            //get the normalized vector between us and the player
            Vector3 direction = Vector3.Normalize(playerPosition.Value - transform.position);

            transform.Translate(direction * Mathf.Lerp(0,cameraMoveSpeed,timeAway/5));
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            playerOutOfSight = true;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            playerOutOfSight = false;
            timeAway = 0;
        }
    }
}
