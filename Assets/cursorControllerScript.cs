using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorControllerScript : MonoBehaviour {
	public AudioSource confirm;
	public AudioSource deny;
	public bool isally;
	
    public float moveSpeed;

	// Use this for initialization
	void Start () {
		confirm = GetComponent<AudioSource>();
		deny = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetAxisRaw("Horizontal") > .5f || Input.GetAxisRaw("Horizontal") < -.5f){
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
        }

        if (Input.GetAxisRaw("Vertical") > .5f || Input.GetAxisRaw("Vertical") < -.5f){
            transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
        }
		
		//move function
		/*GameObject character = GameObject.FindWithTag("character");
		isally = GetComponent("Characters").ally;
		if(isally == true){
			if(Input.GetKeyDown("z")){
				confirm.Play();
				
				
				if(Input.GetKeyDown("x")){
					deny.Play();
					
				}
			}
		}*/
	}
}
