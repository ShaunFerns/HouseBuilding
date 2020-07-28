using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
 

    // As long as we are colliding with a trigger collider
    private void OnTriggerStay(Collider other)
    {
        // Check if the object has the tag 'Door'
        if (other.tag == "Door")
        {
                       // Get the Animator from the child of the door (If you have the Animator component in the parent,
            // then change it to "GetComponent")
            Animator anim = other.GetComponentInChildren<Animator>();
            // Check if the player hits the "E" key
            if (Input.GetKeyDown(KeyCode.E))
                anim.SetTrigger("OpenClose"); //Set the trigger "OpenClose" which is in the Animator
        }
    }

    
}
