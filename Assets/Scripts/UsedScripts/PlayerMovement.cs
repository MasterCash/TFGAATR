using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float forceModifier = 10.5f;
    public Vector3 playerVelocity;
    public Camera playerCam;
    public Vector3 inputForce;
    public Vector3 cameraForce;
    public GameObject player;
    private float x, z, speedBoost, jumped;
    private Rigidbody playerRigidbody;
    public bool isGrounded;
    public Vector3 jump;

    void Start()
    {
        player = gameObject;
        Spawn();
        jump = new Vector3(0, 30.0f, 0);

    }

	// Update is called once per frame
	void FixedUpdate ()
    {
        playerRigidbody = player.GetComponent<Rigidbody>();

        x = Input.GetAxis("Horizontal") * forceModifier;
        z = Input.GetAxis("Vertical") * forceModifier;

        speedBoost = Mathf.Abs(Input.GetAxisRaw("SpeedBoost") * 3);
        playerCam = GameObject.Find("MainCamera").GetComponent<Camera>();
        inputForce = new Vector3(x, 0, z);
        inputForce *= speedBoost > 1 ?  speedBoost : 1;
        cameraForce = playerCam.transform.TransformDirection(inputForce);
        cameraForce.y = 0;
         if(Input.GetAxis("Jump") > 0 && isGrounded) 
            playerRigidbody.AddForce(jump * forceModifier);
        playerRigidbody.AddForce(cameraForce, ForceMode.Force);
        playerVelocity = cameraForce;
        
	}

    private void OnCollisionStay(Collision collision)
    {
        isGrounded = (collision.gameObject.tag == "Floor") ? true : false;
    }

    private void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
    }

    public void Spawn()
    {
        player.GetComponentInParent<Transform>().position = GameObject.Find("PlayerSpawn").GetComponent<Transform>().position;
        player.GetComponentInParent<Rigidbody>().velocity = Vector3.zero;
    }
}
