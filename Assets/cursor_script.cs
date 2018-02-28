using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursor_script : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float newxPos;
		float newyPos;
		float gridl = .16f;
			if(Input.GetKeyDown("w")){
				newxPos = transform.position.x;
				newyPos = transform.position.y + gridl;
				transform.position = new Vector3(newxPos, newyPos, 0);
			}else if(Input.GetKeyDown("a")){
				newxPos = transform.position.x - gridl;
				newyPos = transform.position.y;
				transform.position = new Vector3(newxPos, newyPos, 0);
			}else if(Input.GetKeyDown("s")){
				newxPos = transform.position.x;
				newyPos = transform.position.y - gridl;
				transform.position = new Vector3(newxPos, newyPos, 0);
			}else if(Input.GetKeyDown("d")){
				newxPos = transform.position.x + gridl;
				newyPos = transform.position.y;
				transform.position = new Vector3(newxPos, newyPos, 0);
			}
			
		GameObject character = GameObject.FindWithTag("character");
		if(transform.position == character.transform.position){
			//if(character.ally == true){
				print("character selected");
			//}
		}
	}
}
