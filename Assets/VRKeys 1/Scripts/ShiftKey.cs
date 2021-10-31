using UnityEngine;
using System.Collections;

namespace VRKeys {


	public class ShiftKey : Key {
		private bool shifted = false;

		public override void HandleTriggerEnter (Collider other) {
			keyboard.ToggleShift ();
		}

		public override void Enable () {
			base.Enable ();

			meshRenderer.material = shifted ? activeMat : inactiveMat;
		}

		public void Toggle (bool shift) {
			shifted = shift;

			meshRenderer.material = shifted ? activeMat : inactiveMat;
		}

		public override void UpdateLayout (Layout translation) {
			label.text = translation.shiftButtonLabel;
		}
	}
}