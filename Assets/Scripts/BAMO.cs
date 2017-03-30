using UnityEngine;
using System.Collections;

public class BAMO : MonoBehaviour 
{
	//This code is to control the player when they get close to the pins in the bowling level.
	GameObject player;
	public PlayerMovement mvmnt;
	Rigidbody rb;
	bool IN; 
	//static float moveHorizontal;
	//static float moveVertical;
	//static Vector3 movement;
	float speed;
	Vector3 playerVelocity;
	public static int pincount;

	void Awake ()
	{
		//locating player and grabing the rigidbody
		// also setting the speed and movement
		player = GameObject.Find("Sphere");
		rb = player.GetComponent<Rigidbody>();
		mvmnt = player.GetComponent<PlayerMovement>();
		speed = mvmnt.cameraForce.x;
		pincount = 0;
	}

	void FixedUpdate ()
	{
		if (IN)
		{
			// takes current ball velocity and sets it to a varible
			rb.velocity = playerVelocity;
		}
	}

	void OnTriggerEnter (Collider col)
	{
		//physics engine checks to see if player is in the pin's hitbox
		if(col.tag == "Player")
		{
			//stores player velocity
			playerVelocity = rb.velocity;
			mvmnt.enabled = false;
			IN = true;



		}
	}

	void OnTriggerExit (Collider col)
	{
		//physics engine checks to see if player is out the pin's hitbox
		if(col.tag =="Player")
		{
			rb.velocity = Vector3.zero;
			IN = false;
		}

	}

}
