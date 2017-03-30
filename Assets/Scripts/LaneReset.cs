using UnityEngine;
using System.Collections;

public class LaneReset : MonoBehaviour 
{
	PlayerMovement mvmnt;
	GameObject lane1TP;
	GameObject lane2TP;
	GameObject lane3TP;
	GameObject player;
	Rigidbody rb;

	BowlingPinControl bpc;

	CursorLockMode lockCursor = CursorLockMode.Locked;
	CursorLockMode unlockCursor = CursorLockMode.None;

	public static bool reset;

	bool zeroed;

	void Awake ()
	{
		player = GameObject.Find("Sphere");
		lane1TP = GameObject.Find("TPLane1");
		lane2TP = GameObject.Find("TPLane2");
		lane3TP = GameObject.Find("TPLane3");
		rb = player.GetComponent<Rigidbody>();
		bpc = GameObject.Find("Bowling Controller").GetComponent<BowlingPinControl> ();
		mvmnt = GameObject.Find("Sphere").GetComponent<PlayerMovement> ();
		reset = true;
	}

	public IEnumerator TPLaneOne ()
	{
		zeroed = false;
		player.transform.position = lane1TP.transform.position;
		if(!zeroed)
		{
			rb.useGravity = false;
			rb.velocity = Vector3.zero;
			mvmnt.enabled = false;
			rb.velocity = Vector3.zero;
			yield return new WaitForSeconds (2f);
			rb.velocity = Vector3.zero;
			rb.useGravity = true;
			mvmnt.enabled = true;
			bpc.PinControl ();
			if (BowlingPinControl.RunOne == 10)
			{
				StartCoroutine(TPLaneTwo());
				reset = false;
			
			}
			reset = true;
			zeroed = true;
		}

	}

	public IEnumerator TPLaneTwo ()
	{
		zeroed = false;
		player.transform.position = lane2TP.transform.position;
		if(!zeroed)
		{
			mvmnt.enabled = false;
			rb.useGravity = false;
			rb.velocity = Vector3.zero;
			yield return new WaitForSeconds (2f);
			rb.velocity = Vector3.zero;
			rb.useGravity = true;
			mvmnt.enabled = true;
			bpc.PinControl ();
			if ( BowlingPinControl.runThree == 10)
			{
				StartCoroutine(TPLaneThree());
				reset = false;
			}
			reset = true;
			zeroed = true;
		}
	}
	public IEnumerator TPLaneThree ()
	{
		zeroed = false;
		player.transform.position = lane3TP.transform.position;
		if(!zeroed)
		{
			mvmnt.enabled = false;
			rb.useGravity = false;
			rb.velocity = Vector3.zero;
			yield return new WaitForSeconds (2f);
			rb.velocity = Vector3.zero;
			rb.useGravity = true;
			mvmnt.enabled = true;
			bpc.PinControl ();
			zeroed = true;
			if ( BowlingPinControl.runFive == 10)
			{
				Application.LoadLevel(Application.loadedLevel);
				reset = false;
			}
			reset = true;
			zeroed = true;
		}
	}

	void Update ()
	{
		Escape ();
		CursorLockCheck ();
	}
	public void Escape()
	{
		if(Input.GetKey(KeyCode.Escape) || Input.GetKey(KeyCode.Joystick1Button7))
		{
			Application.LoadLevel("Start Menu");
		}
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
}
