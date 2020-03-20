using UnityEngine;
using UnityEditor;
using System.IO;

namespace Ateo
{
	[InitializeOnLoad]
	public class CheckForReferences
	{
		static CheckForReferences ()
		{
			try {
				StreamReader stream = File.OpenText (System.IO.Path.Combine (Application.dataPath, "GoogleVR/Scripts/GvrUnitySdkVersion.cs"));
				if (stream == null) {
					Debug.Log ("GoogleVR (Version >=1.1) is needed in order to use the AutoClick unity package!" +
					"You can download it at https://developers.google.com/vr/unity/download ");
				} else {
					#if !AutoClickDevelopment
					AssetDatabase.Refresh ();
					if (File.Exists (System.IO.Path.Combine (Application.dataPath, "GoogleVR/Scripts/GvrUnitySdkVersion.cs"))) {
						string file = File.ReadAllText (System.IO.Path.Combine (Application.dataPath, "GoogleVR/Scripts/GvrUnitySdkVersion.cs"));
						if (!file.Contains(" GVR_SDK_VERSION =")) {							
							if (CheckForVersion.Version != 1.3f) {
					Debug.Log("Old GVR Version found");
								string content = File.ReadAllText (System.IO.Path.Combine (Application.dataPath, "GazeClick/Editor/Version1.3.txt"));
								File.WriteAllText (System.IO.Path.Combine (Application.dataPath, "GazeClick/Editor/CheckForVersion.cs"), content);
								AssetDatabase.Refresh ();
							}
						} else {
					Debug.Log("New GVR Version found");

							if (CheckForVersion.Version != 1.4f) {
								string content = File.ReadAllText (System.IO.Path.Combine (Application.dataPath, "GazeClick/Editor/Version1.4.txt"));
								File.WriteAllText (System.IO.Path.Combine (Application.dataPath, "GazeClick/Editor/CheckForVersion.cs"), content);
								AssetDatabase.Refresh ();
							}
						}
					} else {
					}
					#endif
				}
			} catch (System.Exception ex) {
				
				Debug.Log ("GoogleVR (Version >=1.1) is needed in order to use the AutoClick unity package!" +
					"If you have a suiting GoogleVR Version ignore this message. "+
					" Else you can download it at https://developers.google.com/vr/unity/download "
					 + "The reason why this message came up is " + ex.ToString());
			}	
		}
	}
}