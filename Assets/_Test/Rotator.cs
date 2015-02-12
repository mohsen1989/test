using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour
{
	public float duration = 1f;
	public float Angle = 30f;
	float start_time=0;
	// Use this for initialization
	void Start ()
	{
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(start_time+duration<Time.time)
		{
			start_time = Time.time;
			RotateMe();
		}
	}

	void RotateMe()
	{
		transform.Rotate (Vector3.up, Angle);
	}
}
