using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour {

    // Menu font, Pixel Gothic, by Kajetan Andrzejak - https://www.dafont.com/search.php?q=gothic

	public void PlayGame () {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

    public void quitButton(){
        Debug.Log("Application quit");
        Application.Quit();
    }
}
