using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorCollisionScript : MonoBehaviour{
    
    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "character")
        {
            print("Collision detected with trigger object " + other.name);
        }
    }

    public void OnTriggerStay2D(Collider2D other)
    {
        print("Still colliding with trigger object " + other.name);
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        print(gameObject.name + " and trigger object " + other.name + " are no longer colliding");
    }
}
