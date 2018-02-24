using UnityEngine;
using UnityEngine.UI;

public class PlayerSkin : MonoBehaviour
{
    Renderer rend;

    void Start ()
    {
        rend = GetComponent<Renderer>();

        SkinApply();
    }

    void SkinApply()
    {
        switch (PlayerPrefs.GetInt("Skin"))
        {
            case 1:
                rend.material = Resources.Load("DefaultSkin") as Material;
                break;
            case 2:
                rend.material = Resources.Load("LavaSkin") as Material;
                break;
            case 3:
                rend.material = Resources.Load("RedSkin") as Material;
                break;
            case 4:
                rend.material = Resources.Load("EightBallSkin") as Material;
                break;
            case 5:
                rend.material = Resources.Load("RockSkin") as Material;
                break;
            case 6:
                rend.material = Resources.Load("GarrettSkin") as Material;
                break;
            default:
                rend.material = Resources.Load("DefaultSkin") as Material;
                break;
        }
        Resources.UnloadUnusedAssets();
    }
}
