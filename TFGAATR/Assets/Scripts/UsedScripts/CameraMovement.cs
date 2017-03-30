using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float sensitivity = 1.5f;
    public float sensitivityY = 1f;
    public float mouseY;
    public float mouseX;
    GameObject vert;
    public int inverter = -1;
    void Start()
    {
        vert = GameObject.Find("VerticalMovement");
    }

    void LateUpdate()
    {
        mouseX = Input.GetAxisRaw("Mouse X") * sensitivity;
        mouseY = Input.GetAxisRaw("Mouse Y") * sensitivityY;
        transform.position = GameObject.Find("Ball").transform.position;
        transform.Rotate(0, mouseX, 0, Space.Self);
        vert.transform.Rotate((inverter * mouseY), 0, 0, Space.Self);
    }

}
