using UnityEngine;
using System.Collections;

//script to control when level four becomes active

public class LevelSelectController : MonoBehaviour {

    GameObject lvl1, lvl2, lvl3, bridge;
    private bool one, two, three, ready;

    private void Start()
    {
        lvl1 = GameObject.Find("LVL1");
        lvl2 = GameObject.Find("LVL2");
        lvl3 = GameObject.Find("LVL3");
        bridge = GameObject.Find("Bridge");

        one = PlayerPrefs.HasKey("LVL1") ? PlayerPrefs.GetInt("LVL1").Equals(1) : false;
        two = PlayerPrefs.HasKey("LVL2") ? PlayerPrefs.GetInt("LVL2").Equals(1) : false;
        three = PlayerPrefs.HasKey("LVL3") ? PlayerPrefs.GetInt("LVL3").Equals(1) : false;
        ready = (one && two && three) ? true : false;
        isOneComplete();
        isTwoComplete();
        isThreeComplete();
    }

    private void Update()
    {
        isFourthLevel();
    }

    void isOneComplete()
    {
        if (one) lvl1.SetActive(false);
        else lvl1.SetActive(true);
    }

    void isTwoComplete()
    {
        if (two) lvl2.SetActive(false);
        else lvl2.SetActive(true);
    }

    void isThreeComplete()
    {
        if (three) lvl3.SetActive(false);
        else lvl3.SetActive(true);
    }

    void isFourthLevel()
    {
        if (ready) bridge.SetActive(true);
        else bridge.SetActive(false);
    }

    /*
    int oneCheck;
	int twoCheck;
	int threeCheck;
	static bool lvlStart;
	GameObject lvlOne;
	GameObject lvlTwo;
	GameObject lvlThree;
	GameObject bridge;
	GameObject platform;
	bool BA;
	// finds the different gameobjects for each level
	void Start ()
	{
		lvlOne = GameObject.Find ("Level 1");
		lvlTwo = GameObject.Find ("Level 2");
		lvlThree = GameObject.Find ("Level 3");
		bridge = GameObject.Find ("Bridge");
		platform = GameObject.Find ("Platform");
		BA = false;
		//checks to see if game has run yet 
		if (lvlStart == false) 
		{
			//if it hasn't to set player level beaten status to 0
			PlayerPrefs.SetInt("LOC",0);
			PlayerPrefs.SetInt("LTC",0);
			PlayerPrefs.SetInt("LTHC",0);
			lvlStart = true;
		} 
		else if (lvlStart)
		{
			//if it has, check values to see which have been beaten
			oneCheck = PlayerPrefs.GetInt("LOC");
			twoCheck = PlayerPrefs.GetInt("LTC");
			threeCheck = PlayerPrefs.GetInt("LTHC");
		}
	}
	
	void Update () 
	{
		ShouldLvlFourBeRevealed ();
		BridgeEnabled ();
        HideLevels();
	}

	void ShouldLvlFourBeRevealed()
	{
		//checks to see if all levels have been beaten to show fourth level
		if (oneCheck == 1 && twoCheck == 1 && threeCheck == 1) {
			print ("can go on");
			BA = true;
		} else if (Input.GetKey (KeyCode.H)) {
			print ("can go on");
			BA = true;
		}

	}
    void HideLevels()
    {
        if (oneCheck == 1 || Input.GetKey(KeyCode.O) && lvlOne.transform.position.y > 12.5)
        {
            print("Lvl 1 Complete");
            lvlOne.transform.Translate(0, -Time.deltaTime, 0);
        }
    }
	// sets the bridge active status to the bool telling all three levels are beaten
	void BridgeEnabled ()
	{
		bridge.SetActive (BA);
		platform.SetActive (BA);
	}
    */
}
