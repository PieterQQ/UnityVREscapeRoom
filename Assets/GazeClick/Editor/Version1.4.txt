using UnityEngine;
using UnityEditor;
using System.IO;

namespace Ateo
{


	[InitializeOnLoad]
	public class CheckForVersion
	{
		public static float Version = 1.4f;

		static CheckForVersion ()
		{
			#if !AutoClickDevelopment

			float version = float.Parse (GvrUnitySdkVersion.GVR_SDK_VERSION.Remove (3));
			if (version < 1.2f) {

				//string file = File.ReadAllText (System.IO.Path.Combine (Application.dataPath, "GazeClick/Implementation/GazeClick.cs"));
				if (GazeClick.GazeClickVersion < 6) {	
					string content = File.ReadAllText (System.IO.Path.Combine (Application.dataPath, "GazeClick/Implementation/Version1.7.txt"));
					Debug.Log ("Google VR Version " + GvrUnitySdkVersion.GVR_SDK_VERSION + " found. Importing GazeClick Version 1.7.");
					File.WriteAllText (System.IO.Path.Combine (Application.dataPath, "GazeClick/Implementation/GazeClick.cs"), content);
				}
			} else if (version < 1.4f) {
				//string file = File.ReadAllText (System.IO.Path.Combine (Application.dataPath, "GazeClick/Implementation/GazeClick.cs"));
				if (GazeClick.GazeClickVersion < 6) {	
					string content = File.ReadAllText (System.IO.Path.Combine (Application.dataPath, "GazeClick/Implementation/Version1.7.txt"));
					Debug.Log ("Google VR Version " + GvrUnitySdkVersion.GVR_SDK_VERSION + " found. This version may not be supported yet.");
					Debug.Log ("You are using a version of GoogleVR which may not be supported by GazeClick yet. You can find older Versions of GoogleVR here: https://github.com/googlevr/gvr-unity-sdk");
					DoPopup ();
					File.WriteAllText (System.IO.Path.Combine (Application.dataPath, "GazeClick/Implementation/GazeClick.cs"), content);
				}
			} else if (version < 1.5f) {
				//string file = File.ReadAllText (System.IO.Path.Combine (Application.dataPath, "GazeClick/Implementation/GazeClick.cs"));
				if (GazeClick.GazeClickVersion < 4) {	
					string content = File.ReadAllText (System.IO.Path.Combine (Application.dataPath, "GazeClick/Implementation/Version1.4.txt"));
					Debug.Log ("Google VR Version " + GvrUnitySdkVersion.GVR_SDK_VERSION + " found. Importing GazeClick Version 1.4.");
					File.WriteAllText (System.IO.Path.Combine (Application.dataPath, "GazeClick/Implementation/GazeClick.cs"), content);
				}
			} else if (version <= 1.6f) {
				//string file = File.ReadAllText (System.IO.Path.Combine (Application.dataPath, "GazeClick/Implementation/GazeClick.cs"));
				if (GazeClick.GazeClickVersion < 5) {	
					string content = File.ReadAllText (System.IO.Path.Combine (Application.dataPath, "GazeClick/Implementation/Version1.5.txt"));
					Debug.Log ("Google VR Version " + GvrUnitySdkVersion.GVR_SDK_VERSION + " found. Importing GazeClick Version 1.5-1.6.");
					File.WriteAllText (System.IO.Path.Combine (Application.dataPath, "GazeClick/Implementation/GazeClick.cs"), content);
				}
			}  else if (version <= 1.7f) {
				//string file = File.ReadAllText (System.IO.Path.Combine (Application.dataPath, "GazeClick/Implementation/GazeClick.cs"));
				if (GazeClick.GazeClickVersion < 6) {	
					string content = File.ReadAllText (System.IO.Path.Combine (Application.dataPath, "GazeClick/Implementation/Version1.7.txt"));
					Debug.Log ("Google VR Version " + GvrUnitySdkVersion.GVR_SDK_VERSION + " found. Importing GazeClick Version 1.7.");
					File.WriteAllText (System.IO.Path.Combine (Application.dataPath, "GazeClick/Implementation/GazeClick.cs"), content);
				}
			}else {
				//string file = File.ReadAllText (System.IO.Path.Combine (Application.dataPath, "GazeClick/Implementation/GazeClick.cs"));
				if (GazeClick.GazeClickVersion < 6) {	
					string content = File.ReadAllText (System.IO.Path.Combine (Application.dataPath, "GazeClick/Implementation/Version1.7.txt"));
					Debug.Log ("Google VR Version " + GvrUnitySdkVersion.GVR_SDK_VERSION + " found. This version may not be supported yet.");
					Debug.Log ("You are using a version of GoogleVR which may not be supported by GazeClick yet. You can find older Versions of GoogleVR here: https://github.com/googlevr/gvr-unity-sdk");
					DoPopup ();
					File.WriteAllText (System.IO.Path.Combine (Application.dataPath, "GazeClick/Implementation/GazeClick.cs"), content);
				}
			}
			#endif
		}

		static void DoPopup ()
		{
			GazeClickWarning window = ScriptableObject.CreateInstance<GazeClickWarning> ();
			window.position = new Rect (Screen.width / 2, Screen.height / 2, 400, 200);
			window.ShowPopup ();
		}
	}

}