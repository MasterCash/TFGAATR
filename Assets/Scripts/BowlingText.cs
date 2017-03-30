using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BowlingText : MonoBehaviour 
{

	Text bowlingText;
	static bool hasStarted;
	bool secondTime;
	bool messagedshown;


	void Start()
	{
		//start displaying the start text for the bowling level
		bowlingText = GameObject.Find("Text").GetComponent<Text> ();
		if (!hasStarted)
		{
			bowlingText.text = "";
			hasStarted = true;
			secondTime = false;
		}
		if (hasStarted)
		{
			secondTime = true;
			messagedshown = false;
		}
	}

	void Update ()
	{
		StartCoroutine(SetBowlingText());
	}

	//desplays the text then gets rid of it
	IEnumerator SetBowlingText ()
	{
		if (secondTime && !messagedshown)
		{

			bowlingText.text = "Press Escape To Return To Menu";
			yield return new WaitForSeconds (10f);
			bowlingText.text = "";
			messagedshown = true;
		}
	}
}
