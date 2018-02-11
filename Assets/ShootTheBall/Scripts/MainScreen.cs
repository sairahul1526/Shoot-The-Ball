using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainScreen : MonoBehaviour {

	public Text txtBest;

	/// <summary>
	/// Raises the enable event.
	/// </summary>
	void OnEnable()
	{
		txtBest.text = "BEST : " + PlayerPrefs.GetInt ("BestScore", 0).ToString("00");
	}

	int start = 0;

	void Update() {
		if (start == 0) {
			if (Input.GetButtonDown("Submit")) {
				InputManager.instance.DisableTouchForDelay ();
				InputManager.instance.AddButtonTouchEffect ();
				GameController.instance.StartGamePlay(gameObject);
				start = 1;
			}
		}
	}

	/// <summary>
	/// Raises the play button pressed event.
	/// </summary>
	public void OnPlayButtonPressed()
	{
		if (Input.GetButtonDown("Submit")) {
			InputManager.instance.DisableTouchForDelay ();
			InputManager.instance.AddButtonTouchEffect ();
			GameController.instance.StartGamePlay(gameObject);
		}
	}

	public void OnReviewButtonPressed()
	{
		if (InputManager.instance.canInput ()) {
			InputManager.instance.DisableTouchForDelay ();
			InputManager.instance.AddButtonTouchEffect ();
			Application.OpenURL(Constants.REVIEW_URL);
		}
	}

}
