using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

/// <summary>
/// The Game Manager class.
/// </summary>
public class GameManager : MonoBehaviour 
{
	public bool recording = true;

	void Update()
	{
		if (CrossPlatformInputManager.GetButton ("Fire1"))
		{
			recording = false;
		}
		else 
		{
			recording = true;
		}
	}
}
