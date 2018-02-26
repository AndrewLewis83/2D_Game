using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour {

    private Vector2 pos;
    private bool move = false;

	// Use this for initialization
	void Start () {
        //Will store the initial position
        pos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        GetInput();

        if (move)
        {
            //position wil change when a direction is pressed
            transform.position = pos;
            move = false;
        }
	}

    private void GetInput()
    {
        //This will be the traditional WASD keys for movement
        //Will move the character 16 pixels up or down 
        //(change in sprites in unity if 16 pixels isn't enough)
        if (Input.GetKeyDown(KeyCode.W))
        {
            pos = Vector2.up;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            pos = Vector2.left;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            pos = Vector2.down;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            pos = Vector2.right;
        }
    }
}
