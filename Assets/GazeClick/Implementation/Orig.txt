// Basic Version will be overwritten.

using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Ateo {

	public class GazeClick : MonoBehaviour	{

		public const int GazeClickVersion=-1;

		[Tooltip ("How long the circle waits before starting the rotation after the expansion. (in Seconds)")]
		public float DelayBeforeRotation = 0.1f;

		[Tooltip ("How long the circle waits before the click happens after finishing the rotation. (in Seconds)")]
		public float DelayBeforeClick = 0.1f;

		[Tooltip ("How long the rotation of the circle takes. (in Seconds)")]
		public float RotationDuration = 1.5f;

		[Tooltip ("If the original color should be used.")]
		public bool UseOriginalColor = true;
		[Tooltip ("The color of the initial front circle during rotation if UseOriginalColor is set to false.")]
		public Color FillColor = Color.white;
		[Tooltip ("The color of the background circle during rotation if UseOriginalColor is set to false.")]
		public Color BackgroundColor = new Color (1, 1, 1, 0.5f);

		[Tooltip ("The alpha value of the background during the rotation, the smaler the value the less visible.")]
		public float BackgroundAlpha = 0.3f;


		[Tooltip ("The direction in which the circle rotates.")]
		public RotationDirection RotationDirection = RotationDirection.clockwise;
		[Tooltip ("Where the rotation begins.")]
		public RotationStart RotationStart = RotationStart.top;


		[Tooltip ("Precision of movement recognized. The smaller this is the more sensible it is for small shakes.")]
		public float Precision = 0.01f;

		[Tooltip ("The name of a float in the used shader (only change if the shader changed)")]
		public string InnerCircle = "_InnerDiameter";

		[Tooltip ("The name of a float in the used shader (only change if the shader changed)")]
		public string OuterCircle = "_OuterDiameter";

		[Tooltip ("The name of a float in the used shader (only change if the shader changed)")]
		public string Distance = "_DistanceInMeters";


	}

	public enum LoockingState	{
		normal,
		spinning,
		finished,
		clicked
	}

	public enum RotationDirection	{
		clockwise,
		counterclockwise
	}

	public enum RotationStart	{
		top,
		bottom,
		right,
		left
	}
}