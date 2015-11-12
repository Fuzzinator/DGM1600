using UnityEngine;
using System.Collections;

public class Enumerations : MonoBehaviour {

	enum Direction {North = 0, Northeast = 45, East = 90, Southeast = 135, South = 180, Southwest = 225, West = 270, Northwest = 315};


	// Use this for initialization
	void Start () {
	
		Direction = myDirection;

		myDirection = Direction.North
	}

	Direction DirHeading (Direction dir){

		if (dir == Direction.North)
			print ("You are heading North");
		else if(dir == Direction.Northeast)
			print ("You are heading North East");
		else if(dir == Direction.East)
			print ("You are heading East");
		else if(dir == Direction.Southeast)
			print ("You are heading South East");
		else if(dir == Direction.South)
			print ("You are heading South");
		else if(dir == Direction.Southwest)
			print ("You are heading SouthWest");
		else if(dir == Direction.West)
			print ("You are heading west");
		else if(dir == Direction.North)
			print ("You are heading Northwest");

	}
}