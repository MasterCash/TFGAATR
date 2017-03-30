using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{
    public enum MenuState { Main, Controls, Settings };
    private MenuState currentState;
    private bool canBowl = false;
    public Slider vol;
    public Button mute;
    public GameObject music;

    GameObject MenuScreen, ControlsScreen, SettingsScreen, bowl;

    private void Start()
    {
        MenuScreen = GameObject.Find("MenuScreen");
        ControlsScreen = GameObject.Find("ControlsScreen");
        SettingsScreen = GameObject.Find("SettingsScreen");
        bowl = GameObject.Find("Bowling");


        currentState = MenuState.Main;

        switch (PlayerPrefs.GetInt("CanBowl"))
        {
            case 1:
                canBowl = true;
                break;
            default:
                canBowl = false;
                break;
        }
        GameObject.Find("Volume").GetComponent<VolumeControl>().UpdateVolume();
    }

    private void Update()
    {
        switch(currentState)
        {
            case MenuState.Main:
                showMain();
                break;
            case MenuState.Controls:
                showControls();
                break;
            case MenuState.Settings:
                showSettings();
                break;
        }
    }

    private void showMain()
    {
        MenuScreen.SetActive(true);
        ControlsScreen.SetActive(false);
        SettingsScreen.SetActive(false);
        if (canBowl) bowl.SetActive(true);
        else bowl.SetActive(false);
           
    }

    private void showControls()
    {
        MenuScreen.SetActive(false);
        ControlsScreen.SetActive(true);
        SettingsScreen.SetActive(false);
    }

    private void showSettings()
    {
        MenuScreen.SetActive(false);
        ControlsScreen.SetActive(false);
        SettingsScreen.SetActive(true);
    }

    public void OnStart() { SceneManager.LoadScene("Level Select"); }

    public void OnExit() { Application.Quit(); }

    public void OnBowling() { SceneManager.LoadScene("Bowling"); }

    public void OnControls() { currentState = MenuState.Controls; }
    
    public void OnSettings() { currentState = MenuState.Settings; }

    public void OnOk() { currentState = MenuState.Main; }

    public void SkinOne ()
	{
		PlayerPrefs.SetInt ("Skin", 1);

	}
	public void SkinTwo ()
	{
		PlayerPrefs.SetInt ("Skin", 2);
	}
	public void SkinThree ()
	{
		PlayerPrefs.SetInt ("Skin", 3);
	}
	public void SkinFour ()
	{
		PlayerPrefs.SetInt ("Skin", 4);
	}
	public void SkinFive ()
	{
		PlayerPrefs.SetInt ("Skin", 5);
	}
	public void SkinSix ()
	{
		PlayerPrefs.SetInt ("Skin", 6);
	}	
}
