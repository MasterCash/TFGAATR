using UnityEngine;
using System.Collections;

public class BowlingPinControl : MonoBehaviour 
{
	//varibles set to the pins
	GameObject pinSet1, pinSet2, pinSet3;
	GameObject s1p, s1p1, s1p2, s1p3, s1p4, s1p5, s1p6, s1p7, s1p8, s1p9;
	GameObject s2p, s2p1, s2p2, s2p3, s2p4, s2p5, s2p6, s2p7, s2p8, s2p9;
	GameObject s3p, s3p1, s3p2, s3p3, s3p4, s3p5, s3p6, s3p7, s3p8, s3p9;
    GameObject lr1, lr2, lr3;
	//varibles to count
	static public int pinCount;
	public static int RunOne;
	static public int runTwo;
	public int lane1Total;
	public static int runThree;
	public static int runFour;
	public int lane2Total;
	public static int runFive;
	public static int runSix;
	public int lane3Total;
	static public int pinCount2;
	static public int pinCount3;
	

	void Awake ()
	{
		// sets my varibles
		pinCount = 0; 
		RunOne = 0; 
		runTwo = 0; 
		runThree = 0; 
		runFour = 0; 
		runFive = 0;
		runSix = 0; 
		pinCount2 = 0;
		pinCount3 = 0;
		pinSet1 = GameObject.Find("Pin Set 1");
		pinSet2 = GameObject.Find("Pin Set 2");
		pinSet3 = GameObject.Find("Pin Set 3");

		s1p = GameObject.Find("Pin Set 1/BowlingPin");
		s1p1 = GameObject.Find("Pin Set 1/BowlingPin 1");
		s1p2 = GameObject.Find("Pin Set 1/BowlingPin 2");
		s1p3 = GameObject.Find("Pin Set 1/BowlingPin 3");
		s1p4 = GameObject.Find("Pin Set 1/BowlingPin 4");
		s1p5 = GameObject.Find("Pin Set 1/BowlingPin 5");
		s1p6 = GameObject.Find("Pin Set 1/BowlingPin 6");
		s1p7 = GameObject.Find("Pin Set 1/BowlingPin 7");
		s1p8 = GameObject.Find("Pin Set 1/BowlingPin 8");
		s1p9 = GameObject.Find("Pin Set 1/BowlingPin 9");

		s2p = GameObject.Find("Pin Set 2/BowlingPin");
		s2p1 = GameObject.Find("Pin Set 2/BowlingPin 1");
		s2p2 = GameObject.Find("Pin Set 2/BowlingPin 2");
		s2p3 = GameObject.Find("Pin Set 2/BowlingPin 3");
		s2p4 = GameObject.Find("Pin Set 2/BowlingPin 4");
		s2p5 = GameObject.Find("Pin Set 2/BowlingPin 5");
		s2p6 = GameObject.Find("Pin Set 2/BowlingPin 6");
		s2p7 = GameObject.Find("Pin Set 2/BowlingPin 7");
		s2p8 = GameObject.Find("Pin Set 2/BowlingPin 8");
		s2p9 = GameObject.Find("Pin Set 2/BowlingPin 9");

		s3p = GameObject.Find("Pin Set 3/BowlingPin");
		s3p1 = GameObject.Find("Pin Set 3/BowlingPin 1");
		s3p2 = GameObject.Find("Pin Set 3/BowlingPin 2");
		s3p3 = GameObject.Find("Pin Set 3/BowlingPin 3");
		s3p4 = GameObject.Find("Pin Set 3/BowlingPin 4");
		s3p5 = GameObject.Find("Pin Set 3/BowlingPin 5");
		s3p6 = GameObject.Find("Pin Set 3/BowlingPin 6");
		s3p7 = GameObject.Find("Pin Set 3/BowlingPin 7");
		s3p8 = GameObject.Find("Pin Set 3/BowlingPin 8");
		s3p9 = GameObject.Find("Pin Set 3/BowlingPin 9");
        lr1 = GameObject.Find("Test/lane1reset");
        lr2 = GameObject.Find("Test/lane2reset");
        lr3 = GameObject.Find("Test/lane3reset");

    }

    public void PinControl ()
	{
		//Check to see if pins are up
		if(s1p.transform.position.y >= 4.1f)
		{
			s1p.SetActive (false);
			pinCount ++;
		}
	
		if(s1p1.transform.position.y >= 4.1f)
		{
			s1p1.SetActive (false);
			pinCount ++;
		}
		if(s1p2.transform.position.y >= 4.1f)
		{	
			s1p2.SetActive (false);
			pinCount ++;
		}
		if(s1p3.transform.position.y >= 4.1f)
		{
			pinCount ++;
			s1p3.SetActive (false);
		}
		if(s1p4.transform.position.y >= 4.1f)
		{
			pinCount ++;
			s1p4.SetActive (false);
		}
		if(s1p5.transform.position.y >= 4.1f)
		{
			pinCount ++;
			s1p5.SetActive (false);
		}
		if(s1p6.transform.position.y >= 4.1f)
		{
			pinCount ++;
			s1p6.SetActive (false);
		}
		if(s1p7.transform.position.y >= 4.1f)
		{
			pinCount ++;
			s1p7.SetActive (false);
		}
		if(s1p8.transform.position.y >= 4.1f)
		{
			pinCount ++;
			s1p8.SetActive (false);
		}
		if(s1p9.transform.position.y >= 4.1f)
		{
			pinCount ++;
			s1p9.SetActive (false);
		}

		if(s2p.transform.position.y >= 4.1f)
		{
			pinCount2 ++;
			s2p.SetActive (false);
		}
		if(s2p1.transform.position.y >= 4.1f)
		{
			pinCount2 ++;
			s2p1.SetActive (false);
		}
		if(s2p2.transform.position.y >= 4.1f)
		{
			pinCount2 ++;
			s2p2.SetActive (false);
		}
		if(s2p3.transform.position.y >= 4.1f)
		{
			pinCount2 ++;
			s2p3.SetActive (false);
		}
		if(s2p4.transform.position.y >= 4.1f)
		{
			pinCount2 ++;
			s2p4.SetActive (false);
		}
		if(s2p5.transform.position.y >= 4.1f)
		{
			pinCount2 ++;
			s2p5.SetActive (false);
		}
		if(s2p6.transform.position.y >= 4.1f)
		{
			pinCount2 ++;
			s2p6.SetActive (false);
		}
		if(s2p7.transform.position.y >= 4.1f)
		{
			pinCount2 ++;
			s2p7.SetActive (false);
		}
		if(s2p8.transform.position.y >= 4.1f)
		{
			pinCount2 ++;
			s2p8.SetActive (false);
		}
		if(s2p9.transform.position.y >= 4.1f)
		{
			pinCount2 ++;
			s2p9.SetActive  (false);
		}

		if(s3p.transform.position.y >= 4.1f)
		{
			pinCount3 ++;
			s3p.SetActive (false);
		}
		if(s3p1.transform.position.y >= 4.1f)
		{
			pinCount3 ++;
			s3p1.SetActive (false);
		}
		if(s3p2.transform.position.y >= 4.1f)
		{ 
			pinCount3 ++;
			s3p2.SetActive (false);
		}
		if(s3p3.transform.position.y >= 4.1f)
		{
			pinCount3 ++;
			s3p3.SetActive (false);
		}
		if(s3p4.transform.position.y >= 4.1f)
		{
			pinCount3 ++;
			s3p4.SetActive (false);
		}
		if(s3p5.transform.position.y >= 4.1f)
		{
			pinCount3 ++;
			s3p5.SetActive (false);
		}
		if(s3p6.transform.position.y >= 4.1f)
		{
			pinCount3 ++;
			s3p6.SetActive (false);
		}
		if(s3p7.transform.position.y >= 4.1f)
		{
			pinCount3 ++;
			s3p7.SetActive (false);
		}
		if(s3p8.transform.position.y >= 4.1f)
		{
			pinCount3 ++;
			s3p8.SetActive (false);
		}	
		if(s3p9.transform.position.y >= 4.1f)
		{
			pinCount3 ++;
			s3p9.SetActive (false);
		}
	

		//Pin Count control
		if (RunOne == 0)
		{
			RunOne = pinCount;
		}
		else
		{
			runTwo = pinCount - RunOne; 
		}
		pinCount = 0;


		if (runThree == 0)
		{
			runThree = pinCount2;
		}
		else
		{
			runFour = pinCount2 - runThree; 
		}
		pinCount2 = 0;

		if (runFive == 0)
		{
			runFive = pinCount3;
		}
		else
		{
			runSix = pinCount3 - runFive;
		}

		if(GameObject.FindWithTag("Counted") == true)
		{
			GameObject counted;
			counted = GameObject.FindWithTag("Counted");
			counted.tag = "Pin";
			counted.SetActive(false);

		}

		/*print (pinCount);
		print (RunOne);
		print (runTwo);
		print (" ");
		print (pinCount2);
		print (runThree);
		print (runFour);
		print (" ");
		print (pinCount3);
		print (runFive);
		print (runSix);
		print ("end");
*/
	}





}
