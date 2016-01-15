using UnityEngine;
using System.Collections;

/// <summary>
/// Selfie stick.
/// </summary>
public class SelfieStick : MonoBehaviour 
{
	public float panSpeed = 10f;

	private GameObject player;
	private Vector3 armRotation;

	void Start()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
		armRotation = transform.rotation.eulerAngles; // Transforms the rotation from Quaternion to euler angles.
	}

	void Update()
	{
		armRotation.y += Input.GetAxis ("RHoriz") * panSpeed;
		armRotation.x += Input.GetAxis ("RVert") * panSpeed;


		transform.position = player.transform.position;
		transform.rotation = Quaternion.Euler (armRotation); // Transform the euler angles back to Quaternion using the right hand method.
	}
}
