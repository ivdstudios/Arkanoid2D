﻿using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

	static MusicPlayer instance = null ; 

	void Awake()
	{
		if(instance != null)
		{
			Destroy(gameObject);
			print("Music Player is self-destructing"); 
		}
		else{
			instance = this; 
			GameObject.DontDestroyOnLoad(instance); 
		}
	}

	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {

	}
}
