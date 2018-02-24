using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MusicPlayer : MonoBehaviour {

	GameObject go;
	AudioClip musicClip;
	string currentlvl;
	AudioSource musicSource;
	Toggle isMute;

	void Start ()
	{
		go = GameObject.Find("Music Manager");
		musicSource = go.GetComponent<AudioSource>();
	}

    private void Update()
    {
        
        LevelNameCheck();
        MusicStart();   
    }

    void LevelNameCheck ()
	{
        currentlvl = SceneManager.GetActiveScene().name;
        switch (currentlvl)
		{
		case "Level Select":
			musicClip = GameObject.Find("Grandpa").GetComponent<AudioSource>().clip;
			break;
		case "Level 1":
			musicClip = GameObject.Find("TGA").GetComponent<AudioSource>().clip;
			break;
		case "Level 2":
			musicClip = GameObject.Find("TD").GetComponent<AudioSource>().clip;
			break;
		case "Level 3":
			musicClip = GameObject.Find("SW").GetComponent<AudioSource>().clip;
			break;
		case "Level 4":
			musicClip = GameObject.Find("PVTW").GetComponent<AudioSource>().clip;
			break;
		case "Bowling":
			musicClip = GameObject.Find("IIHAC").GetComponent<AudioSource>().clip;
			break;
		case "LeaderBoard":
			musicClip = GameObject.Find("Root").GetComponent<AudioSource>().clip;
			break;
		case "SplashScreen":
			musicClip = GameObject.Find("SS").GetComponent<AudioSource>().clip;
			break;
		case "Start Menu":
			musicClip = GameObject.Find("SFA").GetComponent<AudioSource>().clip;
			break;
		default:
			break;
		}
	}

	void MusicStart ()
	{
		if(musicClip != musicSource.clip)
		{
            musicSource.Stop();
            musicSource.clip = musicClip;
            musicSource.Play();
		}
	}

    public void ChangeVolume(float x) { musicSource.volume = x; }
    public void MuteVolume(bool x) { musicSource.mute = x; }
}
