using UnityEngine.UI;
using UnityEngine;

public class VolumeControl : MonoBehaviour
{
    public Slider vol;
    public Toggle mute;
    public MusicPlayer music;
	// Use this for initialization
	void Start ()
    {
        vol = GameObject.Find("VolumeSlider").GetComponent<Slider>();
        mute = GameObject.Find("MuteButton").GetComponent<Toggle>();
        music = GameObject.Find("Music Manager").GetComponent<MusicPlayer>();

        if (PlayerPrefs.HasKey("Volume"))
            vol.value = PlayerPrefs.GetFloat("Volume");
        if (PlayerPrefs.HasKey("Mute"))
            mute.isOn = PlayerPrefs.GetInt("Mute") == 1 ? true : false;
    }

	// Update is called once per frame
	void Update ()
    {
        music.ChangeVolume(vol.value);
        music.MuteVolume(mute.isOn);
        PlayerPrefs.SetFloat("Volume", vol.value);
        PlayerPrefs.SetInt("Mute", mute.isOn ? 1 : 0);
        PlayerPrefs.Save();
	}

    public void UpdateVolume()
    {
        if(vol == null)
            vol = GameObject.Find("VolumeSlider").GetComponent<Slider>();
        if (mute == null)
            mute = GameObject.Find("MuteButton").GetComponent<Toggle>();
        if (music == null)
            music = GameObject.Find("Music Manager").GetComponent<MusicPlayer>();

        if (PlayerPrefs.HasKey("Volume"))
            vol.value = PlayerPrefs.GetFloat("Volume");
        if (PlayerPrefs.HasKey("Mute"))
            mute.isOn = PlayerPrefs.GetInt("Mute") == 1 ? true : false;

        music.ChangeVolume(vol.value);
        music.MuteVolume(mute.isOn);
    }


}
