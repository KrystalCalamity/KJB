using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

public GameObject ObjectToJump;
public GameObject JumpSound = null;
public Vector3 JumpAmount;

public bool canJump = true;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canJump == true)
        {
            Rigidbody rb = ObjectToJump.GetComponent<Rigidbody>();
            rb.velocity = JumpAmount;
            rb.transform.rotation = Quaternion.LookRotation(rb.velocity);
            if(JumpSound != null)
            {
            Instantiate(JumpSound, transform.position, Quaternion.identity);
            }
        }
    }
    
}
