using UnityEngine;
using System.Collections;

public class Tester : MonoBehaviour {

	public GameObject ball;

	public Vector3 velocity;

	public float z = 10;
	public float x = 0;

	void Start()
	{
		velocity = ball.rigidbody.velocity;
	}

	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown (KeyCode.Space)) {
			ball.rigidbody.velocity = new Vector3(x, 0, z);
		}

		velocity = ball.rigidbody.velocity;
	}
}
