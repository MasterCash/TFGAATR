using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LaneReset3 : MonoBehaviour {

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
				StartCoroutine(lr.TPLaneThree ());
				runonce = true;
			}
			else
			{
                SceneManager.SetActiveScene(SceneManager.GetActiveScene());
			}
		}
	}
}

