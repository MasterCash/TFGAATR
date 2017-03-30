using UnityEngine;
using System.Collections;

//script to control when level four becomes active

public class LevelSelectController : MonoBehaviour {

    GameObject lvl1, lvl2, lvl3, bridge;
    private bool one, two, three, ready;

    private void Start()
    {
        lvl1 = GameObject.Find("LVL1");
        lvl2 = GameObject.Find("LVL2");
        lvl3 = GameObject.Find("LVL3");
        bridge = GameObject.Find("Bridge");

        one = PlayerPrefs.HasKey("LVL1") ? PlayerPrefs.GetInt("LVL1").Equals(1) : false;
        two = PlayerPrefs.HasKey("LVL2") ? PlayerPrefs.GetInt("LVL2").Equals(1) : false;
        three = PlayerPrefs.HasKey("LVL3") ? PlayerPrefs.GetInt("LVL3").Equals(1) : false;
        ready = (one && two && three) ? true : false;
        isOneComplete();
        isTwoComplete();
        isThreeComplete();
    }

    private void Update()
    {
        isFourthLevel();
    }

    void isOneComplete()
    {
        if (one) lvl1.SetActive(false);
        else lvl1.SetActive(true);
    }

    void isTwoComplete()
    {
        if (two) lvl2.SetActive(false);
        else lvl2.SetActive(true);
    }

    void isThreeComplete()
    {
        if (three) lvl3.SetActive(false);
        else lvl3.SetActive(true);
    }

    void isFourthLevel()
    {
        if (ready) bridge.SetActive(true);
        else bridge.SetActive(false);
    }
}
