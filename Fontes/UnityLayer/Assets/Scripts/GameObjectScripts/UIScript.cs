using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
	private static UIScript instance;
	public GameObject logPanel;
	public GameObject logButton;
	public GameObject northPanel;
	public Text textoLog;

    void Start()
    {
		instance = this;

		logPanel.SetActive(false);
		logButton.SetActive(false);
		northPanel.SetActive(false);
	}

	void Update()
	{
		logButton.SetActive(WorldScript.WorldInstance().IsDebugMode());
		northPanel.SetActive(WorldScript.WorldInstance().IsDebugMode());
	}

	internal static void AddLog(string Message)
	{
		Instance().textoLog.text += Message + "\n";
	}

	public void ShowHidePanel()
	{
		logPanel.SetActive(!logPanel.activeSelf);
	}

	public static UIScript Instance()
	{
		return instance;
	}
}
