using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Characters : MonoBehaviour {
	
    public bool ally;
    public bool mainPlayer; // if true, character becomes main character
    public bool mainPlayerSelect; // for taking control of character with cursor
    public bool playableCharacter; // prevents player from taking control of enemy player.
    public GameObject cursor2; // allows player to reactivate cursor

	public int HP;
    public int Atk; 
    public int Spd;
    public int Def;
    public int Lck;
    public int Mov;

    public Text HUDtext; // for populating HUD with player stats;

        //Functions
        void Change_Hp(int iAtk, int ispd){
            HP = HP - (iAtk - Def);

            if ((Spd -ispd) > 5){
                HP = HP - (iAtk - Def);
            }
        }

	// Use this for initialization
	void Start () {
        HP = Random.Range(27, 35);
		Atk = Random.Range(7, 15); 
		Spd = Random.Range(6, 13);
		Def = Random.Range(5, 9);
		Lck = Random.Range(1, 7);
		Mov = 5; 
	}
	
    public void OnTriggerStay2D(Collider2D other)
    {

        mainPlayerSelect = true;
        HUDtext.text = "Character Stats:\n\nHP: " + HP.ToString() + "\nAtk: " + Atk.ToString() + "\nSpd: " + Spd.ToString()
            + "\nDef: " + Def.ToString() + "\nLck: " + Lck.ToString() + "\nMov: " + Mov.ToString();
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        HUDtext.text = "move cursor over a character to view stats.\n\n Press 'space' to take control of one of your characters.\n\n press 'w' to reactivate the cursor.";
        mainPlayerSelect = false;
    }

	// Update is called once per frame
	void Update () {
        // allows player to control unit, if selected as main character. 
        if (mainPlayer == true && playableCharacter == true)
        {
            if (Input.GetAxisRaw("Horizontal") > .5f || Input.GetAxisRaw("Horizontal") < -.5f)
            {
                transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * Mov * Time.deltaTime, 0f, 0f));
            }

            if (Input.GetAxisRaw("Vertical") > .5f || Input.GetAxisRaw("Vertical") < -.5f)
            {
                transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * Mov * Time.deltaTime, 0f));
            }
        }

        if(Input.GetKeyDown("space") && mainPlayerSelect == true){
            cursor2.gameObject.SetActive(false);
            mainPlayer = true;
        }

        if (Input.GetKeyDown("w") && mainPlayerSelect == false)
        {
            cursor2.gameObject.SetActive(true);
            mainPlayer = false;
        }
	}
}