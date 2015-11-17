using UnityEngine;
using System.Collections;

public class Arrays : MonoBehaviour {

	public GameObject[] enemies; 

	int[] zambaroonieHP = {5, 10, 15, 20, 25};

	// Use this for initialization
	void Start () {
		enemies = GameObject.FindGameObjectsWithTag("Enemy");

		for (int i = 0; i < enemies.Length; i++) {
		
			Debug.Log("Enemy Number " +i+ " is a " +enemies[i].name);
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
