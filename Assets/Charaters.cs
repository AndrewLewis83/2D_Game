using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {
	public bool ally;
    private int HP, Atk, Spd, Def, Lck, Mov;
    Character(){
            HP = Random.Range(27, 35);
            Atk = Random.Range(7, 15); 
            Spd = Random.Range(6, 13);
            Def = Random.Range(5, 9);
            Lck = Random.Range(1, 7);
            Mov = 5;
    }

        //Getters
        public int Get_HP()
        {
            return HP;
        }

        public int Get_Atk()
        {
            return Atk;
        }

        public int Get_Spd()
        {
            return Spd;
        }

        public int Get_Def()
        {
            return Def;
        }

        public int Get_Lck()
        {
            return Lck;
        }
		

        //Functions
        void Change_Hp(int iAtk, int ispd)
        {
            HP = HP - (iAtk - Def);

            if ((Spd -ispd) > 5)
            {
                HP = HP - (iAtk - Def);
            }
        }

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

	}
}