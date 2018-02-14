using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum TILE_TEXTURE: int{//enumerates and assigns numeric value to identify which textures to render
	WATER1_TILE_TEXTURE,
	WATER2_TILE_TEXTURE,
	WATER3_TILE_TEXTURE,
	WATER4_TILE_TEXTURE,
	WATER5_TILE_TEXTURE,
	WATER6_TILE_TEXTURE,
	WATER7_TILE_TEXTURE,
	WATER8_TILE_TEXTURE,
	WATER9_TILE_TEXTURE,
	GRASS1_TILE_TEXTURE,
	GRASS2_TILE_TEXTURE,
	GRASS3_TILE_TEXTURE,
	GRASS4_TILE_TEXTURE,
	MAX_TILE_TEXTURE
}

enum FRIEND_FOE: int{//enumerates to determine unit allegiance
		ALLY,
		ENEMY,
		FRIEND_FOE_MAX
}

struct grid_node{				//the grid is made up of these nodes
	int x_pos;					//node position
	int y_pos;
	bool is_occupied;			//bool value which determines wether the spot is occupied
	int TEXTURE;				//numeric value which determines textures
	//character* occupant;		//pointer to current occupant if is_occupied is true
	int alliance;				//determines the occupants allegiance 
};

public class map_grid_script.cs : MonoBehaviour {
	grid_node GRID[24][24];		//grid initialization 
	void grid_initialize(){		//function that is called at run time to determine contents of grid
		
	};
	
	grid_node grid_check(ref int x, ref int y){
		return GRID[x][y];
	}
	
	bool grid_move_unit(ref int x, ref int y, ){		//function to move a unit on the grid
		if(GRID[x][y].is_occupied == true){				//this function will check if a space is occupied by an enemy
			
			}else if(GRID[x][y].is_occupied == false){	//this will allow you to move a unit to the space
			
			}
	}
}
