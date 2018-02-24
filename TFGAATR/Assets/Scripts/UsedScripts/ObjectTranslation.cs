using UnityEngine;
using System.Collections;

public class ObjectTranslation : MonoBehaviour
{

	public GameObject Target;
    public float speed = 1.0f;
    public float moveTime = 3.0f;
    private Vector3 pointB;

	IEnumerator Start()
    {
		Vector3 pointA = transform.position;
        pointB = Target.transform.position;
		while(true)
		{
			yield return StartCoroutine (MoveObject (transform, pointA, pointB, moveTime));
			yield return StartCoroutine(MoveObject (transform, pointB, pointA, moveTime));
		}
	}

	IEnumerator MoveObject (Transform thisTransform, Vector3 startPos, Vector3 endPos, float time)
	{
		float i = 0.0f;
		float rate = speed/time;

		while(i < 1.0f)
		{
			i += Time.deltaTime * rate;
			thisTransform.position = Vector3.Lerp(startPos, endPos, i);
			yield return null;
		}
	}
}