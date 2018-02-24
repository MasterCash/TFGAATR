using UnityEngine;
using System.Collections;

public class isPinUp : MonoBehaviour {

    GameObject lanereset;
    PinVar pinvar;

    // Use this for initialization
  void OnTriggerStay (Collider col)
    {
        if (col.GetComponent<PinVar>() != null)
        {
            pinvar = col.GetComponent<PinVar>();
            pinvar.isUp = true;
        }
    }
  void OnTriggerExit (Collider col)
    {
        if (col.GetComponent<PinVar>() != null)
        {
            pinvar = col.GetComponent<PinVar>();
            pinvar.isUp = false;
        }
    }
	

}
