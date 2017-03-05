using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ProgressBar;

public class Quest : MonoBehaviour {
	public Image progressbar;
	public Text progressbarText;
	public Image questIcon;
	public Text questTitle;
	public Text questLevel;
	public float endQuestTime;

	// Use this for initialization
	void Start () {
		
	}

	float questTime = 0.01f;
	// Update is called once per frame
	void Update () {
//		if (questTime == 0f)
//		{
//			timeProgressBar.SetFillerSizeAsPercentage(0f);
//			questTime += Time.deltaTime;
//			return;
//		}
		questTime += Time.deltaTime;

		progressbar.fillAmount = questTime / endQuestTime;
		progressbarText.text = string.Format("{0}%", (int)(progressbar.fillAmount * 100f));

		//Debug.Log(timeProgressBar.Value);
		if (questTime >= endQuestTime)
		{
			questTime = 0f;
			//timeProgressBar.SetFillerSizeAsPercentage(100f);
			progressbar.fillAmount = 0f;
		}
	}
}
