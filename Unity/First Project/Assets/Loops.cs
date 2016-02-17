using UnityEngine;
using System.Collections;

public class Loops : MonoBehaviour {

	int numZambos = 6;
	int deadZambos = 6;

	// Use this for initialization
	void Start () {

		//For loop
		for (int i= 1; i < numZambos; i++) {
		
			Debug.Log ("Oh no! Zambo number" + i);
		}

		// While loop
		while(deadZambos > 0)
		{
			Debug.Log ("The dead are rising!!");
			deadZambos --;
		}

		//DoWhile loop
		 
		bool shouldDo = false;

		do {
			print ("You can make it!");

		} while(shouldDo == true);


		//for each loop
		string[] inventory = new string[3];

		inventory[0] = "You have two items";
		inventory[1] = "You have a shotgun";
		inventory[2] = "You have a machete";

		foreach (string item in inventory)
		{
			print (item);
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
