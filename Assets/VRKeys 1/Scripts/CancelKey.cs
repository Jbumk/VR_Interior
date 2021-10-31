using UnityEngine;
using System.Collections;

namespace VRKeys {


	public class CancelKey : Key {

		public override void HandleTriggerEnter (Collider other) {
			keyboard.Cancel ();
		}

		public override void UpdateLayout (Layout translation) {
			label.text = translation.cancelButtonLabel;
		}
	}
}