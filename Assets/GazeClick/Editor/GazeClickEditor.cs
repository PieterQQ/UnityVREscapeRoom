using UnityEngine;
using UnityEditor;
using System.Collections;
using Ateo;


[CustomEditor(typeof(GazeClick))]

public class GazeClickEditor: Editor {


	SerializedObject click;

	void OnEnable()
	{
		click = new SerializedObject (target); 
	}

	bool showAdvancedOptions=false;
	public override void OnInspectorGUI()
	{
		click.Update ();
		var property = click.FindProperty ("DelayBeforeRotation");
		EditorGUILayout.PropertyField (property);

		property = click.FindProperty ("DelayBeforeClick");
		EditorGUILayout.PropertyField (property);

		property = click.FindProperty ("RotationDuration");
		EditorGUILayout.PropertyField (property);

		property = click.FindProperty ("UseOriginalColor");
		EditorGUILayout.PropertyField (property);

		if (!property.boolValue) {
			property = click.FindProperty ("FillColor");
			EditorGUILayout.PropertyField (property);

			property = click.FindProperty ("BackgroundColor");
			EditorGUILayout.PropertyField (property);
		} else {
			property = click.FindProperty ("BackgroundAlpha");
			EditorGUILayout.PropertyField (property);
		}

		property = click.FindProperty ("RotationDirection");
		EditorGUILayout.PropertyField (property);

		property = click.FindProperty ("RotationStart");
		EditorGUILayout.PropertyField (property);

		if (!showAdvancedOptions) {		
		

			if (GUILayout.Button ("Show Advanced Options")) {
				showAdvancedOptions = true;
			}

		} else {

			GUILayout.BeginHorizontal ();
			GUILayout.Label (" ");
			GUILayout.EndHorizontal ();

			if (GUILayout.Button ("Hide Advanced Options")) {
				showAdvancedOptions = false;
			}

			GUILayout.BeginHorizontal ();
			GUILayout.Label (" ");
			GUILayout.EndHorizontal ();

			GUILayout.BeginHorizontal ();
			GUILayout.Label ("Do not change these parameters if GazeClick works for your setup!");
			GUILayout.EndHorizontal ();

			GUILayout.BeginHorizontal ();
			GUILayout.Label (" ");
			GUILayout.EndHorizontal ();

			property = click.FindProperty ("Precision");
			EditorGUILayout.PropertyField (property);

			property = click.FindProperty ("InnerCircle");
			EditorGUILayout.PropertyField (property);

			property = click.FindProperty ("OuterCircle");
			EditorGUILayout.PropertyField (property);

			property = click.FindProperty ("Distance");
			EditorGUILayout.PropertyField (property);

		}
		click.ApplyModifiedProperties ();

	}

}
