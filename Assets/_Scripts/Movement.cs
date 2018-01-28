using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    Animator a;
    Transform childMesh;
    public float speed;
    public soVector3 playerPosition;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
        a = GetComponentInChildren<Animator>();
        childMesh = transform.GetChild(0);
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        Vector3 rightVector = Vector3.right * Input.GetAxis("Horizontal");
        Vector3 forwardVector = Vector3.forward * Input.GetAxis("Vertical");

        rb.velocity = (rightVector + forwardVector) * speed;

        playerPosition.Value = transform.position;

        if(rb.velocity.magnitude > 0f)
        {
            childMesh.localRotation = Quaternion.LookRotation(rb.velocity.normalized);
            a.SetBool("isRunning", true);
            childMesh.localPosition = new Vector3(childMesh.localPosition.x, 0, childMesh.localPosition.z);
        }
        else
        {
            a.SetBool("isRunning", false);
            childMesh.localPosition = new Vector3(childMesh.localPosition.x, -1f, childMesh.localPosition.z);
        }
	}
}
