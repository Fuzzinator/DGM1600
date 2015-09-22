using UnityEngine;
using System.Collections;

public class IfStatements : MonoBehaviour
{
	float ovenTemp = 600f;
	float maxHotTemp = 420f;
	float minColdTemp = 350f;
	
	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.Return))
			TempCheck();
		
		ovenTemp -= Time.deltaTime / 2f;
	}
	
	
	void TempCheck ()
	{
		// If the temperature of the oven is more than the hottest oven...
		if(ovenTemp > maxHotTemp)
		{
			// ... do this.
			print("The oven is too hot.");
		}
		// If it isn't, but the temperature of the oven is less than the coldest oven...
		else if(ovenTemp < minColdTemp)
		{
			// ... do this.
			print("The oven is too cold.");
		}
		// If it is neither of those then...
		else
		{
			// ... do this.
			print("The oven is the perfect temperature!");
		}
	}
}