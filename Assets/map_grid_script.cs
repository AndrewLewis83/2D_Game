using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TILE_TEXTURE {//enumerates and assigns numeric value to identify which textures to render
    GRASS1_TILE_TEXTURE,
    GRASS2_TILE_TEXTURE,
    GRASS3_TILE_TEXTURE,
    GRASS4_TILE_TEXTURE,
	WALL1_TILE_TEXTURE,
	WALL2_TILE_TEXTURE,
	WATER1_TILE_TEXTURE,
    WATER2_TILE_TEXTURE,
    WATER3_TILE_TEXTURE,
    WATER4_TILE_TEXTURE,
    WATER5_TILE_TEXTURE,
    WATER6_TILE_TEXTURE,
    WATER7_TILE_TEXTURE,
    WATER8_TILE_TEXTURE,
    WATER9_TILE_TEXTURE,
    MAX_TILE_TEXTURE
}

public class grid_node{					//the grid is made up of these nodes
	public int x_pos;				//node position
	public int y_pos;
	public bool is_occupied;		//bool value which determines wether the spot is occupied
	public TILE_TEXTURE texture;				//numeric value which determines textures
	public GameObject tile;
	
	//public character* occupant;	//pointer to current occupant if is_occupied is true

	public grid_node(int _x, int _y, bool _is_occupied, TILE_TEXTURE _texture){
		x_pos = _x;
		y_pos = _y;
		is_occupied = _is_occupied;
		texture = _texture;
			tile = new GameObject("tile");//new Vector3(x_pos * 16.0F, y_pos * 16.0F, 0), Quaternion.identity)
			tile.transform.Translate(x_pos * 16.0F, y_pos * 16.0F, 0);
			//tile.AddComponent<SpriteRenderer>() as SpriteRenderer;
	}
}


public class map_grid_script : MonoBehaviour { 
    grid_node [,] GRID = new grid_node[25, 25];
	

    void grid_initialize(){			//function that is called at run time to determine contents of grid
		for(int i=0; i<25; i++){	
			for(int j=0; j<25; j++){
				GRID[i, j] = new grid_node(i, j, false, TILE_TEXTURE.GRASS1_TILE_TEXTURE);
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
	
	void Start () {
		grid_initialize();
	}
	
	void Update () {
		
	}
}
