using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class VideoPlayPause : MonoBehaviour {

	public Cardboard cd;
	public MediaPlayerCtrl Player;
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
		currentDuration = Player.GetDuration ();
		//cd = gameObject.GetComponent<Cardboard> ();

		//startTimecodes  = new float[startTimecodes.Length]; //does not need to be initialized, unity seems to do it under the hood for a public one
		shotsDone = false;


		Debug.Log ("TimeCodes for Shots: ");
		for (int i=0; i < startTimecodes.Length; i++) {
			Debug.Log (" >> " + startTimecodes [i]);
		}

		shotCounter = 1; //skip the first one


		Cardboard.SDK.TapIsTrigger = true;



	}


	void Toggle()
	{
		//player.Toggle (); 
	}

	void Update()
	{
		//videoPosition.value = (Player.GetSeekPosition () / Player.GetDuration ()) * 1000 * Time.deltaTime;
		if (Player.GetSeekPosition () >= (int)(startTimecodes [shotCounter] * 1000.00) && shotsDone == false) 
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
