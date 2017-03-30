using UnityEngine;
using System.Collections;

public class LaneReset2 : MonoBehaviour 
{
	LaneReset lr;

	bool runonce;

	void Awake ()
	{
		lr = GameObject.Find("Bowling Controller").GetComponent<LaneReset>();
	}
	
	void OnTriggerEnter (Collider col)
	{
		if (col.tag == "Player")
		{
			if (!runonce)
			{
				StartCoroutine(lr.TPLaneTwo ());
				runonce = true;
			}
			else
			{
				StartCoroutine(lr.TPLaneThree ());
			}
		}
	}
}