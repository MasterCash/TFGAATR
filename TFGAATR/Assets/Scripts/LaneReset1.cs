using UnityEngine;
using System.Collections;

public class LaneReset1 : MonoBehaviour {

	LaneReset lr;
	BowlingPinControl bpc;

	bool runonce;

	void 
        Awake ()
	{
		lr = GameObject.Find("Bowling Controller").GetComponent<LaneReset>();
		bpc = GameObject.Find("Bowling Controller").GetComponent<BowlingPinControl>();
	}

	void OnTriggerEnter (Collider col)
	{
		if (col.tag == "Player")
		{
			if (!runonce)
			{
				StartCoroutine(lr.TPLaneOne());
				runonce = true;
			}
			else
			{
				StartCoroutine(lr.TPLaneTwo ());
			}
		}

	}
}
