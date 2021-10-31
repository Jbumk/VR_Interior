using UnityEngine;
using VRKeys.Layouts;

namespace VRKeys {

	public enum KeyboardLayout {
		Qwerty,
		French,
		Dvorak
	}

	public static class LayoutList {

		public static Layout GetLayout (KeyboardLayout layout) {
			switch (layout) {
				case KeyboardLayout.French:
					return new French ();

				case KeyboardLayout.Dvorak:
					return new Dvorak ();

				default:
					return new Layout ();
			}
		}
	}
}