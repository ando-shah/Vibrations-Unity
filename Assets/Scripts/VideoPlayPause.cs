using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class VideoPlayPause : MonoBehaviour {

	public Cardboard cd;
	public MediaPlayerCtrl player;
	public Slider videoPosition;
	public float shot1StartVal;
	public float shot2StartVal;



	private int videoDuration, currentDuration; //in ms
	private bool shot1Done, shot2Done = false;

	void Start()
	{
		//Debug for cardboard less testing
		Cardboard.SDK.TapIsTrigger = true;
		currentDuration = player.GetDuration ();
		//cd = gameObject.GetComponent<Cardboard> ();

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

		//if (player.GetSeekPosition () >= (int)(shot2StartVal * 1000) && shot1Done == false) 
		if (player.GetSeekPosition () >= 47500 && shot1Done == false) {
			shot1Done = true;
			cd.Recenter();
			Debug.Log("Recenter for Shot2 done");
		}

	}




}
