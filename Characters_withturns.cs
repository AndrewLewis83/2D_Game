﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Characters : MonoBehaviour {

	public bool enemyTurn;	//variables for turn mechanic
	public bool playerTurn;
	public int enemyMoves;
	public int playerMoves;
	public int turnCount;
	public bool hasMoved;
	
    public bool ally;
    public bool mainPlayer; // if true, character becomes main character
    public bool mainPlayerSelect; // for taking control of character with cursor
    public bool playableCharacter; // prevents player from taking control of enemy player.
    public GameObject cursor2; // allows player to reactivate cursor

    public Text HUDtext; // for populating HUD with player stats;

	public int HP;
    public int Atk; 
    public int Spd;
    public int Def;
    public int Lck;
    public int Mov;

    private Rigidbody2D characterRigidBody;

    public AudioClip hurtSound;
    private AudioSource source;

    private bool moving;

    public float timeBetweenMove;
    private float timeBetweenMoveCounter;
    public float timeToMove;
    private float timeToMoveCounter;

    private Vector3 moveDirection;
	private float newYpos;


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
		
		hasMoved = false;
		turnCount = 1;
		
        characterRigidBody = GetComponent<Rigidbody2D>();

        timeToMoveCounter = timeBetweenMove;
        timeToMoveCounter = timeToMove;

        source = GetComponent<AudioSource>();
		
		enemyMoves = 0;
		playerMoves = 5;

	}

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "key" && mainPlayer == true){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (other.tag == "enemy" && mainPlayer == true){
            HP -= 5;
            source.Play();

        }
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
	
		
	public void TurnFunction(){
		if(turnCount%2 == 0){	//is enemy turn
			if(enemyMoves != 0){
				enemyTurn = true;
				playerTurn = false;
			}else if(enemyMoves <= 0){
				turnCount++;
				playerMoves = 5;
				hasMoved = false;
			}
		}else{					//is player turn
			if(playerMoves !=0){
				playerTurn = true;
				enemyTurn = false;
			}else if(playerMoves <= 0){
				turnCount++;
				enemyMoves = 5;
			}
		}
	}

	// Update is called once per frame
	void Update(){
	
		TurnFunction();

        // kills the character if HP expires.
        if(HP <= 0){
            this.enabled = false;
        }

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

        // rudimentary ai controls enemy character 
		if(enemyTurn==true){
			if (ally == false){
				/*if (moving){
					timeToMoveCounter -= Time.deltaTime;
					characterRigidBody.velocity = moveDirection;

					if(timeToMoveCounter < 0f){
						moving = false;
						timeBetweenMoveCounter = timeBetweenMove;
					}
				}
				else{
					timeBetweenMoveCounter -= Time.deltaTime;
					characterRigidBody.velocity = Vector2.zero;
					if (timeBetweenMoveCounter < 0f){
						moving = true;
						timeToMoveCounter = timeToMove;

						moveDirection = new Vector3(Random.Range(-1f, 1f) * Mov, Random.Range(-1f, 1f) * Mov, 0f);
					}
				}*/
				for(int i= 0; i<5; i++){
					Vector3 position = transform.position;
					position.y += -.1f;
					transform.position = position;
				}
				
			}
			for(int i= 0; i<5; i++){enemyMoves--;}
		}
        // allows player to select character as mainPlayer when the cursor is colliding with character.
        if(Input.GetKeyDown("space") && mainPlayerSelect == true && hasMoved==false){
            cursor2.gameObject.SetActive(false);
            mainPlayer = true;
        }

        // allows player to deselect main character and reactivates the cursor.
        if (Input.GetKeyDown("w") && mainPlayerSelect == false){
			if(mainPlayer == true){
				hasMoved = true;
			}
			playerMoves--;
            cursor2.gameObject.SetActive(true);
            mainPlayer = false;
        }
	}
}