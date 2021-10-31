using UnityEngine;
using System.Collections;

namespace VRKeys {

	public class SpaceKey : Key {

		public override void HandleTriggerEnter (Collider other) {
			keyboard.AddCharacter (" ");

			ActivateFor (0.3f);
		}

		public override void UpdateLayout (Layout translation) {
			label.text = translation.spaceButtonLabel;
		}
	}
}