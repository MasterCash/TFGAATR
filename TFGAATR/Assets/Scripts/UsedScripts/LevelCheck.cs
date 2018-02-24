using UnityEngine;
using System.Collections;

public class LevelCheck : MonoBehaviour
{
	
	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.tag == "Player")
		{
		    switch(gameObject.scene.name)
            {
                case "Level 1":
                    PlayerPrefs.SetInt("LVL1", 1);
                    break;
                case "Level 2":
                    PlayerPrefs.SetInt("LVL2", 1);
                    break;
                case "Level 3":
                    PlayerPrefs.SetInt("LVL3", 1);
                    break;
                case "Level 4":
                    PlayerPrefs.SetInt("CanBowl", 1);
                    break;
            }   

    		PlayerPrefs.Save ();
		}
	}
}
