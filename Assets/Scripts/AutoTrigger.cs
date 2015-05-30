using UnityEngine;
using System.Collections;

public class AutoTrigger : MonoBehaviour {

	private CardboardHead head;
	private Cardboard cd;
	private float delay = 0.0f;

	// Use this for initialization
	void Start () {
		head = Camera.main.GetComponent<StereoController> ().Head;
		cd = gameObject.GetComponent<Cardboard> ();
	}
	
	// Update is called once per frame
	void Update () {

		RaycastHit hit;
		bool isLookedAt = GetComponent<Collider>().Raycast(head.Gaze, out hit, Mathf.Infinity);

		GetComponent<Renderer>().material.color = isLookedAt ? Color.green : Color.red;

		if (!isLookedAt) 
		{ 
			delay = Time.time + 2.0f; 
		}

		if ((Cardboard.SDK.CardboardTriggered && isLookedAt) || (isLookedAt && Time.time>delay)) 
		{ 
			//cd.ToggleVRMode();
			delay = Time.time + 2.0f;
		}

		cd.Recenter ();

	}
}
