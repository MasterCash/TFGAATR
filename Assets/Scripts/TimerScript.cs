using UnityEngine;
using UnityEngine.UI;


public class TimerScript : MonoBehaviour
{

	CursorLockMode lockCursor = CursorLockMode.Locked;
	CursorLockMode unlockCursor = CursorLockMode.None;

	float actualTime;
	static float startTime;
	public static float playTimer;
	Text playerClock;
	static float minutes;
	static float seconds;
	static float fraction;
	static bool hasStarted = true;
	public string playerTime;
	public static bool startToLeader = false;

	// Use this for initialization
	void Start ()
	{
		playerClock = GameObject.Find("TimerClockText").GetComponent<Text>();
	}

	void Awake ()
	{
		if(hasStarted)
		{
			Debug.Log ("Ver. 2.1.1");
			hasStarted = false;
		}
		if (PlayerPrefs.HasKey("FirstRun") == false)
		{
			PlayerPrefs.SetFloat("P1", 180);
			PlayerPrefs.SetFloat("P2", 0);
			PlayerPrefs.SetFloat("P3", 0);
			PlayerPrefs.SetFloat("P4", 0);
			PlayerPrefs.SetFloat("P5", 0);

			PlayerPrefs.SetString("P1N", "Default");
			PlayerPrefs.SetString("P2N", "");
			PlayerPrefs.SetString("P3N", "");
			PlayerPrefs.SetString("P4N", "");
			PlayerPrefs.SetString("P5N", "");



			PlayerPrefs.SetString("FirstRun", "Game Has Run");
			print (PlayerPrefs.GetString("FirstRun"));
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		Timer();
		Escape();
		CursorLockCheck();
        LevelHotKeys();
	}

	void Timer ()
	{
		actualTime = Time.time;
		if(Application.loadedLevelName == "Start Menu")
		{
			startTime = actualTime;
		}
		if( Application.loadedLevelName != "LeaderBoard")
		{
		playTimer = actualTime - startTime;
		minutes = Mathf.Floor(playTimer / 60);
		seconds = (playTimer % 60);
		fraction = (playTimer * 10);
		fraction = (fraction % 10);
		}
		if (playerClock != null)
		{
		playerClock.text = "Your Time: "+ minutes.ToString("00") + ":" + seconds.ToString("00");
		//playerClock.text ="Time: " + playTimer.ToString("F2");
		}
		playerTime =  minutes.ToString("00") + ":" + seconds.ToString("00") + "." + fraction.ToString("00");
	
		if(Application.loadedLevelName == "Start Menu")
		{
			playerClock.text = "";
		}
	}

	public void Escape()
	{
		if(Input.GetKey(KeyCode.Escape) || Input.GetKey(KeyCode.JoystickButton7))
		{
			Application.LoadLevel("Start Menu");
		}
	}

	public void StatReset()
	{
		PlayerPrefs.DeleteAll();
	}

	public void StartLeader()
	{
		startToLeader = true;
		Application.LoadLevel ("LeaderBoard");

	}

	void CursorLockCheck ()
	{
		if (Application.loadedLevelName == "Start Menu" || Application.loadedLevelName == "LeaderBoard")
		{
			Cursor.visible = true;
			Cursor.lockState = unlockCursor;
		}
		else
		{
			Cursor.visible = false;
			Cursor.lockState = lockCursor;
		}
	}
    void LevelHotKeys()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            Application.LoadLevel(3);
        }
        else if (Input.GetKey(KeyCode.Alpha2))
        {
            Application.LoadLevel(4);
        }
        else if (Input.GetKey(KeyCode.Alpha3))
        {
            Application.LoadLevel(5);
        }
        else if (Input.GetKey(KeyCode.Alpha4))
        {
            Application.LoadLevel(6);
        }
    }
}
