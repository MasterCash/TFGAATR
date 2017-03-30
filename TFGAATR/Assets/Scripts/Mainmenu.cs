using UnityEngine;
using System.Collections;

public class Mainmenu : MonoBehaviour {

	void OnCollisionStay(Collision collision) {
		if (collision.rigidbody)
			Application.LoadLevel ("LeaderBoard");
		if(Application.loadedLevelName == "Level 4")
		{
			PlayerPrefs.SetInt("CanBowl", 1);
		}
	}

	public void StartMenu()
	{
		Application.LoadLevel ("Start Menu");
	}
}