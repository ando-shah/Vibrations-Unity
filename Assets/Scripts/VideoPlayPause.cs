using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class VideoPlayPause : MonoBehaviour {

	public Cardboard cd;
	public MediaPlayerCtrl player;
	public Slider videoPosition;
	public float shot1StartVal;
	public float shot2StartVal;
	public float[] startTimecodes;


	private int videoDuration, currentDuration; //in ms
	private bool shotsDone;
	private int shotCounter;

	void Start()
	{
		//Debug for cardboard less testing
		Cardboard.SDK.TapIsTrigger = true;
		currentDuration = player.GetDuration ();
		//cd = gameObject.GetComponent<Cardboard> ();

		//startTimecodes  = new float[startTimecodes.Length]; //does not need to be initialized, unity seems to do it under the hood for a public one
		shotsDone = false;


		Debug.Log ("TimeCodes for Shots: ");
		for (int i=0; i < startTimecodes.Length; i++) {
			Debug.Log (" >> " + startTimecodes [i]);
		}

		shotCounter = 1; //skip the first one
	}


	void Toggle()
	{
		//player.Toggle (); 
	}

	void Update()
	{
		//videoPosition.value = (player.GetSeekPosition () / player.GetDuration ()) * 1000 * Time.deltaTime;
		//Text.value
		//videoPosition.value = player.GetSeekPosition() * /23000 1000;

		//Debug.Log ("Current position = " + player.GetSeekPosition () + "Full Duration = " + player.GetDuration ());
		//videoPosition.value = 50;

		/*if (player.GetSeekPosition () >= 10000 && scene1Done == false) {
			scene1Done = true;
			cd.Recenter();
		}*/

		//if (player.GetSeekPosition () >= (int)(startTimecodes [shotCounter] * 1000.00) && shotDone [shotCounter] == false) 
		if (player.GetSeekPosition () >= (int)(startTimecodes [shotCounter] * 1000.00) && shotsDone == false) 
		{ 
				
			Cardboard.SDK.Recenter ();

			Debug.Log ("Recenter for Shot #" + shotCounter + " done");

			if(shotCounter == (startTimecodes.Length - 1))
				shotsDone = true;
			else
				shotCounter++;

		}
	

	}


}
