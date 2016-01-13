using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

/// <summary>
/// The Player class.
/// </summary>
public class Player : MonoBehaviour 
{
	void Update()
	{
		Debug.Log ("H: " + CrossPlatformInputManager.GetAxis ("Horizontal"));		
		Debug.Log ("V: " + CrossPlatformInputManager.GetAxis ("Vertical"));		
	}
}
