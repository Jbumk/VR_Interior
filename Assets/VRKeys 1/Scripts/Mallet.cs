using UnityEngine;
using UnityEngine.XR;
using System.Collections;

namespace VRKeys {

	public class Mallet : MonoBehaviour {
		public AudioClip clipToPlay;

		public enum MalletHand {
			Left,
			Right,
			Both,
			None
		}

		public MalletHand hand;

		public HandCollider handCollider;

		public bool isMovingDownward {
			get { return _isMovingDownward; }
			private set { _isMovingDownward = value; }
		}

		private bool _isMovingDownward = false;

		private AudioSource audioSource;

		private Controller controller;

		private Vector3 prevPos = Vector3.zero;

		private void Awake () {
			audioSource = GetComponent<AudioSource> ();
			controller = GetComponent<Controller> ();
		}

		private void FixedUpdate () {
			Vector3 curVel = (transform.position - prevPos) / Time.fixedDeltaTime;

			isMovingDownward = (curVel.y <= 0f);

			prevPos = transform.position;
		}	
		public void HandleTriggerEnter (Key key) {
			audioSource.Stop ();
			audioSource.PlayOneShot (clipToPlay);

			if (transform.parent.transform.parent != null) {
				controller.TriggerPulse ();
			}
		}

		/// <summary>
		/// Get the attached Controller class for input abstractions.
		/// </summary>
		/// <returns>Controller.</returns>
		public Controller Controller () {
			return controller;
		}
	}
}