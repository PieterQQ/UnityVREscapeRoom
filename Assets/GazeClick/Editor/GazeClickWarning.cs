using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Ateo
{

	public class GazeClickWarning : EditorWindow{

		void OnGUI (){
			EditorGUILayout.LabelField("Warning!", EditorStyles.boldLabel);
			EditorGUILayout.LabelField ("\n \nYou are using the newest version of GoogleVR. \nThis version MAY not be supported by GazeClick yet. \nThis could possibly lead to errors.  " +
				"\nIf needed you can find older Versions of GoogleVR here: \nhttps://github.com/googlevr/gvr-unity-sdk " +
				"\nIgnore this message, if everything is working.", EditorStyles.wordWrappedLabel);

			GUILayout.Space (50);
			if (GUILayout.Button ("OK"))
				this.Close ();
		}
	}

}
