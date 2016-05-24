using System;
using UnityEngine;
using System.Collections;

public class WallBallKiller : MonoBehaviour
{
    public event Action BallKilled;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "BallTag")
        {
            //Destroy(collision.gameObject);
            if (BallKilled != null) BallKilled();
        }
    }


}
