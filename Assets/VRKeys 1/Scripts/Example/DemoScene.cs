using UnityEngine;
using System;
using System.Text.RegularExpressions;
using System.Collections;

namespace VRKeys {

	public class DemoScene : MonoBehaviour {


		public Keyboard keyboard;

		private Regex emailValidator = new Regex (@"^((([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+(\.([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+)*)|((\x22)((((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(([\x01-\x08\x0b\x0c\x0e-\x1f\x7f]|\x21|[\x23-\x5b]|[\x5d-\x7e]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(\\([\x01-\x09\x0b\x0c\x0d-\x7f]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]))))*(((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(\x22)))@((([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.?$", RegexOptions.IgnoreCase);

		private void OnEnable () {

			GameObject camera = new GameObject ("Main Camera");
			Camera cam = camera.AddComponent<Camera> ();
            
			cam.nearClipPlane = 0.1f;
            camera.transform.position = new Vector3(3f, 0, 0);
            camera.AddComponent<AudioListener> ();

            cam.backgroundColor = new Color(0,0,0);


			Canvas canvas = keyboard.canvas.GetComponent<Canvas> ();
			canvas.worldCamera = cam;

			keyboard.Enable ();
			keyboard.SetPlaceholderMessage ("Please enter your email address");

			keyboard.OnUpdate.AddListener (HandleUpdate);
			keyboard.OnSubmit.AddListener (HandleSubmit);
			keyboard.OnCancel.AddListener (HandleCancel);
		}

		private void OnDisable () {
			keyboard.OnUpdate.RemoveListener (HandleUpdate);
			keyboard.OnSubmit.RemoveListener (HandleSubmit);
			keyboard.OnCancel.RemoveListener (HandleCancel);

			keyboard.Disable ();
		}

		private void Update () {
			if (Input.GetKeyDown (KeyCode.Space)) {
				if (keyboard.disabled) {
					keyboard.Enable ();
				} else {
					keyboard.Disable ();
				}
			}

			if (keyboard.disabled) {
				return;
			}

			if (Input.GetKeyDown (KeyCode.Q)) {
				keyboard.SetLayout (KeyboardLayout.Qwerty);
			} else if (Input.GetKeyDown (KeyCode.F)) {
				keyboard.SetLayout (KeyboardLayout.French);
			} else if (Input.GetKeyDown (KeyCode.D)) {
				keyboard.SetLayout (KeyboardLayout.Dvorak);
			}
		}

		/// <summary>
		/// Hide the validation message on update. Connect this to OnUpdate.
		/// </summary>
		public void HandleUpdate (string text) {
			keyboard.HideValidationMessage ();
		}

		/// <summary>
		/// Validate the email and simulate a form submission. Connect this to OnSubmit.
		/// </summary>
		public void HandleSubmit (string text) {
			keyboard.DisableInput ();

			if (!ValidateEmail (text)) {
				keyboard.ShowValidationMessage ("Please enter a valid email address");
				keyboard.EnableInput ();
				return;
			}

			StartCoroutine (SubmitEmail (text));
		}

		public void HandleCancel () {
			Debug.Log ("Cancelled keyboard input!");
		}

		/// <summary>
		/// Pretend to submit the email before resetting.
		/// </summary>
		private IEnumerator SubmitEmail (string email) {
			keyboard.ShowInfoMessage ("Sending lots of spam, please wait... ;)");

			yield return new WaitForSeconds (2f);

            keyboard.ShowSuccessMessage("Welcome \n " + email);


			yield return new WaitForSeconds (2f);

			//keyboard.HideSuccessMessage ();
			keyboard.SetText ("");
			keyboard.EnableInput ();
		}

		private bool ValidateEmail (string text) {
			if (!emailValidator.IsMatch (text)) {
				return false;
			}
			return true;
		}
	}
}