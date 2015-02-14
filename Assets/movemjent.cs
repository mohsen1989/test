using UnityEngine;
using System.Collections;

public class movemjent : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.A))
			transform.localScale = new Vector3 (10, 10, 10);
		if (Input.GetKey(KeyCode.D))
			transform.localScale = new Vector3 (1, 1, 1);	
	
	}
}
