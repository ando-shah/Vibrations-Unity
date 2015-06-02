using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour {

	public MediaPlayerCtrl Player;

	void OnEnable()
	{
		Cardboard.SDK.OnTrigger += PlayPause;
	}

	void OnDisable()
	{
		Cardboard.SDK.OnTrigger -= PlayPause;
	}


	void PlayPause()
	{
		if (Player.GetCurrentState () == MediaPlayerCtrl.MEDIAPLAYER_STATE.PAUSED) {
			Player.Play ();
			Debug.Log ("\n Play");
		} else if (Player.GetCurrentState () == MediaPlayerCtrl.MEDIAPLAYER_STATE.PLAYING) {
			Player.Pause ();
			Debug.Log ("\n Pause");
		}

	}



}
