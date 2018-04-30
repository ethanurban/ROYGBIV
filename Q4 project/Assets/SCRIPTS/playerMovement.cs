using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

    Rigidbody rb;
    Vector3 movementSpeed;
    public int playerNum;
    bool lost;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
    }
    private bool grounded = true;
    private void OnTriggerEnter(Collider collision)
    {
        grounded = true;
    }
    private void OnTriggerExit(Collider collision)
    {
        if (grounded)
        {
            grounded = false;
        }
    }
    // Update is called once per frame
    void Update () {
        Vector3 movementSpeed = new Vector3(Input.GetAxisRaw("L_XAxis_" + playerNum), 0, -(Input.GetAxisRaw("L_YAxis_" + playerNum)));    //movement speed is the XY values of analog stick state
        

        if (Input.GetAxis("R_XAxis_" + playerNum) != 0 || Input.GetAxis("R_YAxis_" + playerNum) != 0f)   //if the analog stick isn't centered
        {    
            float h = Input.GetAxis("R_XAxis_" + playerNum); //piece of the angle I need to face is X value from analog stick state
            float v = Input.GetAxis("R_YAxis_" + playerNum); //piece of the angle I need to face is Y value from analog stick state
            float angle = Mathf.Atan2(h, -v) * Mathf.Rad2Deg; //the angle I need to face is this
            transform.localEulerAngles = new Vector3(0, angle, 0); //set facing direction to this angle
        }

        transform.position += movementSpeed / 8;//Actually make the object move
        if (Input.GetButtonDown("LB_" + playerNum) && grounded)
        {
            rb.AddForce(new Vector3 (0, 100, 0));
        }
    }
}
