using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum TILE_TEXTURE : int{//enumerates and assigns numeric value to identify which textures to render
    WATER0_TILE_TEXTURE,
    WATER1_TILE_TEXTURE,
    WATER2_TILE_TEXTURE,
    WATER3_TILE_TEXTURE,
    WATER4_TILE_TEXTURE,
    WATER5_TILE_TEXTURE,
    WATER6_TILE_TEXTURE,
    WATER7_TILE_TEXTURE,
    WATER8_TILE_TEXTURE,
    GRASS9_TILE_TEXTURE,
    GRASS10_TILE_TEXTURE,
    GRASS11_TILE_TEXTURE,
    GRASS12_TILE_TEXTURE,
    MAX_TILE_TEXTURE
}


struct grid_node{					//the grid is made up of these nodes
	public int x_pos;				//node position
	public int y_pos;
	public bool is_occupied;		//bool value which determines wether the spot is occupied
	public int TEXTURE;				//numeric value which determines textures
	//public character* occupant;	//pointer to current occupant if is_occupied is true
}

public class map_grid_script : MonoBehaviour { 
    grid_node [,] GRID = new grid_node[24, 24];

    void grid_initialize(){			//function that is called at run time to determine contents of grid
		for(int i=0; i<24; i++){	
			for(int j=0; j<24; j++){
				GRID[i, j].x_pos = i;
				GRID[i, j].y_pos = j;
				GRID[i, j].is_occupied = false;
				GRID[i, j].TEXTURE = (int)TILE_TEXTURE.GRASS9_TILE_TEXTURE;
			}
		}
	}

	grid_node grid_check(ref int x, ref int y){
		return GRID[x, y];
	}
	
	bool grid_occupied_check(ref int x, ref int y){      
		if(GRID[x, y].is_occupied == true){
			return false;
		}else	if(GRID[x, y].is_occupied == false){
				return true;
			}else {return false;}
	}
}
