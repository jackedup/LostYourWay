using UnityEngine;

public class ResetButton : MonoBehaviour
{
	private bool showText;

	private void OnMouseDown()
	{
		if (!showText)
		{
			showText = true;
		}
	}

	private void OnGUI()
	{
		if (showText && GUI.Button(new Rect(710f, 425f, 200f, 40f), "Your score has been reset!"))
		{
			showText = false;
		}
	}
}
