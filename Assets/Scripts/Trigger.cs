using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Trigger : MonoBehaviour {

	public MediaPlayerCtrl Player;
	//public GameObject HUD;
	private Image img;
	private Color clr;

	void OnEnable()
	{
		Cardboard.SDK.OnTrigger += PlayPause;
	}

	void OnDisable()
	{
		Cardboard.SDK.OnTrigger -= PlayPause;
	}

	void Start()
	{
		//img = HUD.GetComponentsInChildren<Image>["CanvasHUD"] ();
		//img = HUD.GetComponent ("LowerBar") as Image;
		//clr = img.color;
		//HUD.SetActive (false);

	}



	void PlayPause()
	{


		if (Player.GetCurrentState () == MediaPlayerCtrl.MEDIAPLAYER_STATE.PAUSED) {
			Player.Play ();

			//HUD.SetActive(false)	;

			Debug.Log ("\n Play");


		} else if (Player.GetCurrentState () == MediaPlayerCtrl.MEDIAPLAYER_STATE.PLAYING) {
			Player.Pause ();
			//HUD.SetActive(true);

			Debug.Log ("\n Pause");

		}

	}





}
