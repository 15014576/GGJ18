using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    public float speed;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        float horz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");

        Vector3 rightVector = Vector3.right * horz;
        Vector3 forwardVector = Vector3.forward * vert;

        if (Mathf.Abs(rb.velocity.x)/rb.velocity.x != Mathf.Abs(horz)/horz)
        {
            rb.velocity = new Vector3(0, rb.velocity.y, rb.velocity.z);
        }
        /*
        if (Mathf.Abs(rb.velocity.z) / rb.velocity.z != Mathf.Abs(horz) / horz)
        {
            rb.velocity = new Vector3(0, rb.velocity.y, rb.velocity.z);
        }*/

        rb.AddForce((rightVector + forwardVector) * speed);
        
		
	}
}
