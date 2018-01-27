using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    public soVector3 playerPosition;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        Vector3 rightVector = Vector3.right * Input.GetAxis("Horizontal");
        Vector3 forwardVector = Vector3.forward * Input.GetAxis("Vertical");

        rb.velocity = (rightVector + forwardVector) * speed;

        playerPosition.Value = transform.position;
		
	}
}
