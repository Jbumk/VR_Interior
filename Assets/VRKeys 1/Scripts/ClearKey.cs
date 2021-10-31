using UnityEngine;
using System.Collections;

namespace VRKeys {

	public class ClearKey : Key {

		public override void HandleTriggerEnter (Collider other) {
			keyboard.SetText ("");

			ActivateFor (0.3f);
		}

		public override void UpdateLayout (Layout translation) {
			label.text = translation.clearButtonLabel;
		}
	}
}