﻿using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour {

	// Use this for initialization
	void StartBall () {
	        this.GetComponent<Rigidbody2D>().velocity=new Vector2(1f,-150f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void EndAnim()
    {
        Destroy(gameObject);
        //gameObject.SetActive(false);
        
    }

}
