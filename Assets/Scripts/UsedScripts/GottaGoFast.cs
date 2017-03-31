using UnityEngine;
using System.Collections;

public class GottaGoFast : MonoBehaviour
{
    public enum Direction { up, down, right, left, forward, back };
    public Direction currentDir;

    public float speed = 10000;
	private GameObject player;
	private Rigidbody rb;
    private Vector3 direction;

//original speed boost code used as a refrence 
	void Start () 
	{
        player = GameObject.Find("Ball");
		rb = player.GetComponent<Rigidbody>();
	}

	void OnTriggerEnter (Collider col)
	{
        StateUpdate();
        rb.velocity = Vector3.zero;
		rb.AddForce (direction * speed);
	
	}

    public void StateUpdate()
    {
        switch (currentDir)
        {
            case Direction.up:
                direction = Vector3.up;
                break;
            case Direction.down:
                direction = Vector3.down;
                break;
            case Direction.right:
                direction = Vector3.right;
                break;
            case Direction.left:
                direction = Vector3.left;
                break;
            case Direction.forward:
                direction = Vector3.forward;
                break;
            case Direction.back:
                direction = Vector3.back;
                break;
        }

    }
}
