using UnityEngine;
using System.Collections;

public class Scopes_and_Modifiers : MonoBehaviour {

	public int respawn = 1;

	private ClassTwo foodClass;



	// Use this for initialization
	void Start () {
		respawn = 6;
		foodClass = new ClassTwo ();
		foodClass.Zambaroonies(respawn, foodClass.emptyCan);
		while (respawn <= 6 && respawn != 0) {
			respawn --;

		}
	}

	void Example (int walkers, int runners){
		int totalZambos;
		totalZambos = (walkers + runners) * respawn;
		Debug.Log (totalZambos);
	}

	// Update is called once per frame
	void Update () {
			while(respawn != 0) {
			Debug.Log ("Zambaroonies! There are:" + respawn);
		}
	}
}
