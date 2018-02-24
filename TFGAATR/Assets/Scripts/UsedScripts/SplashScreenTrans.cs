using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class SplashScreenTrans : MonoBehaviour 
{
	Image fadeImage;

	void Awake ()
	{
		fadeImage = GameObject.Find("fadeimg").GetComponent<Image>();
	}

	void Start ()
	{
		StartCoroutine("FadeInOut");
	}

	IEnumerator FadeInOut ()
	{
		fadeImage.CrossFadeAlpha(0f, 3f, false);
		yield return new WaitForSeconds (4);
		fadeImage.CrossFadeAlpha(1f, 3f, false);
		yield return new WaitForSeconds (3);
		SceneManager.LoadScene("Start Menu");
	}
}


