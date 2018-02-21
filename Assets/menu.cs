using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour {

	// Use this for initialization
	public void PlayGame () {
        //SceneManager.LoadScene();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void quitButton(){
        Debug.Log("Application quit");
        Application.Quit();
    }
}
