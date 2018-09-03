using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private float sensitivityX = 1.5f;
    private float sensitivityY = 1f;
    private float mouseY;
    private float mouseX;
    GameObject vert;
    private int inverter = -1;

    void Start()
    {
        vert = GameObject.Find("VerticalMovement");
        sensitivityX = PlayerPrefs.GetFloat("sensitivityX");
        sensitivityY = PlayerPrefs.GetFloat("sensitivityY");
        inverter = PlayerPrefs.GetInt("invertMouse");
    }

    void LateUpdate()
    {
        mouseX = Input.GetAxisRaw("Mouse X") * sensitivityX;
        mouseY = Input.GetAxisRaw("Mouse Y") * sensitivityY;
        transform.position = GameObject.Find("Ball").transform.position;
        transform.Rotate(0, mouseX, 0, Space.Self);
        vert.transform.Rotate((inverter * mouseY), 0, 0, Space.Self);
    }

}
