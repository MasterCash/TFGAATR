using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {

	
	public GameObject target;//the target object
	public float speedMod = 3.0f;//a speed modifier
	private Vector3 point;//the coord to the point where the camera looks at
    private Vector3 axis;
    public enum Axis { up, down, left, right, forward, back }
    public Axis currentAxis;
	
	void Start ()
    {
        //Set up things on the start method
		point = target.transform.position;//get target's coords
        switch(currentAxis)
        {
            case Axis.up:
                axis = Vector3.up;
                break;
            case Axis.down:
                axis = Vector3.down;
                break;
            case Axis.left:
                axis = Vector3.left;
                break;
            case Axis.right:
                axis = Vector3.right;
                break;
            case Axis.forward:
                axis = Vector3.forward;
                break;
            case Axis.back:
                axis = Vector3.back;
                break;
            default:
                axis = Vector3.up;
                break;
        }
	}
	
	void FixedUpdate ()
    {
		transform.RotateAround(point, axis, 20 * Time.deltaTime * speedMod);
	}
}
