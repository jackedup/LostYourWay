using UnityEngine;

public class Timerr : MonoBehaviour
{
	public bool runTimer;

	public string seconds = "0";

	public float sec;

	public float minutes;

	public float intsec;

	public string time;

	private void Update()
	{
		if (runTimer)
		{
			sec += Time.deltaTime;
			intsec = sec;
			if (intsec < 10f)
			{
				seconds = "0" + intsec;
			}
			else
			{
				seconds = intsec.ToString();
			}
			if (intsec >= 60f)
			{
				minutes += 1f;
				sec = 0f;
			}
			time = minutes + ":" + seconds;
		}
	}

	private void OnGUI()
	{
		GameObject.Find("TimerText").GetComponent<GUIText>().text = time;
	}
}
