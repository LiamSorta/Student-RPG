﻿using UnityEngine;
using System.Collections;

public class Cafe_Door : MonoBehaviour {

    //
    // Script by
    // Josh Bannister
    //

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Application.LoadLevel("Cafe");
        }
    }
}