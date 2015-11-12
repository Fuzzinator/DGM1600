using UnityEngine;
using System.Collections;

public class ClassTwo : MonoBehaviour {

	public int emptyCan;
	public int beans;

	private int key;
	private int shotgunShell;

	public void Zambaroonies (int a, int b){
		int total = a + b;
		Debug.Log ("You have" + total);
	}

	private void Items (int a, int b){
		int stuff = a + b;
		Debug.Log ("Items that you have:" + stuff);

	}

}
