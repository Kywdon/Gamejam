﻿using UnityEngine;
using System.Collections;

public class Chargement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void OnMouseDown()
    {
        Debug.Log("test");
        Application.LoadLevel(1);
    }
}
