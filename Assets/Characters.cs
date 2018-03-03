using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characters : MonoBehaviour {
	public bool ally;

	public int HP;
    public int Atk; 
    public int Spd;
    public int Def;
    public int Lck;
    public int Mov;

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
	
	// Update is called once per frame
	void Update () {

	}
}