﻿using UnityEngine;
using System.Collections;
using BT;
public class SmartObjecttest : SmartObject {

	
	// Use this for initialization
	void Start () {
		init();
		manager.register_sm(this);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
