using UnityEngine;
using System.Collections;

/// <summary>
/// The Replay Class.
/// </summary>
public class Replay : MonoBehaviour 
{
	private const int bufferFrames = 1000;
	private MyKeyFrame[] keyFrames = new MyKeyFrame[bufferFrames];
	private Rigidbody rigidBody;
	private GameManager manager;

	// Use this for initialization
	void Start () 
	{
		rigidBody = GetComponent<Rigidbody>();
//		MyKeyFrame myKeyframe = new MyKeyFrame (Time.deltaTime, transform.position, transform.rotation);
//		Debug.Log ("The time is: " + myKeyframe.frameTime + " The pos is: " + myKeyframe.position + " The rot is: " + myKeyframe.rotation);
		manager = GameObject.FindObjectOfType<GameManager>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (manager.recording == true)
		{
			Record();
		}
		else
		{
			PlayBack();
		}
	}

	/// <summary>
	/// Playback this instance.
	/// </summary>
	void PlayBack()
	{
		rigidBody.isKinematic = true;
		int frame = Time.frameCount % bufferFrames;

		print ("Reading frame " + frame);
		transform.position = keyFrames[frame].position;
		transform.rotation = keyFrames[frame].rotation;
	}

	/// <summary>
	/// Record this instance.
	/// </summary>
	void Record ()
	{
		rigidBody.isKinematic = false;
		int frame = Time.frameCount % bufferFrames;
		float time = Time.time;
		print ("Writing frame " + frame);
		keyFrames [frame] = new MyKeyFrame (time, transform.position, transform.rotation);
	}
}

/// <summary>
/// A class that represent a custom keyframe.
/// </summary>
/// <remarks>
/// Can also be used as 'struct', because it is only used to store data (value type)
/// </remarks>
//public class MyKeyFrame
public struct MyKeyFrame
{
	public float frameTime;
	public Vector3 position;
	public Quaternion rotation;

	// Check: constructors.
	public MyKeyFrame (float time, Vector3 pos, Quaternion rot)
	{
		// Those will be accessible only by the scope of this method.
//		float thisTime = time;
//		Vector3 thisPosition = pos;
//		Vector3 thisRotation = rot;

		frameTime = time;
		position = pos;
		rotation = rot;

//		Debug.Log ("The time is: " + frameTime + " The pos is: " + position + " The rot is: " + rotation);
	}
}