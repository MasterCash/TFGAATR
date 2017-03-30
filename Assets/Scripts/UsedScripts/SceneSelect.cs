using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelect : MonoBehaviour
{
    public enum LVL { LVL1, LVL2, LVL3, LVL4, select };
    private LVL next;

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SetState();
            LoadLevel();
        }
    }

    public void SetState()
    {
        switch (gameObject.name)
        {
            case "LVL1":
                next = LVL.LVL1;
                break;
            case "LVL2":
                next = LVL.LVL2;
                break;
            case "LVL3":
                next = LVL.LVL3;
                break;
            case "LVL4":
                next = LVL.LVL4;
                break;
            case "Select":
                next = LVL.select;
                break;
        }
    }

    public void LoadLevel()
    {
        switch (next)
        {
            case LVL.select:
                SceneManager.LoadScene("Level Select");
                break;
            case LVL.LVL1:
                SceneManager.LoadScene("Level 1");
                break;
            case LVL.LVL2:
                SceneManager.LoadScene("Level 2");
                break;
            case LVL.LVL3:
                SceneManager.LoadScene("Level 3");
                break;
            case LVL.LVL4:
                SceneManager.LoadScene("Level 4");
                break;
        }
    }
}