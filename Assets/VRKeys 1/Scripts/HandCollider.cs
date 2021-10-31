using UnityEngine;
using System.Collections;

namespace VRKeys {

	public class HandCollider : MonoBehaviour {
		public Mallet mallet;

		public bool inKeyboard = false;

		private void OnTriggerEnter (Collider other) {
			if (other.gameObject.name == "KeyboardCollider") {
				inKeyboard = true;
			}
		}

		private void OnTriggerExit (Collider other) {
			if (other.gameObject.name == "KeyboardCollider") {
				inKeyboard = false;
			}
		}
	}
}