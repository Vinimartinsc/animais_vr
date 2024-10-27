using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine.UI;
using UnityEngine;

public class msg : MonoBehaviour
{

	public GameObject title;
	public GameObject submessage;
	public GameObject panel;
	public GameObject titulo1;
	public GameObject titulo2;
	public string text;
	public string submsg;
	public string t1,t2;
	public AudioSource onomatopeia;
	public Boolean activeAudio;
	

	public void Awake()
	{

		onomatopeia = GetComponent<AudioSource>();

	}
	
	
	private void OnTriggerEnter(Collider other)
	{
		panel.SetActive(true);
		submessage.SetActive(true);
		title.SetActive(true);
		
		if (titulo1 != null || titulo2 != null)
		{
			titulo1.SetActive(true);
			titulo2.SetActive(true);
		}

		if (text == null)
		{
			text = "";
		}

		if (submsg == null)
		{
			submsg = "";
		}

		title.GetComponent<Text>().text = text;
		submessage.GetComponent<Text>().text = submsg;
		
		if (titulo1 != null || titulo2 != null)
		{
			titulo1.GetComponent<Text>().text = t1;
			titulo2.GetComponent<Text>().text = t2;
		}

		if (activeAudio)
		{
			onomatopeia.Play(0);
		}

	}

	private void OnTriggerStay(Collider other)
	{
		//throw new System.NotImplementedException();
	}

	private void OnTriggerExit(Collider other)
	{
		panel.SetActive(false);
		submessage.SetActive(false);
		title.SetActive(false);
		onomatopeia.Pause();
		
		if (titulo1 != null || titulo2 != null)
		{
			titulo1.SetActive(false);
			titulo2.SetActive(false);
		}
	}
}
