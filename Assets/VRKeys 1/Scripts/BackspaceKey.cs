using UnityEngine;
using System.Collections;

namespace VRKeys {

	public class BackspaceKey : Key {

		public override void HandleTriggerEnter (Collider other) {
			keyboard.Backspace ();

			ActivateFor (0.3f);
		}

		public override void UpdateLayout (Layout translation) {
			label.text = translation.backspaceButtonLabel;
		}
	}
}