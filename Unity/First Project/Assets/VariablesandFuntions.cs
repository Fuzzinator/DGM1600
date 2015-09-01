using UnityEngine;
using System.Collections;

public class VariablesandFuntions : MonoBehaviour {

	int Number= 5;

	// Use this for initialization
	void Start () {
		Number = Multiply (Number);
		Debug.Log (Number);
	}
	int Multiply (int Math){
		int ret;
		ret = Math * 3;
		return ret;
	}
}
