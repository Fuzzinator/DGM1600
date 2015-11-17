using UnityEngine;
using System.Collections;

public class Switch_Statement : MonoBehaviour {

	public int perception= 5;

	void shoot()
	{
		switch (perception) 
		{
		case 5:
			print ("you hit the zambaroonie square in the face!");
			break;
		case 4:
			print ("you hit the zambaroonie in the chest!");
			break;
		case 3:
			print("You barely hit the zambaroonie!");
			break;
		case 2:
			print ("You miss the zombie");
			break;
		case 1:
			print ("Are you even aiming?");
			break;
		default:
			print ("Sorry perception must be between 1 and 5.");
			break;
		}
	}
}