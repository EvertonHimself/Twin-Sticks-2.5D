using UnityEngine;
using System.Collections;

/// <summary>
/// The Camera Pan class.
/// </summary>
public class CameraPan : MonoBehaviour 
{
	private GameObject player;

	void Start()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	void Update()
	{
		print ("RHoriz " + Input.GetAxis ("RHoriz"));
		print ("RVert " + Input.GetAxis ("RVert"));
	}

	void LateUpdate()
	{
		transform.LookAt (player.transform);
	}
}
