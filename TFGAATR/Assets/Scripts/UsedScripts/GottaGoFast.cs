using UnityEngine;
using System.Collections;

public class GottaGoFast : MonoBehaviour
{
    public enum Direction { current, up, down, right, left, forward, back };
    public Direction currentDir;

    public int speed;
	private GameObject player;
	private Rigidbody rb;
    private Vector3 direction;

//original speed boost code used as a refrence 
	void Start () 
	{
        player = GameObject.Find("Ball");
		rb = player.GetComponent<Rigidbody>();

        switch(currentDir)
        {
            case Direction.current:
                direction = Vector3.zero;
                speed = 100;
                break;
            case Direction.up:
                direction = new Vector3(0, 18, 0);
                speed = 1;
                break;
            case Direction.down:
                direction = new Vector3(0, -3768, 0);
                speed = 1;
                break;
            case Direction.right:
                direction = new Vector3(3768, 0, 0);
                speed = 1;
                break;
            case Direction.left:
                direction = new Vector3(-3768, 0, 0);
                speed = 1;
                break;
            case Direction.forward:
                direction = new Vector3(0, 0, 3768);
                speed = 1;
                break;
            case Direction.back:
                direction = new Vector3(0, 0, -3768);
                speed = 1;
                break;


        }
	}

	void OnTriggerEnter (Collider col)
	{
		rb.AddForce ((transform.position + direction) * speed, ForceMode.Acceleration);
	
	}

}
