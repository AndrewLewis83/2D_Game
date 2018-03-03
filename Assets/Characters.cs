using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Characters : MonoBehaviour {
	public bool ally;

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

        HUDtext.text = "Character Stats:\n\nHP: " + HP.ToString() + "\nAtk: " + Atk.ToString() + "\nSpd: " + Spd.ToString()
            + "\nDef: " + Def.ToString() + "\nLck: " + Lck.ToString() + "\nMov: " + Mov.ToString();
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        HUDtext.text = "move cursor over a character to view stats.";
    }

	// Update is called once per frame
	//void Update () {

	//}
}