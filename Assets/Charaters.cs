using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charaters : MonoBehaviour {

    class Character
    {
        private
            int HP,
                Atk,
                Spd,
                Def,
                Lck,
                Mov;

        public
            Character()
        {
            HP = Random.Range(27, 35);
            Atk = Random.Range(7, 15); 
            Spd = Random.Range(6, 13);
            Def = Random.Range(5, 9);
            Lck = Random.Range(1, 7);
            Mov = 5;
        }

        //Getters
        int Get_HP()
        {
            return HP;
        }

        int Get_Atk()
        {
            return Atk;
        }

        int Get_Spd()
        {
            return Spd;
        }

        int Get_Def()
        {
            return Def;
        }

        int Get_Lck()
        {
            return Lck;
        }


        //Functions
        void Change_Hp(int iAtk)
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