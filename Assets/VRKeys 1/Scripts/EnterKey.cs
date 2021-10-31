using UnityEngine;
using System.Collections;

namespace VRKeys {


	public class EnterKey : Key {

		public override void HandleTriggerEnter (Collider other) {
			keyboard.Submit ();
		}

		public override void UpdateLayout (Layout translation) {
			label.text = translation.enterButtonLabel;
		}
	}
}