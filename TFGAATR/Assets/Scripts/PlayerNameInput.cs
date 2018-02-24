using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class PlayerNameInput : MonoBehaviour {

	Text playerName;
	float playerTime;
	string playerTimeDisplay;
	public float p1;
	float p2;
	float p3;
	float p4;
	float p5;

	public string p1n;
	string p2n;
	string p3n;
	string p4n;
	string p5n;

	Text first;
	Text second;
	Text third;
	Text fourth;
	Text fifth;

	Text firstName;
	Text secondName;
	Text thirdName;
	Text fourthName;
	Text fifthName;

	bool error;

	GameObject errorMessage;
	GameObject leaderBoardScores;
	GameObject nameInput;

	GameObject inputField;
	GameObject nameOk;
	GameObject errorOk;
	GameObject mainMenu;

	EventSystem es;

	bool iFA;


	void Start () 
	{
		es = GameObject.Find("EventSystem").GetComponent<EventSystem>();
		nameInput = GameObject.Find("NameInput");
		iFA = true;
		errorMessage = GameObject.Find("Error");
		leaderBoardScores = GameObject.Find("LeaderBoard");

		inputField = GameObject.Find("InputField");
		nameOk = GameObject.Find("nameOk");
		errorOk = GameObject.Find("errorOk");
		mainMenu = GameObject.Find("Main Menu");

		FindScoreText();
		leaderBoardScores.SetActive(false);
		errorMessage.SetActive (false);
		if (TimerScript.startToLeader)
		{
			nameInput.SetActive(false);
			iFA = false;
			SetScores();
			leaderBoardScores.SetActive(true);
			TimerScript.startToLeader = false;
		}
		es.firstSelectedGameObject = inputField;
	}

	void Update ()
	{
		if (es.currentSelectedGameObject == inputField);
		{
			if (Input.GetKey(KeyCode.JoystickButton0))
			{
				LeaderBoardSet();
			}
		}
	}

	public void GetPlayerName ()
	{
		playerName = GameObject.Find("PlayerName").GetComponent<Text>();
		EmptyCheck();
		if(!error)
		{
			LinkPlayerTimesWithName();
		}


	}

	public void LinkPlayerTimesWithName ()
	{
		playerTime = TimerScript.playTimer;
		p1 = PlayerPrefs.GetFloat ("P1");
		p2 = PlayerPrefs.GetFloat ("P2");
		p3 = PlayerPrefs.GetFloat ("P3");
		p4 = PlayerPrefs.GetFloat ("P4");
		p5 = PlayerPrefs.GetFloat ("P5");

		p1n = PlayerPrefs.GetString ("P1N");
		p2n = PlayerPrefs.GetString ("P2N");
		p3n = PlayerPrefs.GetString ("P3N");
		p4n = PlayerPrefs.GetString ("P4N");
		p5n = PlayerPrefs.GetString ("P5N");

		if (playerTime < p1 || p1 == 0)
		{
			PlayerPrefs.SetFloat ("P1", playerTime);
			PlayerPrefs.SetFloat ("P2", p1);
			PlayerPrefs.SetFloat ("P3", p2);
			PlayerPrefs.SetFloat ("P4", p3);
			PlayerPrefs.SetFloat ("P5", p4);

			PlayerPrefs.SetString ("P1N", playerName.text);
			PlayerPrefs.SetString ("P2N", p1n);
			PlayerPrefs.SetString ("P3N", p2n);
			PlayerPrefs.SetString ("P4N", p3n);
			PlayerPrefs.SetString ("P5N", p4n);


		}
		else if (playerTime > p1 && playerTime < p2 || p2 == 0)
		{
			PlayerPrefs.SetFloat ("P2", playerTime);
			PlayerPrefs.SetFloat ("P3", p2);
			PlayerPrefs.SetFloat ("P4", p3);
			PlayerPrefs.SetFloat ("P5", p4);

			PlayerPrefs.SetString ("P2N", playerName.text);
			PlayerPrefs.SetString ("P3N", p2n);
			PlayerPrefs.SetString ("P4N", p3n);
			PlayerPrefs.SetString ("P5N", p4n);
		}
		else if (playerTime > p2 && playerTime < p3 || p3 == 0)
		{
			PlayerPrefs.SetFloat ("P3", playerTime);
			PlayerPrefs.SetFloat ("P4", p3);
			PlayerPrefs.SetFloat ("P5", p4);

			PlayerPrefs.SetString ("P3N", playerName.text);
			PlayerPrefs.SetString ("P4N", p3n);
			PlayerPrefs.SetString ("P5N", p4n);
		}
		else if (playerTime > p3 && playerTime < p4 || p4 == 0)
		{
			PlayerPrefs.SetFloat ("P4", playerTime);
			PlayerPrefs.SetFloat ("P5", p4);

			PlayerPrefs.SetString ("P4N", playerName.text);
			PlayerPrefs.SetString ("P5N", p4n);
		}
		else if (playerTime > p4 && playerTime < p5 || p5 == 0)
		{
			PlayerPrefs.SetFloat ("P5", playerTime);

			PlayerPrefs.SetString ("P5N", playerName.text);
		}
	}

	public void LeaderBoardSet ()
	{
		GetPlayerName ();
		if (error)
		{
			nameInput.SetActive (false);
			errorMessage.SetActive(true);
			es.SetSelectedGameObject (errorOk);
			iFA = false;
		}
		else
		{
			nameInput.SetActive(false);
			SetScores();
			leaderBoardScores.SetActive(true);
			es.SetSelectedGameObject(mainMenu);
			iFA = false;
		}
	}

	public void CloseError ()
	{
		errorMessage.SetActive (false);
		nameInput.SetActive (true);
		es.SetSelectedGameObject(inputField);
		iFA = true;
	}

	void EmptyCheck ()
	{
		if (playerName.text.Contains("a") || playerName.text.Contains("b") || playerName.text.Contains("c") || playerName.text.Contains("d") || playerName.text.Contains("e") ||playerName.text.Contains("f") || playerName.text.Contains("g") || playerName.text.Contains("h") || playerName.text.Contains("i") || playerName.text.Contains("j") || playerName.text.Contains("k") || playerName.text.Contains("l") || playerName.text.Contains("m") || playerName.text.Contains("n") || playerName.text.Contains("o") || playerName.text.Contains("p") || playerName.text.Contains("q") || playerName.text.Contains("r") || playerName.text.Contains("s") || playerName.text.Contains("t") || playerName.text.Contains("u") || playerName.text.Contains("v") || playerName.text.Contains("w") || playerName.text.Contains("x") || playerName.text.Contains("y") || playerName.text.Contains("z") ||playerName.text.Contains("A") || playerName.text.Contains("B") || playerName.text.Contains("C") || playerName.text.Contains("D") || playerName.text.Contains("E") ||playerName.text.Contains("F") || playerName.text.Contains("G") || playerName.text.Contains("H") || playerName.text.Contains("I") || playerName.text.Contains("J") || playerName.text.Contains("K") || playerName.text.Contains("L") || playerName.text.Contains("M") || playerName.text.Contains("N") || playerName.text.Contains("O") || playerName.text.Contains("P") || playerName.text.Contains("Q") || playerName.text.Contains("R") || playerName.text.Contains("S") || playerName.text.Contains("T") || playerName.text.Contains("U") || playerName.text.Contains("V") || playerName.text.Contains("W") || playerName.text.Contains("X") || playerName.text.Contains("Y") || playerName.text.Contains("Z"))
		{
			error = false;
		}
		else
		{
			error = true;
		}
	}

	void FindScoreText ()
	{
		first = GameObject.Find("S1").GetComponent<Text>();
		second = GameObject.Find("S2").GetComponent<Text>();
		third = GameObject.Find("S3").GetComponent<Text>();
		fourth = GameObject.Find("S4").GetComponent<Text>();
		fifth = GameObject.Find("S5").GetComponent<Text>();

		firstName = GameObject.Find("N1").GetComponent<Text>();
		secondName = GameObject.Find("N2").GetComponent<Text>();
		thirdName = GameObject.Find("N3").GetComponent<Text>();
		fourthName = GameObject.Find("N4").GetComponent<Text>();
		fifthName = GameObject.Find("N5").GetComponent<Text>();
	}

	void SetScores ()
	{
		float s1 = PlayerPrefs.GetFloat("P1");
		float s2 = PlayerPrefs.GetFloat("P2");
		float s3 = PlayerPrefs.GetFloat("P3");
		float s4 = PlayerPrefs.GetFloat("P4");
		float s5 = PlayerPrefs.GetFloat("P5");

		float s1m = Mathf.Floor(s1/ 60);
		float s2m = Mathf.Floor(s2 / 60);
		float s3m = Mathf.Floor(s3 / 60);
		float s4m = Mathf.Floor(s4 / 60);
		float s5m = Mathf.Floor(s5 / 60);

		float s1s = (s1 % 60);
		float s2s = (s2 % 60);
		float s3s = (s3 % 60);
		float s4s = (s4 % 60);
		float s5s = (s5 % 60);

		float s1ms = ((s1 * 10) % 10);
		float s2ms = ((s2 * 10) % 10);
		float s3ms = ((s3 * 10) % 10);
		float s4ms = ((s4 * 10) % 10);
		float s5ms = ((s5 * 10) % 10);




		firstName.text = PlayerPrefs.GetString("P1N");
		secondName.text = PlayerPrefs.GetString("P2N");
		thirdName.text = PlayerPrefs.GetString("P3N");
		fourthName.text = PlayerPrefs.GetString("P4N");
		fifthName.text = PlayerPrefs.GetString("P5N");


		first.text = s1m.ToString("00") + ":" + s1s.ToString("00") + "." + s1ms.ToString("00");

		second.text = s2m.ToString("00") + ":" + s2s.ToString("00") + "." + s2ms.ToString("00");

		third.text = s3m.ToString("00") + ":" + s3s.ToString("00") + "." + s3ms.ToString("00");

		fourth.text = s4m.ToString("00") + ":" + s4s.ToString("00") + "." + s4ms.ToString("00");

		fifth.text = s5m.ToString("00") + ":" + s5s.ToString("00") + "." + s5ms.ToString("00");


	}
	
}
